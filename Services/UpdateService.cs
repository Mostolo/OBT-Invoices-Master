using System.Net;
using System.Text.Json;
using OBT_Invoices_Master.Models;

namespace OBT_Invoices_Master.Services
{
    internal class UpdateService
    {
        public static async Task<UpdateInfo?> GetLatestStableUpdateAsync()
        {
            using HttpClient client = new();

            client.DefaultRequestHeaders.UserAgent.ParseAdd("Maki-Invoice-Manager");
            string url = "https://api.github.com/repos/Mostolo/OBT-Invoices-Master/releases/latest";

            using HttpResponseMessage response = await client.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }

            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            using JsonDocument document = JsonDocument.Parse(json);

            string? tag = document.RootElement.GetProperty("tag_name").GetString();

            #region Assets

            JsonElement assets = document.RootElement.GetProperty("assets");

            string? downloadUrl = null;

            foreach (JsonElement asset in assets.EnumerateArray())
            {
                string? assetName = asset.GetProperty("name").GetString();

                if (assetName == "MakiInvoiceManager-win-x64.zip")
                {
                    downloadUrl = asset.GetProperty("browser_download_url").GetString();

                    break;
                }
            }

            #endregion

            return new UpdateInfo
            {
                Version = tag,
                DownloadUrl = downloadUrl
            };
        }
    }
}
