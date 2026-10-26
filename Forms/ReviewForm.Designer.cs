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
            progressBar = new ProgressBar();
            pdfViewer = new PdfiumViewer.PdfViewer();
            pnlInvoiceData = new Panel();
            grpUserFields = new GroupBox();
            grpAutomaticFields = new GroupBox();
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
            lblProgress.Location = new Point(327, 0);
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
            panel1.Controls.Add(progressBar);
            panel1.Controls.Add(btnPrevious);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(lblProgress);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 687);
            panel1.Name = "panel1";
            panel1.Size = new Size(732, 46);
            panel1.TabIndex = 0;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(174, 25);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(381, 18);
            progressBar.Step = 1;
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 22;
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
            grpUserFields.Location = new Point(11, 597);
            grpUserFields.Name = "grpUserFields";
            grpUserFields.Size = new Size(338, 220);
            grpUserFields.TabIndex = 20;
            grpUserFields.TabStop = false;
            grpUserFields.Text = "Dati da completare";
            // 
            // grpAutomaticFields
            // 
            grpAutomaticFields.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpAutomaticFields.Location = new Point(11, 41);
            grpAutomaticFields.Name = "grpAutomaticFields";
            grpAutomaticFields.Size = new Size(338, 550);
            grpAutomaticFields.TabIndex = 0;
            grpAutomaticFields.TabStop = false;
            grpAutomaticFields.Text = "Dati estratti automaticamente";
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
        private Button btnPrevious;
        private Button btnNext;
        private SplitContainer splitContainer1;
        private Panel pnlInvoiceData;
        private Panel panel1;
        private PdfiumViewer.PdfViewer pdfViewer;
        private Label lblInvoiceDataTitle;
        private GroupBox grpAutomaticFields;
        private GroupBox grpUserFields;
        private ProgressBar progressBar;
    }
}