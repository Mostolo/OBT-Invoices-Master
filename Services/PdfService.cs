using OBT_Invoices_Master.Models;
using OBT_Invoices_Master.Utilities;

namespace OBT_Invoices_Master.Services
{
    public class PdfService
    {
        public void RenamePdf(Invoice invoice)
        {
            if (!File.Exists(invoice.PdfPath))
            {
                return;
            }

            string mittente = Generic.PulisciNome(invoice.Denominazione);
            string data = string.Join("-", (((invoice.Data!).Split(' '))[0].Split('/')).Reverse());
            string numero = Generic.PulisciNome(invoice.Numero!);
            string newFileName = $"{data} Ft {numero} - {mittente}.pdf";

            string newPath = Path.Combine(Path.GetDirectoryName(invoice.PdfPath)!, newFileName);

            File.Move(invoice.PdfPath, newPath);
            invoice.PdfPath = newPath;
            invoice.PdfName = newFileName;
        }
    }
}