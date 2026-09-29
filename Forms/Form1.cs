using OBT_Invoices_Master.Utilities;
using OBT_Invoices_Master.Services;
using System.Diagnostics;
using System.Drawing.Text;
using System.Text.Json;
using System.IO;
using OBT_Invoices_Master.Forms;
using System.Xml.Serialization;

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
            string? latestVersion;

            try
            {
                latestVersion = await UpdateService.GetLatestStableVersionAsync();

                if (latestVersion is null)
                {
                    MessageBox.Show("Nessuna Release stabile trovata...");
                    return;
                }

                MessageBox.Show("Ultima versione stabile su GitHub: " + latestVersion, "la tua versione: " + currentVersionText);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore durante il controllo di aggiornamenti:\n" + ex.Message, "ERROREEE");

                return;
            }

            Version currentVersion = new(currentVersionText);
            Version githubVersion = new(latestVersion);

            if (githubVersion > currentVersion)
            {
                MessageBox.Show("È disponibile un aggiornamento!\n\nVersione installata: " + currentVersion + "\nNuova versione: " + githubVersion,
                    "Aggiornati!");
            }
            else
            {
                MessageBox.Show("Maki Invoice Manager è aggiornato all'ultima versione disponibile\n\nVersione installata: " + currentVersion,
                    "Sei aggiornato?");
            }
        }
    }
}