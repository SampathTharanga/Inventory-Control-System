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
    public partial class Rpot_StockLeval : Form
    {
        public Rpot_StockLeval()
        {
            InitializeComponent();
        }

        private void Rpot_StockLeval_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSet_Rpot_List.tbl_Item_Quntity' table. You can move, or remove it, as needed.
            this.tbl_Item_QuntityTableAdapter.Fill(this.DSet_Rpot_List.tbl_Item_Quntity);
            this.Rpot_view_StokLeval.RefreshReport();

        }

        private void Rpot_StockLeval_FormClosing(object sender, FormClosingEventArgs e)
        {
            Rpot_view_StokLeval.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
