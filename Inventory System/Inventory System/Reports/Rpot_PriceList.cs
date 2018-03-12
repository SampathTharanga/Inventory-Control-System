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
    public partial class Rpot_PriceList : Form
    {
        public Rpot_PriceList()
        {
            InitializeComponent();
        }

        private void Rpot_PriceList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSet_Rpot_List.tbl_Add_Items' table. You can move, or remove it, as needed.
            this.tbl_Add_ItemsTableAdapter.Fill(this.DSet_Rpot_List.tbl_Add_Items);
            this.Rpot_view_PrizList.RefreshReport();

        }

        private void Rpot_PriceList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Rpot_view_PrizList.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
