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
    public partial class Rpot_ReceiveStock2 : Form
    {
        public Rpot_ReceiveStock2()
        {
            InitializeComponent();
        }

        private void Rpot_ReceiveStock2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSet_Rpot_ReceiveStok2.tbl_Recive_Stock' table. You can move, or remove it, as needed.
            this.tbl_Recive_StockTableAdapter.Fill(this.DSet_Rpot_ReceiveStok2.tbl_Recive_Stock,Rpot_ReceivedStock.cb_supp.Text,Rpot_ReceivedStock.dtpFrom.Value,Rpot_ReceivedStock.dtpTo.Value);

            this.reportViewer1.RefreshReport();
        }

        private void Rpot_ReceiveStock2_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
