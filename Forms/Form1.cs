using OBT_Invoices_Master.Utilities;
using OBT_Invoices_Master.Services;
using System.Diagnostics;
using System.Drawing.Text;
using System.Text.Json;
using System.IO;
using OBT_Invoices_Master.Forms;

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

    }
}