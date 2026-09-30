using OBT_Invoices_Master.Models;
using System.Diagnostics;
using System.Net;
using System.Text.Json;

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

        public static async Task<string> DownloadUpdateAsync(string downloadUrl, IProgress<DownloadProgress>? progress = null)
        {
            using HttpClient client = new()
            {
                Timeout = TimeSpan.FromMinutes(10)
            };

            client.DefaultRequestHeaders.UserAgent.ParseAdd("Maki-Invoice-Manager");

            string zipPath = Path.Combine(Path.GetTempPath(), "MakiInvoiceManager-update.zip");


            using HttpResponseMessage response = await client.GetAsync(downloadUrl, HttpCompletionOption.ResponseHeadersRead);

            response.EnsureSuccessStatusCode();

            long? totalBytes = response.Content.Headers.ContentLength;

            await using Stream downloadStream = await response.Content.ReadAsStreamAsync();

            await using FileStream fileStream = new(zipPath, FileMode.Create, FileAccess.Write, FileShare.None, 81920, true);

            byte[] buffer = new byte[81920];

            long downloadBytes = 0;

            Stopwatch stopwatch = Stopwatch.StartNew();

            while (true)
            {
                int bytesRead = await downloadStream.ReadAsync(buffer.AsMemory(0, buffer.Length));

                if (bytesRead == 0)
                {
                    break;
                }

                await fileStream.WriteAsync(buffer.AsMemory(0, bytesRead));

                downloadBytes += bytesRead;

                double bytesPerSecond = stopwatch.Elapsed.TotalSeconds > 0 ? downloadBytes / stopwatch.Elapsed.TotalSeconds : 0;

                TimeSpan? remaining = null;

                if (totalBytes.HasValue && bytesPerSecond > 0)
                {
                    long remainingBytes = totalBytes.Value - downloadBytes;

                    remaining = TimeSpan.FromSeconds(remainingBytes / bytesPerSecond);
                }

                progress?.Report(new DownloadProgress
                {
                    BytesDownloaded = downloadBytes,
                    TotalBytes = totalBytes,
                    BytesPerSecond = bytesPerSecond,
                    Elapsed = stopwatch.Elapsed,
                    Remaining = remaining
                });
            }

            return zipPath;
        }

        public static void StartUpdater(string zipPath)
        {
            string targetDirectory = AppContext.BaseDirectory;

            string updaterSourcePath = Path.Combine(
                targetDirectory,
                "OBT-Updater.exe"
            );

            string tempUpdaterPath = Path.Combine(
                Path.GetTempPath(),
                "OBT-Updater.exe"
            );

            if (!File.Exists(updaterSourcePath))
            {
                throw new FileNotFoundException(
                    "Non trovo OBT-Updater.exe",
                    updaterSourcePath
                );
            }

            File.Copy(
                updaterSourcePath,
                tempUpdaterPath,
                true
            );

            int processId = Environment.ProcessId;

            string exeName = Path.GetFileName(
                Environment.ProcessPath!
            );

            ProcessStartInfo startInfo = new()
            {
                FileName = tempUpdaterPath,
                UseShellExecute = true
            };

            startInfo.ArgumentList.Add(zipPath);
            startInfo.ArgumentList.Add(targetDirectory);
            startInfo.ArgumentList.Add(processId.ToString());
            startInfo.ArgumentList.Add(exeName);

            Process.Start(startInfo);
        }
    }
}
