using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace OBT_Invoices_Master.Controls
{
    public partial class InvoiceFieldControl : UserControl
    {

        private Label lblTitle;
        private TextBox txtValue;

        public InvoiceFieldControl()
        {
            InitializeComponent();

            lblTitle = new Label();
            txtValue = new TextBox();

            SetupControl();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.Name = "invoiceFieldControl";
            this.Size = new Size(300, 60);

            this.ResumeLayout(false);
        }

        private void SetupControl()
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Top;

            txtValue.Dock = DockStyle.Top;

            this.Controls.Add(txtValue);
            this.Controls.Add(lblTitle);
        }

    }
}
