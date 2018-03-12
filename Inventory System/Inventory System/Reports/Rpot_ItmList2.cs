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
    public partial class Rpot_ItmList2 : Form
    {
        public Rpot_ItmList2()
        {
            InitializeComponent();
        }

        private void Rpot_ItmList2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSet_Rpot_Itmlist2.tbl_Add_Items' table. You can move, or remove it, as needed.
            this.tbl_Add_ItemsTableAdapter.Fill(this.DSet_Rpot_Itmlist2.tbl_Add_Items,Rpot_ItemList.cb_ctgy.Text);
            this.rpot_viewr_itm2.RefreshReport();

        }

        private void Rpot_ItmList2_FormClosing(object sender, FormClosingEventArgs e)
        {
            rpot_viewr_itm2.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
