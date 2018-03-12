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
    public partial class Rpot_WarrantyItem : Form
    {
        public Rpot_WarrantyItem()
        {
            InitializeComponent();
        }

        private void Rpot_WarrantyItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Dset_Rpot_warrntyI.tbl_warrnty_found_Item' table. You can move, or remove it, as needed.
            this.tbl_warrnty_found_ItemTableAdapter.Fill(this.Dset_Rpot_warrntyI.tbl_warrnty_found_Item);
            this.Rpot_view_Warrnty.RefreshReport();

        }

        private void Rpot_WarrantyItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Rpot_view_Warrnty.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
