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
            lblDenominazione = new Label();
            lblData = new Label();
            lblNumero = new Label();
            lblTotale = new Label();
            lblImponibile = new Label();
            lblMetodoPagamento = new Label();
            lblScadenzaPagamento = new Label();
            lblDataPagamento = new Label();
            txtDenominazione = new TextBox();
            txtData = new TextBox();
            txtNumero = new TextBox();
            txtTotale = new TextBox();
            txtImponibile = new TextBox();
            txtMetodoPagamento = new TextBox();
            txtScadenzaPagamento = new TextBox();
            txtDataPagamento = new TextBox();
            btnPrevious = new Button();
            btnNext = new Button();
            lblPdfPath = new Label();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            pdfViewer = new PdfiumViewer.PdfViewer();
            pnlInvoiceData = new Panel();
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
            lblProgress.Location = new Point(192, 11);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(77, 25);
            lblProgress.TabIndex = 0;
            lblProgress.Text = "1 di 170";
            // 
            // lblDenominazione
            // 
            lblDenominazione.AutoSize = true;
            lblDenominazione.Location = new Point(0, 38);
            lblDenominazione.Name = "lblDenominazione";
            lblDenominazione.Size = new Size(78, 25);
            lblDenominazione.TabIndex = 1;
            lblDenominazione.Text = "Mittente";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(103, 94);
            lblData.Name = "lblData";
            lblData.Size = new Size(49, 25);
            lblData.TabIndex = 2;
            lblData.Text = "Data";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(103, 156);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(77, 25);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "Numero";
            // 
            // lblTotale
            // 
            lblTotale.AutoSize = true;
            lblTotale.Location = new Point(103, 218);
            lblTotale.Name = "lblTotale";
            lblTotale.Size = new Size(58, 25);
            lblTotale.TabIndex = 4;
            lblTotale.Text = "Totale";
            // 
            // lblImponibile
            // 
            lblImponibile.AutoSize = true;
            lblImponibile.Location = new Point(103, 291);
            lblImponibile.Name = "lblImponibile";
            lblImponibile.Size = new Size(97, 25);
            lblImponibile.TabIndex = 5;
            lblImponibile.Text = "Imponibile";
            // 
            // lblMetodoPagamento
            // 
            lblMetodoPagamento.AutoSize = true;
            lblMetodoPagamento.Location = new Point(103, 379);
            lblMetodoPagamento.Name = "lblMetodoPagamento";
            lblMetodoPagamento.Size = new Size(171, 25);
            lblMetodoPagamento.TabIndex = 6;
            lblMetodoPagamento.Text = "Metodo Pagamento";
            // 
            // lblScadenzaPagamento
            // 
            lblScadenzaPagamento.AutoSize = true;
            lblScadenzaPagamento.Location = new Point(103, 475);
            lblScadenzaPagamento.Name = "lblScadenzaPagamento";
            lblScadenzaPagamento.Size = new Size(181, 25);
            lblScadenzaPagamento.TabIndex = 7;
            lblScadenzaPagamento.Text = "Scadenza Pagamento";
            // 
            // lblDataPagamento
            // 
            lblDataPagamento.AutoSize = true;
            lblDataPagamento.Location = new Point(103, 562);
            lblDataPagamento.Name = "lblDataPagamento";
            lblDataPagamento.Size = new Size(144, 25);
            lblDataPagamento.TabIndex = 8;
            lblDataPagamento.Text = "Data Pagamento";
            // 
            // txtDenominazione
            // 
            txtDenominazione.Location = new Point(0, 66);
            txtDenominazione.Name = "txtDenominazione";
            txtDenominazione.Size = new Size(150, 31);
            txtDenominazione.TabIndex = 9;
            // 
            // txtData
            // 
            txtData.Location = new Point(103, 122);
            txtData.Name = "txtData";
            txtData.Size = new Size(150, 31);
            txtData.TabIndex = 10;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(103, 184);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(150, 31);
            txtNumero.TabIndex = 11;
            // 
            // txtTotale
            // 
            txtTotale.Location = new Point(103, 246);
            txtTotale.Name = "txtTotale";
            txtTotale.Size = new Size(150, 31);
            txtTotale.TabIndex = 12;
            // 
            // txtImponibile
            // 
            txtImponibile.Location = new Point(103, 331);
            txtImponibile.Name = "txtImponibile";
            txtImponibile.Size = new Size(150, 31);
            txtImponibile.TabIndex = 13;
            // 
            // txtMetodoPagamento
            // 
            txtMetodoPagamento.Location = new Point(103, 424);
            txtMetodoPagamento.Name = "txtMetodoPagamento";
            txtMetodoPagamento.Size = new Size(150, 31);
            txtMetodoPagamento.TabIndex = 14;
            // 
            // txtScadenzaPagamento
            // 
            txtScadenzaPagamento.Location = new Point(103, 519);
            txtScadenzaPagamento.Name = "txtScadenzaPagamento";
            txtScadenzaPagamento.Size = new Size(150, 31);
            txtScadenzaPagamento.TabIndex = 15;
            // 
            // txtDataPagamento
            // 
            txtDataPagamento.Location = new Point(103, 600);
            txtDataPagamento.Name = "txtDataPagamento";
            txtDataPagamento.Size = new Size(150, 31);
            txtDataPagamento.TabIndex = 16;
            // 
            // btnPrevious
            // 
            btnPrevious.Dock = DockStyle.Left;
            btnPrevious.Location = new Point(0, 0);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(168, 46);
            btnPrevious.TabIndex = 17;
            btnPrevious.Text = "◀ Indietro";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Dock = DockStyle.Right;
            btnNext.Location = new Point(284, 0);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(171, 46);
            btnNext.TabIndex = 18;
            btnNext.Text = "Salva e continua ▶";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblPdfPath
            // 
            lblPdfPath.AutoSize = true;
            lblPdfPath.Location = new Point(143, 256);
            lblPdfPath.Name = "lblPdfPath";
            lblPdfPath.Size = new Size(173, 25);
            lblPdfPath.TabIndex = 19;
            lblPdfPath.Text = "Vedimi come un pdf";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lblPdfPath);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(pdfViewer);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnlInvoiceData);
            splitContainer1.Size = new Size(800, 556);
            splitContainer1.SplitterDistance = 455;
            splitContainer1.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPrevious);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(lblProgress);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 510);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 46);
            panel1.TabIndex = 0;
            // 
            // pdfViewer
            // 
            pdfViewer.Dock = DockStyle.Fill;
            pdfViewer.Location = new Point(0, 0);
            pdfViewer.Margin = new Padding(5, 6, 5, 6);
            pdfViewer.Name = "pdfViewer";
            pdfViewer.Size = new Size(455, 556);
            pdfViewer.TabIndex = 20;
            // 
            // pnlInvoiceData
            // 
            pnlInvoiceData.AutoScroll = true;
            pnlInvoiceData.Controls.Add(lblInvoiceDataTitle);
            pnlInvoiceData.Controls.Add(txtData);
            pnlInvoiceData.Controls.Add(txtDataPagamento);
            pnlInvoiceData.Controls.Add(lblDenominazione);
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
            pnlInvoiceData.Controls.Add(txtDenominazione);
            pnlInvoiceData.Controls.Add(lblDataPagamento);
            pnlInvoiceData.Dock = DockStyle.Fill;
            pnlInvoiceData.Location = new Point(0, 0);
            pnlInvoiceData.Name = "pnlInvoiceData";
            pnlInvoiceData.Size = new Size(341, 556);
            pnlInvoiceData.TabIndex = 0;
            // 
            // lblInvoiceDataTitle
            // 
            lblInvoiceDataTitle.AutoSize = true;
            lblInvoiceDataTitle.Dock = DockStyle.Top;
            lblInvoiceDataTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoiceDataTitle.Location = new Point(0, 0);
            lblInvoiceDataTitle.Name = "lblInvoiceDataTitle";
            lblInvoiceDataTitle.Size = new Size(211, 38);
            lblInvoiceDataTitle.TabIndex = 17;
            lblInvoiceDataTitle.Text = "DATI FATTURA";
            lblInvoiceDataTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // ReviewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 556);
            Controls.Add(splitContainer1);
            Name = "ReviewForm";
            Text = "ReviewForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
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
        private Label lblDenominazione;
        private Label lblData;
        private Label lblNumero;
        private Label lblTotale;
        private Label lblImponibile;
        private Label lblMetodoPagamento;
        private Label lblScadenzaPagamento;
        private Label lblDataPagamento;
        private TextBox txtDenominazione;
        private TextBox txtData;
        private TextBox txtNumero;
        private TextBox txtTotale;
        private TextBox txtImponibile;
        private TextBox txtMetodoPagamento;
        private TextBox txtScadenzaPagamento;
        private TextBox txtDataPagamento;
        private Button btnPrevious;
        private Button btnNext;
        private Label lblPdfPath;
        private SplitContainer splitContainer1;
        private Panel pnlInvoiceData;
        private Panel panel1;
        private PdfiumViewer.PdfViewer pdfViewer;
        private Label lblInvoiceDataTitle;
    }
}