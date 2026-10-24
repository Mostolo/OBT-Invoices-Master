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

            SetField(DenominazioneField, "Mittente", grpAutomaticFields);
            SetField(DataField, "Data", grpAutomaticFields);
            SetField(NumeroField, "Numero", grpAutomaticFields);
            SetField(TotaleField, "Data", grpAutomaticFields);
            SetField(ImponibileField, "Data", grpAutomaticFields);
            SetField(MetodoPagamentoField, "Data", grpAutomaticFields);
            SetField(ScadenzaPagamentoField, "Data", grpAutomaticFields);
            SetField(DataPagamentoField, "Data", grpAutomaticFields);
            SetField(DescrizioneAggiuntivaField, "Data", grpUserFields);
            SetField(CentroCostoField, "Data", grpUserFields);
            SetField(ContoCompetenzaField, "Data", grpUserFields);

            //DenominazioneField = new InvoiceFieldControl();
            //DenominazioneField.Title = "Mittente";
            //DenominazioneField.Dock = DockStyle.Top;
            //grpAutomaticFields.Controls.Add(DenominazioneField);

            //DataField = new InvoiceFieldControl();
            //DataField.Title = "Data";
            //DataField.Dock = DockStyle.Top;
            //grpAutomaticFields.Controls.Add(DataField);


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
            DataPagamentoField.Value = invoice.DataPagamento ?? "";
            DescrizioneAggiuntivaField.Value = invoice.DescrizioneAggiuntiva ?? "";
            CentroCostoField.Value = invoice.CentroCosto ?? "";
            ContoCompetenzaField.Value = invoice.ContoCompetenza ?? "";


            //txtDenominazione.Text = invoice.Denominazione ?? "";
            //txtData.Text = invoice.Data ?? "";
            //txtNumero.Text = invoice.Numero ?? "";
            //txtTotale.Text = invoice.Totale?.ToString() ?? "";
            //txtImponibile.Text = invoice.Imponibile?.ToString() ?? "";
            //txtMetodoPagamento.Text = invoice.MetodoPagamento ?? "";
            //txtScadenzaPagamento.Text = invoice.ScadenzaPagamento ?? "";
            //txtDataPagamento.Text = invoice.DataPagamento ?? "";
            //txtDescrizioneAggiuntiva.Text = invoice.DescrizioneAggiuntiva ?? "";
            //txtCentroCosto.Text = invoice.CentroCosto ?? "";
            //txtContoCompetenza.Text = invoice.ContoCompetenza ?? "";

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
            invoice.MetodoPagamento = MetodoPagamentoField.Value;
            invoice.ScadenzaPagamento = ScadenzaPagamentoField.Value;
            invoice.DataPagamento = DataPagamentoField.Value;
            invoice.DescrizioneAggiuntiva = DescrizioneAggiuntivaField.Value;
            invoice.CentroCosto = CentroCostoField.Value;
            invoice.ContoCompetenza = ContoCompetenzaField.Value;

            //invoice.Denominazione = txtDenominazione.Text;
            //invoice.Data = txtData.Text;
            //invoice.Numero = txtNumero.Text;
            //invoice.MetodoPagamento = txtMetodoPagamento.Text;
            //invoice.ScadenzaPagamento = txtScadenzaPagamento.Text;
            //invoice.DataPagamento = txtDataPagamento.Text;
            //invoice.DescrizioneAggiuntiva = txtDescrizioneAggiuntiva.Text;
            //invoice.CentroCosto = txtCentroCosto.Text;
            //invoice.ContoCompetenza = txtContoCompetenza.Text;

            //if (decimal.TryParse(Totale.Text, out decimal totale)) //out da capire
            //{
            //    invoice.Totale = totale;
            //}
            //if (decimal.TryParse(txtImponibile.Text, out decimal imponibile))
            //{
            //    invoice.Imponibile = imponibile;
            //}
        }

        private void SetField(InvoiceFieldControl Field, string Title, GroupBox Group)
        {
            Field = new InvoiceFieldControl();
            Field.Title = Title;
            Field.Dock = DockStyle.Top;
            Group.Controls.Add(Field);
        }
    }
}
