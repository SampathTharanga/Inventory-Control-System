using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_System
{
    public partial class Rpot_ReceivedStock : Form
    {
        public Rpot_ReceivedStock()
        {
            InitializeComponent();
        }


        public static DateTimePicker dtpFrom = new DateTimePicker();
        public static DateTimePicker dtpTo = new DateTimePicker();
        public static ComboBox cb_supp = new ComboBox();

        private void Rpot_ReceivedStock_Load(object sender, EventArgs e)
        {
            dtpFrom = dateTimePicker_From;
            dtpTo = dateTimePicker_to;
            cb_supp = cbxAddItemSupplier;


            DataSet log = new DataSet();
            String sql = "SELECT*FROM tbl_AddS_Supplier";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbxAddItemSupplier.Items.Add(ns.Rows[i]["Business_Name"]);
            }



            pnl_Rpot_ReceiveS.Controls.Clear();
            Rpot_ReceiveStock1 rrecevi = new Rpot_ReceiveStock1();
            rrecevi.TopLevel = false;
            rrecevi.Visible = true;
            pnl_Rpot_ReceiveS.Controls.Add(rrecevi);

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            pnl_Rpot_ReceiveS.Controls.Clear();
            Rpot_ReceiveStock1 rrecevi = new Rpot_ReceiveStock1();
            rrecevi.TopLevel = false;
            rrecevi.Visible = true;
            pnl_Rpot_ReceiveS.Controls.Add(rrecevi);
        }

        private void cbxAddItemSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnl_Rpot_ReceiveS.Controls.Clear();
            Rpot_ReceiveStock2 rrecevi = new Rpot_ReceiveStock2();
            rrecevi.TopLevel = false;
            rrecevi.Visible = true;
            pnl_Rpot_ReceiveS.Controls.Add(rrecevi);
        }
    }
}
