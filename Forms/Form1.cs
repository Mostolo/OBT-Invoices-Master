using OBT_Invoices_Master.Utilities;
using OBT_Invoices_Master.Services;
using System.Diagnostics;
using System.Drawing.Text;
using System.Text.Json;
using System.IO;
using OBT_Invoices_Master.Forms;
using System.Xml.Serialization;
using OBT_Invoices_Master.Models;

namespace OBT_Invoices_Master
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = ConfigService.SetRandomWindowTitle();
            this.AllowDrop = true;
            this.DragEnter += Form1_DragEnter;
            this.DragDrop += Form1_DragDrop;
            this.Shown += Form1_Shown;
        }

        #region Drag & Drop
        private void Form1_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data!.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void Form1_DragDrop(object? sender, DragEventArgs e)
        {
            var paths = (string[])e.Data!.GetData(DataFormats.FileDrop)!;

            string folder = paths.First();

            FolderService.SaveCsv(folder, paths);
        }
        #endregion

        private async void Form1_Shown(Object? sender, EventArgs e)
        {
            string currentVersionText = (this.ProductVersion.Split("+"))[0];
            UpdateInfo? updateInfo;

            try
            {
                updateInfo = await UpdateService.GetLatestStableUpdateAsync();

                if (updateInfo is null || updateInfo.Version is null)
                {
                    MessageBox.Show("Nessuna Release stabile trovata...");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore durante il controllo di aggiornamenti:\n" + ex.Message, "ERROREEE");

                return;
            }

            Version currentVersion = new(currentVersionText);
            Version githubVersion = new(updateInfo.Version);

            if (githubVersion > currentVersion)
            {
                DialogResult result = MessageBox.Show("È disponibile un aggiornamento!\n\nVersione installata: " + currentVersion + "\nNuova versione: " + githubVersion,
                    "Aggiornati!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                if (result != DialogResult.Yes)
                {
                    return;
                }

                if (updateInfo.DownloadUrl is null)
                {
                    MessageBox.Show("Impossibile ricavare il file di aggiornamento\nContattare Marco LC", "Errore nell'aggiornamento!");

                    return;
                }

                string zipPath = await UpdateService.DownloadUpdateAsync(updateInfo.DownloadUrl);

                MessageBox.Show("Aggiornamento scaricato!\n\n" + zipPath, "Download completato");

            }
            else
            {
                MessageBox.Show("Maki Invoice Manager è aggiornato all'ultima versione disponibile\n\nVersione installata: " + currentVersion,
                    "Sei aggiornato?");
            }
        }
    }
}