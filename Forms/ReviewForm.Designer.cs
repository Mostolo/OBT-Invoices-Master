namespace OBT_Invoices_Master.Forms
{
    partial class ReviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblProgress = new Label();
            lblData = new Label();
            lblNumero = new Label();
            lblTotale = new Label();
            lblImponibile = new Label();
            lblMetodoPagamento = new Label();
            lblScadenzaPagamento = new Label();
            lblDataPagamento = new Label();
            txtData = new TextBox();
            txtNumero = new TextBox();
            txtTotale = new TextBox();
            txtImponibile = new TextBox();
            txtMetodoPagamento = new TextBox();
            txtScadenzaPagamento = new TextBox();
            txtDataPagamento = new TextBox();
            btnPrevious = new Button();
            btnNext = new Button();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            pdfViewer = new PdfiumViewer.PdfViewer();
            pnlInvoiceData = new Panel();
            txtCentroCosto = new TextBox();
            txtContoCompetenza = new TextBox();
            txtDescrizioneAggiuntiva = new TextBox();
            lblContoCompetenza = new Label();
            lblCentroCosto = new Label();
            lblDescrizioneAggiuntiva = new Label();
            lblInvoiceDataTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            pnlInvoiceData.SuspendLayout();
            SuspendLayout();
            // 
            // lblProgress
            // 
            lblProgress.Anchor = AnchorStyles.None;
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(331, 11);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(77, 25);
            lblProgress.TabIndex = 0;
            lblProgress.Text = "1 di 170";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(4, 100);
            lblData.Name = "lblData";
            lblData.Size = new Size(49, 25);
            lblData.TabIndex = 2;
            lblData.Text = "Data";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(4, 162);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(77, 25);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "Numero";
            // 
            // lblTotale
            // 
            lblTotale.AutoSize = true;
            lblTotale.Location = new Point(4, 224);
            lblTotale.Name = "lblTotale";
            lblTotale.Size = new Size(58, 25);
            lblTotale.TabIndex = 4;
            lblTotale.Text = "Totale";
            // 
            // lblImponibile
            // 
            lblImponibile.AutoSize = true;
            lblImponibile.Location = new Point(4, 286);
            lblImponibile.Name = "lblImponibile";
            lblImponibile.Size = new Size(97, 25);
            lblImponibile.TabIndex = 5;
            lblImponibile.Text = "Imponibile";
            // 
            // lblMetodoPagamento
            // 
            lblMetodoPagamento.AutoSize = true;
            lblMetodoPagamento.Location = new Point(4, 348);
            lblMetodoPagamento.Name = "lblMetodoPagamento";
            lblMetodoPagamento.Size = new Size(171, 25);
            lblMetodoPagamento.TabIndex = 6;
            lblMetodoPagamento.Text = "Metodo Pagamento";
            // 
            // lblScadenzaPagamento
            // 
            lblScadenzaPagamento.AutoSize = true;
            lblScadenzaPagamento.Location = new Point(4, 410);
            lblScadenzaPagamento.Name = "lblScadenzaPagamento";
            lblScadenzaPagamento.Size = new Size(181, 25);
            lblScadenzaPagamento.TabIndex = 7;
            lblScadenzaPagamento.Text = "Scadenza Pagamento";
            // 
            // lblDataPagamento
            // 
            lblDataPagamento.AutoSize = true;
            lblDataPagamento.Location = new Point(4, 472);
            lblDataPagamento.Name = "lblDataPagamento";
            lblDataPagamento.Size = new Size(144, 25);
            lblDataPagamento.TabIndex = 8;
            lblDataPagamento.Text = "Data Pagamento";
            // 
            // txtData
            // 
            txtData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtData.Location = new Point(4, 128);
            txtData.Name = "txtData";
            txtData.Size = new Size(365, 31);
            txtData.TabIndex = 10;
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNumero.Location = new Point(4, 190);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(365, 31);
            txtNumero.TabIndex = 11;
            // 
            // txtTotale
            // 
            txtTotale.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotale.Location = new Point(4, 252);
            txtTotale.Name = "txtTotale";
            txtTotale.Size = new Size(365, 31);
            txtTotale.TabIndex = 12;
            // 
            // txtImponibile
            // 
            txtImponibile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtImponibile.Location = new Point(4, 314);
            txtImponibile.Name = "txtImponibile";
            txtImponibile.Size = new Size(365, 31);
            txtImponibile.TabIndex = 13;
            // 
            // txtMetodoPagamento
            // 
            txtMetodoPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMetodoPagamento.Location = new Point(4, 376);
            txtMetodoPagamento.Name = "txtMetodoPagamento";
            txtMetodoPagamento.Size = new Size(365, 31);
            txtMetodoPagamento.TabIndex = 14;
            // 
            // txtScadenzaPagamento
            // 
            txtScadenzaPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtScadenzaPagamento.Location = new Point(4, 438);
            txtScadenzaPagamento.Name = "txtScadenzaPagamento";
            txtScadenzaPagamento.Size = new Size(365, 31);
            txtScadenzaPagamento.TabIndex = 15;
            // 
            // txtDataPagamento
            // 
            txtDataPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDataPagamento.Location = new Point(4, 500);
            txtDataPagamento.Name = "txtDataPagamento";
            txtDataPagamento.Size = new Size(365, 31);
            txtDataPagamento.TabIndex = 16;
            // 
            // btnPrevious
            // 
            btnPrevious.Dock = DockStyle.Left;
            btnPrevious.Location = new Point(0, 0);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(168, 46);
            btnPrevious.TabIndex = 20;
            btnPrevious.Text = "◀ Indietro";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Dock = DockStyle.Right;
            btnNext.Location = new Point(561, 0);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(171, 46);
            btnNext.TabIndex = 21;
            btnNext.Text = "Salva e continua ▶";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(pdfViewer);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnlInvoiceData);
            splitContainer1.Size = new Size(1114, 733);
            splitContainer1.SplitterDistance = 732;
            splitContainer1.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPrevious);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(lblProgress);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 687);
            panel1.Name = "panel1";
            panel1.Size = new Size(732, 46);
            panel1.TabIndex = 0;
            // 
            // pdfViewer
            // 
            pdfViewer.Dock = DockStyle.Fill;
            pdfViewer.Location = new Point(0, 0);
            pdfViewer.Margin = new Padding(5, 6, 5, 6);
            pdfViewer.Name = "pdfViewer";
            pdfViewer.Size = new Size(732, 733);
            pdfViewer.TabIndex = 20;
            // 
            // pnlInvoiceData
            // 
            pnlInvoiceData.AutoScroll = true;
            pnlInvoiceData.Controls.Add(txtCentroCosto);
            pnlInvoiceData.Controls.Add(txtContoCompetenza);
            pnlInvoiceData.Controls.Add(txtDescrizioneAggiuntiva);
            pnlInvoiceData.Controls.Add(lblContoCompetenza);
            pnlInvoiceData.Controls.Add(lblCentroCosto);
            pnlInvoiceData.Controls.Add(lblDescrizioneAggiuntiva);
            pnlInvoiceData.Controls.Add(lblInvoiceDataTitle);
            pnlInvoiceData.Controls.Add(txtData);
            pnlInvoiceData.Controls.Add(txtDataPagamento);
            pnlInvoiceData.Controls.Add(txtScadenzaPagamento);
            pnlInvoiceData.Controls.Add(lblData);
            pnlInvoiceData.Controls.Add(txtMetodoPagamento);
            pnlInvoiceData.Controls.Add(lblNumero);
            pnlInvoiceData.Controls.Add(txtImponibile);
            pnlInvoiceData.Controls.Add(lblTotale);
            pnlInvoiceData.Controls.Add(txtTotale);
            pnlInvoiceData.Controls.Add(lblImponibile);
            pnlInvoiceData.Controls.Add(txtNumero);
            pnlInvoiceData.Controls.Add(lblMetodoPagamento);
            pnlInvoiceData.Controls.Add(lblScadenzaPagamento);
            pnlInvoiceData.Controls.Add(lblDataPagamento);
            pnlInvoiceData.Dock = DockStyle.Fill;
            pnlInvoiceData.Location = new Point(0, 0);
            pnlInvoiceData.Name = "pnlInvoiceData";
            pnlInvoiceData.Size = new Size(378, 733);
            pnlInvoiceData.TabIndex = 0;
            // 
            // txtCentroCosto
            // 
            txtCentroCosto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCentroCosto.Location = new Point(4, 624);
            txtCentroCosto.Name = "txtCentroCosto";
            txtCentroCosto.Size = new Size(365, 31);
            txtCentroCosto.TabIndex = 18;
            // 
            // txtContoCompetenza
            // 
            txtContoCompetenza.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContoCompetenza.Location = new Point(4, 686);
            txtContoCompetenza.Name = "txtContoCompetenza";
            txtContoCompetenza.Size = new Size(365, 31);
            txtContoCompetenza.TabIndex = 19;
            // 
            // txtDescrizioneAggiuntiva
            // 
            txtDescrizioneAggiuntiva.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescrizioneAggiuntiva.Location = new Point(4, 562);
            txtDescrizioneAggiuntiva.Name = "txtDescrizioneAggiuntiva";
            txtDescrizioneAggiuntiva.Size = new Size(365, 31);
            txtDescrizioneAggiuntiva.TabIndex = 17;
            // 
            // lblContoCompetenza
            // 
            lblContoCompetenza.AutoSize = true;
            lblContoCompetenza.Location = new Point(4, 658);
            lblContoCompetenza.Name = "lblContoCompetenza";
            lblContoCompetenza.Size = new Size(183, 25);
            lblContoCompetenza.TabIndex = 0;
            lblContoCompetenza.Text = "Conto di competenza";
            // 
            // lblCentroCosto
            // 
            lblCentroCosto.AutoSize = true;
            lblCentroCosto.Location = new Point(4, 596);
            lblCentroCosto.Name = "lblCentroCosto";
            lblCentroCosto.Size = new Size(134, 25);
            lblCentroCosto.TabIndex = 0;
            lblCentroCosto.Text = "Centro di costo";
            // 
            // lblDescrizioneAggiuntiva
            // 
            lblDescrizioneAggiuntiva.AutoSize = true;
            lblDescrizioneAggiuntiva.Location = new Point(4, 534);
            lblDescrizioneAggiuntiva.Name = "lblDescrizioneAggiuntiva";
            lblDescrizioneAggiuntiva.Size = new Size(193, 25);
            lblDescrizioneAggiuntiva.TabIndex = 0;
            lblDescrizioneAggiuntiva.Text = "Descrizione Aggiuntiva";
            // 
            // lblInvoiceDataTitle
            // 
            lblInvoiceDataTitle.AutoSize = true;
            lblInvoiceDataTitle.Dock = DockStyle.Top;
            lblInvoiceDataTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoiceDataTitle.Location = new Point(0, 0);
            lblInvoiceDataTitle.Name = "lblInvoiceDataTitle";
            lblInvoiceDataTitle.Size = new Size(211, 38);
            lblInvoiceDataTitle.TabIndex = 0;
            lblInvoiceDataTitle.Text = "DATI FATTURA";
            lblInvoiceDataTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // ReviewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 733);
            Controls.Add(splitContainer1);
            Name = "ReviewForm";
            Text = "ReviewForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlInvoiceData.ResumeLayout(false);
            pnlInvoiceData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblProgress;
        private Label lblData;
        private Label lblNumero;
        private Label lblTotale;
        private Label lblImponibile;
        private Label lblMetodoPagamento;
        private Label lblScadenzaPagamento;
        private Label lblDataPagamento;
        private TextBox txtData;
        private TextBox txtNumero;
        private TextBox txtTotale;
        private TextBox txtImponibile;
        private TextBox txtMetodoPagamento;
        private TextBox txtScadenzaPagamento;
        private TextBox txtDataPagamento;
        private Button btnPrevious;
        private Button btnNext;
        private SplitContainer splitContainer1;
        private Panel pnlInvoiceData;
        private Panel panel1;
        private PdfiumViewer.PdfViewer pdfViewer;
        private Label lblInvoiceDataTitle;
        private TextBox txtCentroCosto;
        private TextBox txtContoCompetenza;
        private TextBox txtDescrizioneAggiuntiva;
        private Label lblContoCompetenza;
        private Label lblCentroCosto;
        private Label lblDescrizioneAggiuntiva;
    }
}