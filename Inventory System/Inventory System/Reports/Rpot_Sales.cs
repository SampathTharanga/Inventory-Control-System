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
    public partial class Rpot_Sales : Form
    {
        public Rpot_Sales()
        {
            InitializeComponent();
        }

        public static DateTimePicker dtpFrom = new DateTimePicker();
        public static DateTimePicker dtpTo = new DateTimePicker();
        public static ComboBox cb_ctogy = new ComboBox();
        public static ComboBox cb_Subctogy = new ComboBox();



        private void Rpot_Sales_Load(object sender, EventArgs e)
        {
            DateTime tdy = DateTime.Now.AddDays(1);
            dateTimePicker_to.Text = tdy.ToShortDateString();

            dtpFrom = dateTimePicker_From;
            dtpTo = dateTimePicker_to;
            cb_ctogy = cbxFindItemCategory;
            cb_Subctogy = cbxFindItemSubCategory;

            String csql = "SELECT*FROM tbl_catogory";
            SqlDataAdapter cget = new SqlDataAdapter(csql, ConnectionDB.Connection());
            DataTable cdt = new DataTable();
            cget.Fill(cdt);
            for (int i = 0; i < cdt.Rows.Count; i++)
            {
                cbxFindItemCategory.Items.Add(cdt.Rows[i]["catogory"]);
            }



            

            cbxFindItemCategory.Text = "";
            cbxFindItemSubCategory.Text = "";

            pnl_Rpot_sales.Controls.Clear();
            Rpot_Sales1 rsale = new Rpot_Sales1();
            rsale.TopLevel = false;
            rsale.Visible = true;
            pnl_Rpot_sales.Controls.Add(rsale);

            

            cbxFindItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbxFindItemCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxFindItemCategory.AutoCompleteSource = AutoCompleteSource.ListItems;


        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            cbxFindItemCategory.Text = "";
            cbxFindItemSubCategory.Text = "";

            pnl_Rpot_sales.Controls.Clear();
            Rpot_Sales1 rsale = new Rpot_Sales1();
            rsale.TopLevel = false;
            rsale.Visible = true;
            pnl_Rpot_sales.Controls.Add(rsale);
        }

        private void cbxFindItemCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxFindItemSubCategory.Text = "";
            String scsql = "SELECT*FROM tbl_sub_catogory";
            SqlDataAdapter scget = new SqlDataAdapter(scsql, ConnectionDB.Connection());
            DataTable scdt = new DataTable();
            scget.Fill(scdt);
            for (int i = 0; i < scdt.Rows.Count; i++)
            {
                cbxFindItemSubCategory.Items.Add(scdt.Rows[i]["sub_catogory"]);
            }


            cbxFindItemSubCategory.Items.Clear();
            cbxFindItemSubCategory.Text = "";
            String sql = "SELECT sub_catogory FROM tbl_sub_catogory WHERE catogory='" + cbxFindItemCategory.Text + "'";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbxFindItemSubCategory.Items.Add(ns.Rows[i]["sub_catogory"]);
            }

            pnl_Rpot_sales.Controls.Clear();
            Rpot_Sales2 rsale = new Rpot_Sales2();
            rsale.TopLevel = false;
            rsale.Visible = true;
            pnl_Rpot_sales.Controls.Add(rsale);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Report_main.pn_Rpot.Controls.Clear();
            Rpot_Sales rsale = new Rpot_Sales();
            rsale.TopLevel = false;
            rsale.Visible = true;
            Report_main.pn_Rpot.Controls.Add(rsale);
        }

        private void cbxFindItemSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnl_Rpot_sales.Controls.Clear();
            Rpot_Sales3 rsale = new Rpot_Sales3();
            rsale.TopLevel = false;
            rsale.Visible = true;
            pnl_Rpot_sales.Controls.Add(rsale);
        }

        private void dateTimePicker_From_ValueChanged(object sender, EventArgs e)
        {
            cbxFindItemCategory.Text = "";
            cbxFindItemSubCategory.Text = "";
        }
    }
}
