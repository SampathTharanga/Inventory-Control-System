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
    public partial class Get_sal_history : Form
    {
        public Get_sal_history()
        {
            InitializeComponent();
        }

        Payroll_DB_Oparetion pay_op = new Payroll_DB_Oparetion();
        DateTime Now_dte;
        DataTable dtbl;
        string DB_yer, DB_mon;

        private void Get_sal_history_Load(object sender, EventArgs e)
        {
            SqlDataReader tmpdr = pay_op.select_Temp_data();
            if (tmpdr.Read())
            {
                DB_yer = tmpdr["Year"].ToString();
                DB_mon = tmpdr["Month"].ToString();

            }


            String sql = "SELECT*FROM tbl_UserAccount";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbx_usernn.Items.Add(ns.Rows[i]["User_Name"]);
            }

            for (int iy = 2000; iy <= 2030; iy++)
            {
                string iiy = iy.ToString();
                cbx_year.Items.Add(iiy);
            }

            for (int im = 1; im <= 12; im++)
            {
                string iim = im.ToString();
                cbx_month.Items.Add(im);
            }


            cbx_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbx_year.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_year.AutoCompleteSource = AutoCompleteSource.ListItems;


            cbx_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbx_month.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_month.AutoCompleteSource = AutoCompleteSource.ListItems;



            DataSet ads = pay_op.all_Receives_sal();
            dgv_get_histry.DataSource = ads.Tables["tbl_Salary_Received"];

            dgv_get_histry.Columns["User_Name"].Width = 140;
            dgv_get_histry.Columns["Received_Date"].Width = 200;
            dgv_get_histry.Columns["Received_Salary"].Width = 190;


            
        }

        private void cbx_usernn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Salary_Received";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_get_histry.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "User_Name like '%" + cbx_usernn.Text + "%' ";
            dgv_get_histry.DataSource = dv;


            cbx_year.Text = "";
            cbx_month.Text = "";
        }

        private void cbx_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Salary_Received WHERE User_Name='" + cbx_usernn.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_get_histry.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Year like '%" + cbx_year.Text + "%' ";
            dgv_get_histry.DataSource = dv;


            cbx_month.Text = "";
        }

        private void cbx_month_SelectedIndexChanged(object sender, EventArgs e)
        {
             errorProvider_Unme.SetError(cbx_usernn, "");
            errorProvider_yer.SetError(cbx_year, "");
            errorProvider_mon.SetError(cbx_month, "");

            lbl_tot_sal.Text = "N/A";
            lbl_reced_sal.Text = "N/A";
            lbl_rest.Text = "N/A";
            lbl_adition_reced.Text = "N/A";

            if (cbx_usernn.Text != "" && cbx_year.Text != "" && cbx_month.Text != "")
            {
               

                    string sql = "SELECT * FROM tbl_Salary_Received WHERE User_Name='" + cbx_usernn.Text + "' AND Year='" + cbx_year.Text + "' ";
                    SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
                    dtbl = new DataTable();
                    da.Fill(dtbl);
                    BindingSource bnsue = new BindingSource();
                    bnsue.DataSource = dtbl;
                    dgv_get_histry.DataSource = bnsue;
                    da.Update(dtbl);

                    DataView dv = new DataView(dtbl);
                    dv.RowFilter = "Month like '%" + cbx_month.Text + "%' ";
                    dgv_get_histry.DataSource = dv;



                    SqlDataReader hsdr = pay_op.select_sal_histy(cbx_usernn.Text, cbx_year.Text, cbx_month.Text);
                    if (hsdr.Read())
                    {
                        lbl_tot_sal.Text = hsdr["Total_Salary"].ToString();
                        lbl_reced_sal.Text = hsdr["Received_Salary"].ToString();
                        lbl_rest.Text = hsdr["Rest_Salary"].ToString();
                        lbl_adition_reced.Text = hsdr["Additional_Received"].ToString();

                    }
                    if (cbx_year.Text == DB_yer && cbx_month.Text == DB_mon)
                    {
                        lbl_tot_sal.Text = "N/A";
                        lbl_reced_sal.Text = "N/A";
                        lbl_rest.Text = "N/A";
                        lbl_adition_reced.Text = "N/A";

                    }

                   
            }
            else
            {


                if (cbx_usernn.Text == "")
                { errorProvider_Unme.SetError(cbx_usernn, "Plese Select Uesr Name"); }

                if (cbx_year.Text == "")
                { errorProvider_yer.SetError(cbx_year, "Plese Select Year"); }

                if (cbx_month.Text == "")
                { errorProvider_mon.SetError(cbx_month, "Plese Select Month"); }


            }
        }

              



    }
}
