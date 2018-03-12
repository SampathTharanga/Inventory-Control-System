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
    public partial class Rpot_Sales1 : Form
    {
        public Rpot_Sales1()
        {
            InitializeComponent();
        }

        private void Rpot_Sales1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSet_Rpot_Sales1.tbl_Invoice_details' table. You can move, or remove it, as needed.
            this.tbl_Invoice_detailsTableAdapter.Fill(this.DSet_Rpot_Sales1.tbl_Invoice_details, Rpot_Sales.dtpFrom.Text, Rpot_Sales.dtpTo.Text);

            this.reportViewer1.RefreshReport();
        }

        private void Rpot_Sales1_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
