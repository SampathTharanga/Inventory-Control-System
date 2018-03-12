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
    public partial class Rpot_CusOrder : Form
    {
        public Rpot_CusOrder()
        {
            InitializeComponent();
        }

        private void Rpot_CusOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSet_Rpot_List.tbl_Customer_Order' table. You can move, or remove it, as needed.
            this.tbl_Customer_OrderTableAdapter.Fill(this.DSet_Rpot_List.tbl_Customer_Order,dateTimePicker_From.Text,dateTimePicker_to.Text);
            this.Rpot_cusodr.RefreshReport();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            this.tbl_Customer_OrderTableAdapter.Fill(this.DSet_Rpot_List.tbl_Customer_Order, dateTimePicker_From.Text, dateTimePicker_to.Text);
            this.Rpot_cusodr.RefreshReport();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Report_main.pn_Rpot.Controls.Clear();
            Rpot_CusOrder rcuso = new Rpot_CusOrder();
            rcuso.TopLevel = false;
            rcuso.Visible = true;
            Report_main.pn_Rpot.Controls.Add(rcuso);
        }

        private void Rpot_CusOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Rpot_cusodr.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
