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
    public partial class Rpot_ReturnItem : Form
    {
        public Rpot_ReturnItem()
        {
            InitializeComponent();
        }

        private void Rpot_ReturnItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Dset_Rpot_ReturnI.tbl_Return_items' table. You can move, or remove it, as needed.
            this.tbl_Return_itemsTableAdapter.Fill(this.Dset_Rpot_ReturnI.tbl_Return_items);
            this.Rpot_Returnitm.RefreshReport();

        }

        private void Rpot_ReturnItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Rpot_Returnitm.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
