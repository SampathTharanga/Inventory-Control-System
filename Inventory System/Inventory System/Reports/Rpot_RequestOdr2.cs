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
    public partial class Rpot_RequestOdr2 : Form
    {
        public Rpot_RequestOdr2()
        {
            InitializeComponent();
        }

        private void Rpot_RequestOdr2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSet_Rpot_RequestOdr2.tbl_Request_Order' table. You can move, or remove it, as needed.
            this.tbl_Request_OrderTableAdapter.Fill(this.DSet_Rpot_RequestOdr2.tbl_Request_Order, Rpot_RequestOrder.frmdte_Rqstodr.Text, Rpot_RequestOrder.todte_Rqstodr.Text, Rpot_RequestOrder.cb_odr.Text);
            this.Rpot_vewer_reqstodr2.RefreshReport();
        }

        private void Rpot_RequestOdr2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Rpot_vewer_reqstodr2.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
