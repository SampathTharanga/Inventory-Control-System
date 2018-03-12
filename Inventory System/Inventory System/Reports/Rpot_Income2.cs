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
    public partial class Rpot_Income2 : Form
    {
        public Rpot_Income2()
        {
            InitializeComponent();
        }

        private void Rpot_Income2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSet_Rpot_Incom2.tbl_Invoice' table. You can move, or remove it, as needed.
            this.tbl_InvoiceTableAdapter.Fill(this.DSet_Rpot_Incom2.tbl_Invoice, Rpot_Income.dtp_Fdate.Text, Rpot_Income.dtp_Tdate.Text, Rpot_Income.invocomplet);
            this.Rpot_viewr_Invoice2.RefreshReport();

        }

        private void Rpot_Income2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Rpot_viewr_Invoice2.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
