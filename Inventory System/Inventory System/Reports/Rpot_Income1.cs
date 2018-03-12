using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Rpot_Income1 : Form
    {
        public Rpot_Income1()
        {
            InitializeComponent();
        }

        private void Rpot_Income1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSet_Rpot_Incom1.tbl_Invoice' table. You can move, or remove it, as needed.
            this.tbl_InvoiceTableAdapter.Fill(this.DSet_Rpot_Incom1.tbl_Invoice, Rpot_Income.dtp_Fdate.Text, Rpot_Income.dtp_Tdate.Text);
            this.Rpot_viewr_Invoice1.RefreshReport();
            

        }

        private void Rpot_Income1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Rpot_viewr_Invoice1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
