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
    public partial class Rpot_ItmList3 : Form
    {
        public Rpot_ItmList3()
        {
            InitializeComponent();
        }

        private void Rpot_ItmList3_FormClosing(object sender, FormClosingEventArgs e)
        {
            rpot_viewr_itm3.LocalReport.ReleaseSandboxAppDomain();
        }

        private void Rpot_ItmList3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSet_Rpot_ItmList3.tbl_Add_Items' table. You can move, or remove it, as needed.
            this.tbl_Add_ItemsTableAdapter.Fill(this.DSet_Rpot_ItmList3.tbl_Add_Items, Rpot_ItemList.cb_ctgy.Text, Rpot_ItemList.cb_Subctgy.Text);
            this.rpot_viewr_itm3.RefreshReport();

        }
    }
}
