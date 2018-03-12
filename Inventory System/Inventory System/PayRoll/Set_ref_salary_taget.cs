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
    public partial class Set_ref_salary_taget : Form
    {
        public Set_ref_salary_taget()
        {
            InitializeComponent();
        }

        Payroll_DB_Oparetion pay_op = new Payroll_DB_Oparetion();
        DataTable dtbl;
        public static DataGridView dgvus =new DataGridView();
        public static bool edt;

        private void Set_ref_salary_taget_Load(object sender, EventArgs e)
        {
            dgvus = dgv_Ref_Sal_Target;

            DataSet dsa = pay_op.all();
            dgv_Ref_Sal_Target.DataSource = dsa.Tables["tbl_Salary_And_Target"];
            dgv_Ref_Sal_Target.Columns["Monthly_Salary"].Width = 170;
            dgv_Ref_Sal_Target.Columns["Monthly_Trget"].Width = 170;

            String sql = "SELECT*FROM tbl_Salary_And_Target";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbx_ref_Name.Items.Add(ns.Rows[i]["User_Name"]);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                String emty = "SELECT User_Name FROM tbl_Salary_And_Target";
                SqlDataAdapter iigemty = new SqlDataAdapter(emty, ConnectionDB.Connection());
                DataTable iemty = new DataTable();
                iigemty.Fill(iemty);
                if (0 != iemty.Rows.Count) // does not exist
                {

                    edt = true;

                    Change_saery_target cgng = new Change_saery_target();
                    cgng.ShowDialog();
                }
                else { tool_tip_emty.Show("There are No UserName ", cbx_ref_Name, 1, 70, 2500); }
            }
            catch (Exception) { }


        }

        private void cbx_ref_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Salary_And_Target";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_Ref_Sal_Target.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "User_Name like '%" + cbx_ref_Name.SelectedItem + "%' ";
            dgv_Ref_Sal_Target.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbx_ref_Name.Text = "";
            DataSet dsa = pay_op.all();
            dgv_Ref_Sal_Target.DataSource = dsa.Tables["tbl_Salary_And_Target"];
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      
    }
}
