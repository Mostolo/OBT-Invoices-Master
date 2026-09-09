using OBT_Invoices_Master.Controls;
using OBT_Invoices_Master.Models;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OBT_Invoices_Master.Forms
{
    public partial class ReviewForm : Form
    {
        private List<Invoice> invoices;
        private int currentIndex = 0;

        private InvoiceFieldControl DenominazioneField;
        public bool completed { get; private set; }
        public ReviewForm(List<Invoice> invoices)
        {
            InitializeComponent();

            DenominazioneField = new InvoiceFieldControl();
            DenominazioneField.Title = "Mittente";
            DenominazioneField.Dock = DockStyle.Top;
            pnlInvoiceData.Controls.Add(DenominazioneField);

           
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


            //txtDenominazione.Text = invoice.Denominazione ?? "";
            DenominazioneField.Value = invoice.Denominazione ?? "";

            txtData.Text = invoice.Data ?? "";
            txtNumero.Text = invoice.Numero ?? "";
            txtTotale.Text = invoice.Totale?.ToString() ?? "";
            txtImponibile.Text = invoice.Imponibile?.ToString() ?? "";
            txtMetodoPagamento.Text = invoice.MetodoPagamento ?? "";
            txtScadenzaPagamento.Text = invoice.ScadenzaPagamento ?? "";
            txtDataPagamento.Text = invoice.DataPagamento ?? "";
            txtDescrizioneAggiuntiva.Text = invoice.DescrizioneAggiuntiva ?? "";
            txtCentroCosto.Text = invoice.CentroCosto ?? "";
            txtContoCompetenza.Text = invoice.ContoCompetenza ?? "";

            lblProgress.Text = $"Fattura {currentIndex + 1} di {invoices.Count}";
            //to be ordered    
            pdfViewer.Document = PdfDocument.Load(invoice.PdfPath);

        }


        private void SaveCurrentInvoice()
        {
            Invoice invoice = invoices[currentIndex];


            //invoice.Denominazione = txtDenominazione.Text;
            invoice.Denominazione = DenominazioneField.Value;

            invoice.Data = txtData.Text;
            invoice.Numero = txtNumero.Text;
            invoice.MetodoPagamento = txtMetodoPagamento.Text;
            invoice.ScadenzaPagamento = txtScadenzaPagamento.Text;
            invoice.DataPagamento = txtDataPagamento.Text;
            invoice.DescrizioneAggiuntiva = txtDescrizioneAggiuntiva.Text;
            invoice.CentroCosto = txtCentroCosto.Text;
            invoice.ContoCompetenza = txtContoCompetenza.Text;

            if (decimal.TryParse(txtTotale.Text, out decimal totale)) //out da capire
            {
                invoice.Totale = totale;
            }
            if (decimal.TryParse(txtImponibile.Text, out decimal imponibile))
            {
                invoice.Imponibile = imponibile;
            }
        }

    }
}
