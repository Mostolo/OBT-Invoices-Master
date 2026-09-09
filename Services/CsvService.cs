using OBT_Invoices_Master.Models;

namespace OBT_Invoices_Master.Services
{
    public class CsvService
    {
        public void ExportInvoices(List<Invoice> invoices, string outputPath)
        {
            outputPath = Path.Combine(outputPath, "File da Incollare.CSV");

            using StreamWriter writer = new(outputPath);
            writer.WriteLine("Mittente; Data; Numero; Importo; Imponibile; Metodo pagamento; Scadenza; Pagamento Effettuato; Data Pagamento; Da Pagare; Descrizione Aggiuntiva; Centro di costo; Conto di competenza; Ordine;");
            foreach (Invoice invoice in invoices)
            {
                writer.WriteLine(string.Join(";",
                    invoice.Denominazione,
                    invoice.Data,
                    invoice.Numero,
                    invoice.Totale,
                    invoice.Imponibile,
                    invoice.MetodoPagamento,
                    invoice.ScadenzaPagamento,
                    invoice.ImportoPagamento,
                    invoice.DataPagamento,
                    invoice.DaPagare,
                    invoice.DescrizioneAggiuntiva,
                    invoice.CentroCosto,
                    invoice.ContoCompetenza
                    ));
            }
        }
    }
}
