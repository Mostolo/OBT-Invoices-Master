using OBT_Invoices_Master.Controls;
using OBT_Invoices_Master.Models;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace OBT_Invoices_Master.Forms
{
    public partial class ReviewForm : Form
    {
        private List<Invoice> invoices;
        private int currentIndex = 0;


        private InvoiceFieldControl DenominazioneField;
        private InvoiceFieldControl DataField;
        private InvoiceFieldControl NumeroField;
        private InvoiceFieldControl TotaleField;
        private InvoiceFieldControl ImponibileField;
        private InvoiceFieldControl MetodoPagamentoField;
        private InvoiceFieldControl ScadenzaPagamentoField;
        private InvoiceFieldControl DataPagamentoField;
        private InvoiceFieldControl DescrizioneAggiuntivaField;
        private InvoiceFieldControl CentroCostoField;
        private InvoiceFieldControl ContoCompetenzaField;

        public bool completed { get; private set; }
        public ReviewForm(List<Invoice> invoices)
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            DenominazioneField = SetField("Mittente", grpAutomaticFields);
            DataField = SetField("Data", grpAutomaticFields);
            NumeroField = SetField("Numero", grpAutomaticFields);
            TotaleField = SetField("Totale", grpAutomaticFields);
            ImponibileField = SetField("Imponibile", grpAutomaticFields);
            MetodoPagamentoField = SetField("Metodo Pagamento", grpAutomaticFields);
            ScadenzaPagamentoField = SetField("Scadenza Pagamento", grpAutomaticFields);
            DataPagamentoField = SetField("Data Pagamento", grpAutomaticFields);
            DescrizioneAggiuntivaField = SetField("Descrizione Aggiuntiva", grpUserFields);
            CentroCostoField = SetField("Centro Costo", grpUserFields);
            ContoCompetenzaField = SetField("Conto Competenza", grpUserFields);

            this.invoices = invoices;

            if (this.invoices.Count == 0)
            {
                MessageBox.Show("La lista delle fatture è vuota!");
                return;
            }

            ShowInvoice();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveCurrentInvoice();

            if (currentIndex < invoices.Count - 1)
            {
                currentIndex++;
                ShowInvoice();
            }
            else
            {
                completed = true;
                MessageBox.Show("Hai terminato tutte le fatture!", "Complimenti!");
                //Close(); 
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            SaveCurrentInvoice();

            if (currentIndex > 0)
            {
                currentIndex--;
                ShowInvoice();
            }
            else
            {
                MessageBox.Show("Non ci sono fatture li...", "Dove vuoi andare?");
            }
        }

        private void ShowInvoice()
        {
            Invoice invoice = invoices[currentIndex];

            DenominazioneField.Value = invoice.Denominazione ?? "";
            DataField.Value = invoice.Data ?? "";
            NumeroField.Value = invoice.Numero ?? "";
            TotaleField.Value = invoice.Totale.ToString() ?? "";
            ImponibileField.Value = invoice.Imponibile.ToString() ?? "";
            MetodoPagamentoField.Value = invoice.MetodoPagamento ?? "";
            ScadenzaPagamentoField.Value = invoice.ScadenzaPagamento ?? "";
            DataPagamentoField.Value = invoice.DataPagamento ?? "";
            DescrizioneAggiuntivaField.Value = invoice.DescrizioneAggiuntiva ?? "";
            CentroCostoField.Value = invoice.CentroCosto ?? "";
            ContoCompetenzaField.Value = invoice.ContoCompetenza ?? "";

            lblProgress.Text = $"Fattura {currentIndex + 1} di {invoices.Count}";
            //to be ordered    
            pdfViewer.Document = PdfDocument.Load(invoice.PdfPath);

        }


        private void SaveCurrentInvoice()
        {
            Invoice invoice = invoices[currentIndex];


            invoice.Denominazione = DenominazioneField.Value;
            invoice.Data = DataField.Value;
            invoice.Numero = NumeroField.Value;
            //invoice.Totale = TotaleField.Value;      li ho commentati perché sono stringhe e non decimal, sotto correggo
            //invoice.Imponibile = ImponibileField.Value;
            invoice.MetodoPagamento = MetodoPagamentoField.Value;
            invoice.ScadenzaPagamento = ScadenzaPagamentoField.Value;
            invoice.DataPagamento = DataPagamentoField.Value;
            invoice.DescrizioneAggiuntiva = DescrizioneAggiuntivaField.Value;
            invoice.CentroCosto = CentroCostoField.Value;
            invoice.ContoCompetenza = ContoCompetenzaField.Value;

            //qui sotto portiamo le string in decimal
            if (decimal.TryParse(TotaleField.Value, out decimal Totale))
            {
                invoice.Totale = Totale;
            } else { MessageBox.Show("Il valore messo a Totale non è accettato"); }

            if (decimal.TryParse(ImponibileField.Value, out decimal Imponibile))
            {
                invoice.Imponibile = Imponibile;
            }
            else { MessageBox.Show("Il valore messo a Imponibile non è accettato"); }

        }

        private InvoiceFieldControl SetField(string Title, GroupBox Group)
        {
            InvoiceFieldControl Field;

            Field = new InvoiceFieldControl();
            Field.Title = Title;
            Field.Dock = DockStyle.Top;
            Group.Controls.Add(Field);

            Group.Controls.SetChildIndex(Field, 0);

            return Field;
        }
    }
}
