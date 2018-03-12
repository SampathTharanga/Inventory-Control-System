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
    public partial class paysheet_histry : Form
    {
        public paysheet_histry()
        {
            InitializeComponent();
        }
        Payroll_DB_Oparetion pay_op = new Payroll_DB_Oparetion();
        DataTable dtbl;

        private void paysheet_histry_Load(object sender, EventArgs e)
        {
            DataSet saldr = pay_op.all_sal_histry();
            dgv_Histry.DataSource = saldr.Tables["tbl_Salary_History"];


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

            Month_payroll.lbl.Text = "Payroll Details";
        }

        private void cbx_usernn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Salary_History";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_Histry.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "User_Name like '%" + cbx_usernn.Text + "%' ";
            dgv_Histry.DataSource = dv;

            
            cbx_year.Text = "";
            cbx_month.Text = "";


        }


        private void cbx_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Salary_History WHERE User_Name='"+cbx_usernn.Text+"' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_Histry.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Year like '%" + cbx_year.Text + "%' ";
            dgv_Histry.DataSource = dv;

            
            cbx_month.Text = "";
        }

       

        private void cbx_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider_Unme.SetError(cbx_usernn, "");
            errorProvider_yer.SetError(cbx_year, "");
            errorProvider_mon.SetError(cbx_month, "");

            if (cbx_usernn.Text != "" && cbx_year.Text != "" && cbx_month.Text != "")
            {

                string sql = "SELECT * FROM tbl_Salary_History WHERE User_Name='" + cbx_usernn.Text + "' AND Year='" + cbx_year.Text + "' ";
                SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
                dtbl = new DataTable();
                da.Fill(dtbl);
                BindingSource bnsue = new BindingSource();
                bnsue.DataSource = dtbl;
                dgv_Histry.DataSource = bnsue;
                da.Update(dtbl);

                DataView dv = new DataView(dtbl);
                dv.RowFilter = "Month like '%" + cbx_month.Text + "%' ";
                dgv_Histry.DataSource = dv;



                SqlDataReader hsdr = pay_op.select_sal_histy(cbx_usernn.Text, cbx_year.Text, cbx_month.Text);
                if (hsdr.Read())
                {
                  // Month_payroll.lbl.Text = hsdr["User_Name"].ToString() + "  - " + hsdr["Year"].ToString() + " / " + hsdr["Month"].ToString() + "  Payroll Details";

                    lbl_mon_sal.Text = hsdr["Monthly_Salary"].ToString();
                    lbl_arias.Text = hsdr["Arears"].ToString();
                    lbl_reming.Text = hsdr["Remaining"].ToString();
                    lbl_net_sal.Text = hsdr["Net_Month_Salary"].ToString();
                    lbl_mon_tgt.Text = hsdr["Monthly_Trget"].ToString();
                    lbl_com_tgt.Text = hsdr["Completed_Target"].ToString();
                    lbl_extr_com_tgt.Text = hsdr["Extra_Completed_Target"].ToString();
                    lbl_etra_sal.Text = hsdr["Extra_Salary"].ToString();
                    lbl_tot_sal.Text = hsdr["Total_Salary"].ToString();
                    lbl_totsal1.Text = hsdr["Total_Salary"].ToString();
                    lbl_recevd_sal.Text = hsdr["Received_Salary"].ToString();
                    lbl_sal_rest.Text = hsdr["Rest_Salary"].ToString();
                    lbl_aditionl_receved.Text = hsdr["Additional_Received"].ToString();

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

        private void dgv_Histry_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Month_payroll.lbl.Text = dgv_Histry.CurrentRow.Cells["User_Name"].Value.ToString() + "  - " + dgv_Histry.CurrentRow.Cells["Year"].Value.ToString() + " / " + dgv_Histry.CurrentRow.Cells["Month"].Value.ToString() + "  Payroll Details";

            lbl_mon_sal.Text = dgv_Histry.CurrentRow.Cells["Monthly_Salary"].Value.ToString();
            lbl_arias.Text = dgv_Histry.CurrentRow.Cells["Arears"].Value.ToString();
            lbl_reming.Text = dgv_Histry.CurrentRow.Cells["Remaining"].Value.ToString();
            lbl_net_sal.Text = dgv_Histry.CurrentRow.Cells["Net_Month_Salary"].Value.ToString();
            lbl_mon_tgt.Text = dgv_Histry.CurrentRow.Cells["Monthly_Trget"].Value.ToString();
            lbl_com_tgt.Text = dgv_Histry.CurrentRow.Cells["Completed_Target"].Value.ToString();
            lbl_extr_com_tgt.Text = dgv_Histry.CurrentRow.Cells["Extra_Completed_Target"].Value.ToString();
            lbl_etra_sal.Text = dgv_Histry.CurrentRow.Cells["Extra_Salary"].Value.ToString();
            lbl_tot_sal.Text = dgv_Histry.CurrentRow.Cells["Total_Salary"].Value.ToString();
            lbl_totsal1.Text = dgv_Histry.CurrentRow.Cells["Total_Salary"].Value.ToString();
            lbl_recevd_sal.Text = dgv_Histry.CurrentRow.Cells["Received_Salary"].Value.ToString();
            lbl_sal_rest.Text = dgv_Histry.CurrentRow.Cells["Rest_Salary"].Value.ToString();
            lbl_aditionl_receved.Text = dgv_Histry.CurrentRow.Cells["Additional_Received"].Value.ToString();

            
        }

        private void btn_rreset_Click(object sender, EventArgs e)
        {
            Month_payroll.ppl.Controls.Clear();
            paysheet_histry View_pay = new paysheet_histry();
            View_pay.TopLevel = false;
            View_pay.Visible = true;
            Month_payroll.ppl.Controls.Add(View_pay);
        }

        
    }
}
