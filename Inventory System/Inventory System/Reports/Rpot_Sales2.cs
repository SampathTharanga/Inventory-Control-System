using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Inventory_System
{
    public partial class Rpot_Sales2 : Form
    {
        public Rpot_Sales2()
        {
            InitializeComponent();
        }

        private void Rpot_Sales2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSet_Rpot_Sales2.tbl_Invoice_details' table. You can move, or remove it, as needed.
            this.tbl_Invoice_detailsTableAdapter.Fill(this.DSet_Rpot_Sales2.tbl_Invoice_details, Rpot_Sales.dtpFrom.Text, Rpot_Sales.dtpTo.Text, Rpot_Sales.cb_ctogy.Text);
            this.reportViewer1.RefreshReport();
        }

        private void Rpot_Sales2_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
