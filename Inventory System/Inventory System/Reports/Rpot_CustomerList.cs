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
    public partial class Rpot_CustomerList : Form
    {
        public Rpot_CustomerList()
        {
            InitializeComponent();
        }

        private void Rpot_CustomerList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSet_Rpot_List.tbl_Add_Customer' table. You can move, or remove it, as needed.
            this.tbl_Add_CustomerTableAdapter.Fill(this.DSet_Rpot_List.tbl_Add_Customer);
            this.Rpot_view_Customer.RefreshReport();

        }

        private void Rpot_CustomerList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Rpot_view_Customer.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
