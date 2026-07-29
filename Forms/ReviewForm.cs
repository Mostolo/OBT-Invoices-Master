using OBT_Invoices_Master.Models;
using PdfiumViewer; //for now
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
        public bool completed { get; private set; }
        public ReviewForm(List<Invoice> invoices)
        {
            InitializeComponent();
            
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

            txtDenominazione.Text = invoice.Denominazione ?? "";
            txtData.Text = invoice.Data ?? "";
            txtNumero.Text = invoice.Numero ?? "";
            txtTotale.Text = invoice.Totale?.ToString() ?? "";
            txtImponibile.Text = invoice.Imponibile?.ToString() ?? "";
            txtMetodoPagamento.Text = invoice.MetodoPagamento ?? "";
            txtScadenzaPagamento.Text = invoice.ScadenzaPagamento ?? "";
            txtDataPagamento.Text = invoice.DataPagamento ?? "";
            lblPdfPath.Text = $"PDF: {invoice.PdfPath ?? "Nessun PDF"}";
            lblProgress.Text = $"Fattura {currentIndex + 1} di {invoices.Count}";
            //to be ordered    
            pdfViewer.Document = PdfDocument.Load(invoice.PdfPath);

        }


        private void SaveCurrentInvoice()
        {
            Invoice invoice = invoices[currentIndex];

            invoice.Denominazione = txtDenominazione.Text;
            invoice.Data = txtData.Text;
            invoice.Numero = txtNumero.Text;
            invoice.MetodoPagamento = txtMetodoPagamento.Text;
            invoice.ScadenzaPagamento = txtScadenzaPagamento.Text;
            invoice.DataPagamento = txtDataPagamento.Text;
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
