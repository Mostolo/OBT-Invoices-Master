//using System.Reflection;
//using System.Text.Json;

using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

namespace OBT_Invoices_Master.Services
{
    internal class UpdateService
    {
        public static async Task<string?> GetLatestStableVersionAsync()
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

            return tag;
        }
    }
}
