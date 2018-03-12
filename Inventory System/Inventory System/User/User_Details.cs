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
    public partial class User_Details : Form
    {
        public User_Details()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        User_Level_DB_Operation op = new User_Level_DB_Operation();
        DataTable dt;
        public static DataGridView dgv_u = new DataGridView();

        private void User_Details_Load(object sender, EventArgs e)
        {
            dgv_u = dgv_User_Details;
            //_______START____________________get table value combo box item__________________________________________________________
            string sql = "SELECT * FROM tbl_UserAccount";
            SqlDataAdapter dget = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable dns = new DataTable();
            dget.Fill(dns);

            for (int i = 0; i < dns.Rows.Count; i++)
            {

                SqlDataReader drm = op.select_UserName(dns.Rows[i]["User_Name"].ToString());
                if (drm.Read())
                {
                    List<string> x = new List<string>();
                    string a = drm["User_Name"].ToString();
                    x.Add(a);
                    cbx_User_Name.Items.AddRange(x.ToArray());

                }
            }
            //_______END_______________________________________________________________________________________________________________

            ds = op.all_Users();
            dgv_User_Details.DataSource = ds.Tables["tbl_UserAccount"];
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public static string GET_USER_NAME;
        private void dgv_User_Details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_U_Type.Text = dgv_User_Details.CurrentRow.Cells["User_Type"].Value.ToString();
            lbl_User_Name.Text = dgv_User_Details.CurrentRow.Cells["User_Name"].Value.ToString();
            lbl_Add_Date.Text = dgv_User_Details.CurrentRow.Cells["Date"].Value.ToString();
            lbl_FName.Text = dgv_User_Details.CurrentRow.Cells["First_Name"].Value.ToString();
            lbl_Mobile.Text = dgv_User_Details.CurrentRow.Cells["Mobile"].Value.ToString();
            lbl_NIC.Text = dgv_User_Details.CurrentRow.Cells["NIC"].Value.ToString();

            GET_USER_NAME = dgv_User_Details.CurrentRow.Cells["User_Name"].Value.ToString();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                Parse_UserAcc_Details parse_val = new Parse_UserAcc_Details();
                parse_val.FName = dgv_User_Details.CurrentRow.Cells["First_Name"].Value.ToString();
                parse_val.LName = dgv_User_Details.CurrentRow.Cells["Last_Name"].Value.ToString();
                parse_val.NIC = dgv_User_Details.CurrentRow.Cells["NIC"].Value.ToString();

                parse_val.Mob = dgv_User_Details.CurrentRow.Cells["Mobile"].Value.ToString();
                parse_val.Add1 = dgv_User_Details.CurrentRow.Cells["Address_Line1"].Value.ToString();
                parse_val.Add2 = dgv_User_Details.CurrentRow.Cells["Address_Line2"].Value.ToString();
                parse_val.Email = dgv_User_Details.CurrentRow.Cells["Email"].Value.ToString();

                parse_val.Date = dgv_User_Details.CurrentRow.Cells["Date"].Value.ToString();
                parse_val.UserType = dgv_User_Details.CurrentRow.Cells["User_Type"].Value.ToString();
                parse_val.UserName = dgv_User_Details.CurrentRow.Cells["User_Name"].Value.ToString();
                parse_val.Password = dgv_User_Details.CurrentRow.Cells["Password"].Value.ToString();
                parse_val.ConPassword = dgv_User_Details.CurrentRow.Cells["Confirm_Password"].Value.ToString();
                parse_val.Sec_question = dgv_User_Details.CurrentRow.Cells["Security_Qestion"].Value.ToString();
                parse_val.Sec_answer = dgv_User_Details.CurrentRow.Cells["Security_Answer"].Value.ToString();

                update_User_Dtail open = new update_User_Dtail(parse_val);
                open.ShowDialog(this);
            }
            catch (Exception) { }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure You wont to Remove" + dgv_User_Details.CurrentRow.Cells["User_Name"].Value.ToString(), "Sharp Creation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    op.delete(dgv_User_Details.CurrentRow.Cells["User_Name"].Value.ToString());
                    MessageBox.Show("Delete Successfuly!.","Sharp Creations",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ds = op.all_Users();
                    dgv_User_Details.DataSource = ds.Tables["tbl_UserAccount"];
                }
            }
            catch (Exception) { }
        }

        private void cbx_UserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_UserAccount";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dt = new DataTable();
            da.Fill(dt);
            BindingSource binso = new BindingSource();
            binso.DataSource = dt;
            dgv_User_Details.DataSource = binso;
            da.Update(dt);

            DataView dv = new DataView(dt);
            dv.RowFilter = "User_Type like '%" + cbx_UserType.Text + "%' ";
            dgv_User_Details.DataSource = dv;
        }

        private void cbx_User_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_UserAccount";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dt = new DataTable();
            da.Fill(dt);
            BindingSource binso = new BindingSource();
            binso.DataSource = dt;
            dgv_User_Details.DataSource = binso;
            da.Update(dt);

            DataView dv = new DataView(dt);
            dv.RowFilter = "User_Name like '" + cbx_User_Name.Text + "' ";
            dgv_User_Details.DataSource = dv;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            cbx_User_Name.Text = null;
            cbx_UserType.Text=null;
        }
    }
}
