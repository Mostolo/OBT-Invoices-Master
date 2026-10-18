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
            btnPrevious = new Button();
            btnNext = new Button();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            pdfViewer = new PdfiumViewer.PdfViewer();
            pnlInvoiceData = new Panel();
            grpUserFields = new GroupBox();
            txtContoCompetenza = new TextBox();
            lblContoCompetenza = new Label();
            txtCentroCosto = new TextBox();
            lblCentroCosto = new Label();
            txtDescrizioneAggiuntiva = new TextBox();
            lblDescrizioneAggiuntiva = new Label();
            grpAutomaticFields = new GroupBox();
            txtDataPagamento = new TextBox();
            lblDataPagamento = new Label();
            txtScadenzaPagamento = new TextBox();
            lblScadenzaPagamento = new Label();
            txtMetodoPagamento = new TextBox();
            lblMetodoPagamento = new Label();
            txtImponibile = new TextBox();
            lblImponibile = new Label();
            lblTotale = new Label();
            txtTotale = new TextBox();
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtData = new TextBox();
            lblData = new Label();
            lblInvoiceDataTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            pnlInvoiceData.SuspendLayout();
            grpUserFields.SuspendLayout();
            grpAutomaticFields.SuspendLayout();
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
            pnlInvoiceData.Controls.Add(grpUserFields);
            pnlInvoiceData.Controls.Add(grpAutomaticFields);
            pnlInvoiceData.Controls.Add(lblInvoiceDataTitle);
            pnlInvoiceData.Dock = DockStyle.Fill;
            pnlInvoiceData.Location = new Point(0, 0);
            pnlInvoiceData.Name = "pnlInvoiceData";
            pnlInvoiceData.Size = new Size(378, 733);
            pnlInvoiceData.TabIndex = 0;
            // 
            // grpUserFields
            // 
            grpUserFields.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpUserFields.Controls.Add(txtContoCompetenza);
            grpUserFields.Controls.Add(lblContoCompetenza);
            grpUserFields.Controls.Add(txtCentroCosto);
            grpUserFields.Controls.Add(lblCentroCosto);
            grpUserFields.Controls.Add(txtDescrizioneAggiuntiva);
            grpUserFields.Controls.Add(lblDescrizioneAggiuntiva);
            grpUserFields.Location = new Point(11, 165);
            grpUserFields.Name = "grpUserFields";
            grpUserFields.Size = new Size(364, 150);
            grpUserFields.TabIndex = 20;
            grpUserFields.TabStop = false;
            grpUserFields.Text = "Dati da completare";
            // 
            // txtContoCompetenza
            // 
            txtContoCompetenza.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContoCompetenza.Location = new Point(0, 28);
            txtContoCompetenza.Name = "txtContoCompetenza";
            txtContoCompetenza.Size = new Size(398, 31);
            txtContoCompetenza.TabIndex = 23;
            // 
            // lblContoCompetenza
            // 
            lblContoCompetenza.AutoSize = true;
            lblContoCompetenza.Location = new Point(0, 0);
            lblContoCompetenza.Name = "lblContoCompetenza";
            lblContoCompetenza.Size = new Size(183, 25);
            lblContoCompetenza.TabIndex = 22;
            lblContoCompetenza.Text = "Conto di competenza";
            // 
            // txtCentroCosto
            // 
            txtCentroCosto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCentroCosto.Location = new Point(0, 28);
            txtCentroCosto.Name = "txtCentroCosto";
            txtCentroCosto.Size = new Size(398, 31);
            txtCentroCosto.TabIndex = 21;
            // 
            // lblCentroCosto
            // 
            lblCentroCosto.AutoSize = true;
            lblCentroCosto.Location = new Point(0, 0);
            lblCentroCosto.Name = "lblCentroCosto";
            lblCentroCosto.Size = new Size(134, 25);
            lblCentroCosto.TabIndex = 20;
            lblCentroCosto.Text = "Centro di costo";
            // 
            // txtDescrizioneAggiuntiva
            // 
            txtDescrizioneAggiuntiva.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescrizioneAggiuntiva.Location = new Point(-17, 74);
            txtDescrizioneAggiuntiva.Name = "txtDescrizioneAggiuntiva";
            txtDescrizioneAggiuntiva.Size = new Size(398, 31);
            txtDescrizioneAggiuntiva.TabIndex = 19;
            // 
            // lblDescrizioneAggiuntiva
            // 
            lblDescrizioneAggiuntiva.AutoSize = true;
            lblDescrizioneAggiuntiva.Location = new Point(-17, 46);
            lblDescrizioneAggiuntiva.Name = "lblDescrizioneAggiuntiva";
            lblDescrizioneAggiuntiva.Size = new Size(193, 25);
            lblDescrizioneAggiuntiva.TabIndex = 18;
            lblDescrizioneAggiuntiva.Text = "Descrizione Aggiuntiva";
            // 
            // grpAutomaticFields
            // 
            grpAutomaticFields.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpAutomaticFields.Controls.Add(txtDataPagamento);
            grpAutomaticFields.Controls.Add(lblDataPagamento);
            grpAutomaticFields.Controls.Add(txtScadenzaPagamento);
            grpAutomaticFields.Controls.Add(lblScadenzaPagamento);
            grpAutomaticFields.Controls.Add(txtMetodoPagamento);
            grpAutomaticFields.Controls.Add(lblMetodoPagamento);
            grpAutomaticFields.Controls.Add(txtImponibile);
            grpAutomaticFields.Controls.Add(lblImponibile);
            grpAutomaticFields.Controls.Add(lblTotale);
            grpAutomaticFields.Controls.Add(txtTotale);
            grpAutomaticFields.Controls.Add(lblNumero);
            grpAutomaticFields.Controls.Add(txtNumero);
            grpAutomaticFields.Controls.Add(txtData);
            grpAutomaticFields.Controls.Add(lblData);
            grpAutomaticFields.Location = new Point(11, 41);
            grpAutomaticFields.Name = "grpAutomaticFields";
            grpAutomaticFields.Size = new Size(364, 118);
            grpAutomaticFields.TabIndex = 0;
            grpAutomaticFields.TabStop = false;
            grpAutomaticFields.Text = "Dati estratti automaticamente";
            // 
            // txtDataPagamento
            // 
            txtDataPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDataPagamento.Location = new Point(0, 28);
            txtDataPagamento.Name = "txtDataPagamento";
            txtDataPagamento.Size = new Size(562, 31);
            txtDataPagamento.TabIndex = 24;
            // 
            // lblDataPagamento
            // 
            lblDataPagamento.AutoSize = true;
            lblDataPagamento.Location = new Point(0, 0);
            lblDataPagamento.Name = "lblDataPagamento";
            lblDataPagamento.Size = new Size(144, 25);
            lblDataPagamento.TabIndex = 23;
            lblDataPagamento.Text = "Data Pagamento";
            // 
            // txtScadenzaPagamento
            // 
            txtScadenzaPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtScadenzaPagamento.Location = new Point(0, 28);
            txtScadenzaPagamento.Name = "txtScadenzaPagamento";
            txtScadenzaPagamento.Size = new Size(562, 31);
            txtScadenzaPagamento.TabIndex = 22;
            // 
            // lblScadenzaPagamento
            // 
            lblScadenzaPagamento.AutoSize = true;
            lblScadenzaPagamento.Location = new Point(0, 0);
            lblScadenzaPagamento.Name = "lblScadenzaPagamento";
            lblScadenzaPagamento.Size = new Size(181, 25);
            lblScadenzaPagamento.TabIndex = 21;
            lblScadenzaPagamento.Text = "Scadenza Pagamento";
            // 
            // txtMetodoPagamento
            // 
            txtMetodoPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMetodoPagamento.Location = new Point(0, 28);
            txtMetodoPagamento.Name = "txtMetodoPagamento";
            txtMetodoPagamento.Size = new Size(562, 31);
            txtMetodoPagamento.TabIndex = 20;
            // 
            // lblMetodoPagamento
            // 
            lblMetodoPagamento.AutoSize = true;
            lblMetodoPagamento.Location = new Point(0, 0);
            lblMetodoPagamento.Name = "lblMetodoPagamento";
            lblMetodoPagamento.Size = new Size(171, 25);
            lblMetodoPagamento.TabIndex = 19;
            lblMetodoPagamento.Text = "Metodo Pagamento";
            // 
            // txtImponibile
            // 
            txtImponibile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtImponibile.Location = new Point(0, 28);
            txtImponibile.Name = "txtImponibile";
            txtImponibile.Size = new Size(562, 31);
            txtImponibile.TabIndex = 18;
            // 
            // lblImponibile
            // 
            lblImponibile.AutoSize = true;
            lblImponibile.Location = new Point(0, 0);
            lblImponibile.Name = "lblImponibile";
            lblImponibile.Size = new Size(97, 25);
            lblImponibile.TabIndex = 17;
            lblImponibile.Text = "Imponibile";
            // 
            // lblTotale
            // 
            lblTotale.AutoSize = true;
            lblTotale.Location = new Point(-99, 216);
            lblTotale.Name = "lblTotale";
            lblTotale.Size = new Size(58, 25);
            lblTotale.TabIndex = 15;
            lblTotale.Text = "Totale";
            // 
            // txtTotale
            // 
            txtTotale.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotale.Location = new Point(-99, 244);
            txtTotale.Name = "txtTotale";
            txtTotale.Size = new Size(562, 31);
            txtTotale.TabIndex = 16;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(-99, 216);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(77, 25);
            lblNumero.TabIndex = 13;
            lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNumero.Location = new Point(-99, 244);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(562, 31);
            txtNumero.TabIndex = 14;
            // 
            // txtData
            // 
            txtData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtData.Location = new Point(-99, 49);
            txtData.Name = "txtData";
            txtData.Size = new Size(562, 31);
            txtData.TabIndex = 12;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(-99, 21);
            lblData.Name = "lblData";
            lblData.Size = new Size(49, 25);
            lblData.TabIndex = 11;
            lblData.Text = "Data";
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
            grpUserFields.ResumeLayout(false);
            grpUserFields.PerformLayout();
            grpAutomaticFields.ResumeLayout(false);
            grpAutomaticFields.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblProgress;
        private Button btnPrevious;
        private Button btnNext;
        private SplitContainer splitContainer1;
        private Panel pnlInvoiceData;
        private Panel panel1;
        private PdfiumViewer.PdfViewer pdfViewer;
        private Label lblInvoiceDataTitle;
        private GroupBox grpAutomaticFields;
        private GroupBox grpUserFields;
        private TextBox txtImponibile;
        private Label lblImponibile;
        private Label lblTotale;
        private TextBox txtTotale;
        private Label lblNumero;
        private TextBox txtNumero;
        private TextBox txtData;
        private Label lblData;
        private TextBox txtDataPagamento;
        private Label lblDataPagamento;
        private TextBox txtScadenzaPagamento;
        private Label lblScadenzaPagamento;
        private TextBox txtMetodoPagamento;
        private Label lblMetodoPagamento;
        private TextBox txtContoCompetenza;
        private Label lblContoCompetenza;
        private TextBox txtCentroCosto;
        private Label lblCentroCosto;
        private TextBox txtDescrizioneAggiuntiva;
        private Label lblDescrizioneAggiuntiva;
    }
}