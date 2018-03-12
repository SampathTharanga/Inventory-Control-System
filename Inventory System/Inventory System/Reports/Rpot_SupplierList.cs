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
    public partial class Rpot_SupplierList : Form
    {
        public Rpot_SupplierList()
        {
            InitializeComponent();
        }

        private void Rpot_SupplierList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSet_Rpot_List.tbl_AddS_Supplier' table. You can move, or remove it, as needed.
            this.tbl_AddS_SupplierTableAdapter.Fill(this.DSet_Rpot_List.tbl_AddS_Supplier);
            this.Rpot_view_Supplier.RefreshReport();

        }

        private void Rpot_SupplierList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Rpot_view_Supplier.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
