namespace OBT_Invoices_Master
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTest = new Label();
            btnTestReview = new Button();
            SuspendLayout();
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Location = new Point(356, 38);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(44, 25);
            lblTest.TabIndex = 0;
            lblTest.Text = "WIP";
            // 
            // btnTestReview
            // 
            btnTestReview.Location = new Point(310, 81);
            btnTestReview.Name = "btnTestReview";
            btnTestReview.Size = new Size(136, 34);
            btnTestReview.TabIndex = 1;
            btnTestReview.Text = "Apri revisione";
            btnTestReview.UseVisualStyleBackColor = true;
            btnTestReview.Click += btnTestReview_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTestReview);
            Controls.Add(lblTest);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTest;
        private Button btnTestReview;
    }
}
