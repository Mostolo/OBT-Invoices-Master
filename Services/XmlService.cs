using OBT_Invoices_Master.Models;
using OBT_Invoices_Master.Utilities;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OBT_Invoices_Master.Services
{
    public class XmlService
    {
        public Invoice ReadInvoice(string xmlPath)
        {
            Invoice invoice = new();

            var doc = XDocument.Load(xmlPath);
            var root = doc.Root;

            var datiGenerali = root?.Descendants("DatiGeneraliDocumento").FirstOrDefault();
            var dettagliPagamento = root?.Descendants("DettaglioPagamento").FirstOrDefault();
            var datiBeniServizi = root?.Descendants("DatiBeniServizi").FirstOrDefault();
            var cedentePrestatore = root?.Descendants("CedentePrestatore").FirstOrDefault();

            string? modalitaPagamento = (string?)dettagliPagamento?.Element("ModalitaPagamento");

            invoice.TipoDocumento = (string?)datiGenerali?.Element("TipoDocumento");
            invoice.Numero = (string?)datiGenerali?.Element("Numero");
            invoice.Data = (string?)datiGenerali?.Element("Data");
            invoice.Totale = (decimal?)datiGenerali?.Element("ImportoTotaleDocumento") ?? 0;
            invoice.Denominazione = (string?)cedentePrestatore?.Descendants("Denominazione").FirstOrDefault() ?? 
                $"{(string?)cedentePrestatore?.Descendants("Nome").FirstOrDefault()} {(string?)cedentePrestatore?.Descendants("Cognome").FirstOrDefault()}";

            invoice.Imponibile = (decimal?)datiBeniServizi?.Descendants("DatiRiepilogo").Elements("ImponibileImporto").Select(x => (decimal?)x).Where(x => x.HasValue).Sum();
            invoice.ScadenzaPagamento = (string?)dettagliPagamento?.Element("DataScadenzaPagamento")?? invoice.Data;
            invoice.MetodoPagamento = GetPaymentMethod(modalitaPagamento!);
            invoice.XmlPath = xmlPath;
            invoice.PdfPath = Path.Combine(Path.GetDirectoryName(xmlPath!)!, Path.GetFileName(xmlPath).Split('.')[0] + ".pdf");

            #region The ifs
            //if the invoice is a "Nota di Credito"
            if (invoice.TipoDocumento == "TD04")
            {
                invoice.Totale = invoice.Totale.HasValue ? -Math.Abs(invoice.Totale.Value) : null;
                invoice.Imponibile = invoice.Imponibile.HasValue ? -Math.Abs(invoice.Imponibile.Value) : null;
            }

            //if the invoice is by card or Sepa
            if (invoice.MetodoPagamento == "Sepa")
            {
                invoice.ImportoPagamento = invoice.Totale;
                invoice.DataPagamento = invoice.ScadenzaPagamento;
            }
            else if (invoice.MetodoPagamento == "Carta")
            {
                invoice.ImportoPagamento = invoice.Totale;
                invoice.DataPagamento = invoice.Data;
            }
            #endregion

            //return the new object "Invoice" filled with informations
            return invoice;
        }

        private string GetPaymentMethod(string code)
        {
            switch (code)
            {
                case "MP12":
                    return "Riba";

                case "MP05":
                    return "Bonifico";

                case "MP01":
                    return "Contanti";

                case "MP19":
                case "MP21":
                    return "Sepa";

                case "MP08":
                    return "Carta";

                default:
                    return "Sconosciuto";
            }
        }
    }
}