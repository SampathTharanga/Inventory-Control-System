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
    public partial class Rpot_ItemList : Form
    {
        public Rpot_ItemList()
        {
            InitializeComponent();
        }


        public static ComboBox cb_ctgy = new ComboBox();
        public static ComboBox cb_Subctgy = new ComboBox();


        private void Rpot_ItemList_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Rpot_view_Item.LocalReport.ReleaseSandboxAppDomain();
        }

        private void Rpot_ItemList_Load(object sender, EventArgs e)
        {
            cb_ctgy = cbx_ctgy;
            cb_Subctgy = cbx_subctgy;


            pnl_itmlst.Controls.Clear();
            Rpot_ItemList1 ilist1 = new Rpot_ItemList1();
            ilist1.TopLevel = false;
            ilist1.Visible = true;
            pnl_itmlst.Controls.Add(ilist1);



            String csql = "SELECT*FROM tbl_catogory";
            SqlDataAdapter cget = new SqlDataAdapter(csql, ConnectionDB.Connection());
            DataTable cdt = new DataTable();
            cget.Fill(cdt);
            for (int i = 0; i < cdt.Rows.Count; i++)
            {
                cbx_ctgy.Items.Add(cdt.Rows[i]["catogory"]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_itmlst.Controls.Clear();
            Rpot_ItemList1 ilist1 = new Rpot_ItemList1();
            ilist1.TopLevel = false;
            ilist1.Visible = true;
            pnl_itmlst.Controls.Add(ilist1);

            cbx_ctgy.Text = "";
            cbx_subctgy.Text = "";
            cbx_subctgy.Items.Clear();
        }

        private void cbx_ctgy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_subctgy.Items.Clear();
            cbx_subctgy.Text = "";
            String sql = "SELECT sub_catogory FROM tbl_sub_catogory WHERE catogory='" + cbx_ctgy.Text + "'";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbx_subctgy.Items.Add(ns.Rows[i]["sub_catogory"]);
            }

            pnl_itmlst.Controls.Clear();
            Rpot_ItmList2 ilist2 = new Rpot_ItmList2();
            ilist2.TopLevel = false;
            ilist2.Visible = true;
            pnl_itmlst.Controls.Add(ilist2);

        }

        private void cbx_subctgy_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnl_itmlst.Controls.Clear();
            Rpot_ItmList3 ilist3 = new Rpot_ItmList3();
            ilist3.TopLevel = false;
            ilist3.Visible = true;
            pnl_itmlst.Controls.Add(ilist3);
        }
    }
}
