namespace OBT_Invoices_Master.Models
{
    public class Invoice
    {
        public string? Denominazione { get; set; }
        public string? Numero { get; set; }
        public string? TipoDocumento { get; set; }
        public string? MetodoPagamento { get; set; }
        public string? Data { get; set; }
        public string? ScadenzaPagamento { get; set; }
        public decimal? Totale { get; set; }
        public decimal? Imponibile { get; set; }
        public decimal? ImportoPagamento { get; set; }
        public string? DataPagamento { get; set; }
        public string? XmlPath { get; set; }
        public string? PdfPath { get; set; }
        public string? PdfName { get; set; }

    }
}