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
    public partial class Rpot_ItemList1 : Form
    {
        public Rpot_ItemList1()
        {
            InitializeComponent();
        }

        private void Rpot_ItemList1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSet_Rpot_List.tbl_Add_Items' table. You can move, or remove it, as needed.
            this.tbl_Add_ItemsTableAdapter.Fill(this.DSet_Rpot_List.tbl_Add_Items);

            this.rpot_viewr_itm1.RefreshReport();
        }

        private void Rpot_ItemList1_FormClosing(object sender, FormClosingEventArgs e)
        {
            rpot_viewr_itm1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
