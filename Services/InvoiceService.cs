using OBT_Invoices_Master.Forms;
using OBT_Invoices_Master.Models;

namespace OBT_Invoices_Master.Services
{
    public class InvoiceService
    {
        private XmlService XmlService = new();
        private PdfService PdfService = new();
        private CsvService CsvService = new();

        public void ProcessFolder(string folderPath)
        {
            string XmlFolder = FolderService.CreateFolderHere(folderPath, "XML");
            string ErrorFolder = FolderService.CreateFolderHere(folderPath, "Errori");
            string PdfFolder = FolderService.CreateFolderHere(folderPath, "PDF");

            string reportPath = Path.Combine(ErrorFolder, "Report.txt"); 

            using StreamWriter writer = new(reportPath);

            List<Invoice> invoices = new();

            string[] xmlFiles = Directory.GetFiles(folderPath, "*.xml");
            List<string> xmlErrors = new();



            foreach (string xmlFile in xmlFiles)
            {
                string fileName = Path.GetFileName(xmlFile);

                try
                {
                    Invoice invoice = XmlService.ReadInvoice(xmlFile);
                    invoices.Add(invoice);
                    PdfService.RenamePdf(invoice);

                    File.Move(invoice.PdfPath!, Path.Combine(PdfFolder, invoice.PdfName!));
                    File.Move(xmlFile, Path.Combine(XmlFolder, fileName));
                }
                catch (Exception ex)
                {
                    xmlErrors.Add(xmlFile);

                    File.Move(xmlFile, Path.Combine(ErrorFolder, fileName));

                    string pdfName = Path.GetFileName(xmlFile).Split('.')[0] + ".pdf";
                    string pdfPath = Path.Combine(Path.GetDirectoryName(xmlFile)!, pdfName);
                    File.Move (pdfPath, Path.Combine(ErrorFolder, pdfName));

                    writer.WriteLine($"{fileName} ha dato questo errore:\n    {ex.Message}\n");
                }
            }
            if (xmlErrors.Count > 0)
            {
                MessageBox.Show($"Errore in {xmlErrors.Count} file\nsono stati spostati nella cartella Errori\nPer maggiori informazioni, leggere il report");
            }
            else
            {
                MessageBox.Show("tutto è andato bene!");
            }

            ReviewForm reviewForm = new ReviewForm(invoices);

            reviewForm.ShowDialog();

            if (reviewForm.completed)
            {
                CsvService.ExportInvoices(invoices, folderPath);
            }

        }

    }
}