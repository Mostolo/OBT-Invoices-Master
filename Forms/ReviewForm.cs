using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OBT_Invoices_Master.Models;

namespace OBT_Invoices_Master.Forms
{
    public partial class ReviewForm : Form
    {
        private List<Invoice> invoices;
        private int currentIndex = 0;
        public ReviewForm() //remember to add the list<Invoice> Invoices
        {
            InitializeComponent();

            List<Invoice> testInvoices = new List<Invoice> //test to understand if this work, REMOVE
    {
        new Invoice
        {
            Denominazione = "Azienda Rossi S.r.l.",
            Numero = "123",
            TipoDocumento = "TD01",
            MetodoPagamento = "Bonifico",
            Data = "28/07/2026",
            ScadenzaPagamento = "28/08/2026",
            Totale = 1250.00m,
            Imponibile = 1024.59m,
            ImportoPagamento = 1250.00m,
            DataPagamento = null,
            XmlPath = @"C:\Test\fattura.xml",
            PdfPath = @"C:\Test\fattura.pdf",
            PdfName = "fattura.pdf"
        },

                new Invoice
        {
            Denominazione = "Azienda Rossi S.p.a.",
            Numero = "231",
            TipoDocumento = "TD01",
            MetodoPagamento = "Bonifico",
            Data = "28/07/2026",
            ScadenzaPagamento = "28/08/2026",
            Totale = 1250.00m,
            Imponibile = 1024.59m,
            ImportoPagamento = 1250.00m,
            DataPagamento = null,
            XmlPath = @"C:\Test\fattura.xml",
            PdfPath = @"C:\Test\fattura.pdf",
            PdfName = "fattura.pdf"
        },

                new Invoice
        {
            Denominazione = "Azienda Rossi S.q.l.",
            Numero = "312",
            TipoDocumento = "TD01",
            MetodoPagamento = "Bonifico",
            Data = "28/07/2026",
            ScadenzaPagamento = "28/08/2026",
            Totale = 1250.00m,
            Imponibile = 1024.59m,
            ImportoPagamento = 1250.00m,
            DataPagamento = null,
            XmlPath = @"C:\Test\fattura.xml",
            PdfPath = @"C:\Test\fattura.pdf",
            PdfName = "fattura.pdf"
        }


    };

            this.invoices = testInvoices;

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
                MessageBox.Show("Hai terminato tutte le fatture!", "Complimenti!");
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
