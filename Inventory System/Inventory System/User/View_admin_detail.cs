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
    public partial class View_admin_detail : Form
    {
        public View_admin_detail()
        {
            InitializeComponent();
        }


        User_acc_DB_Operations user_op = new User_acc_DB_Operations();

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SqlDataReader odr = user_op.select_owner();
            if (odr.Read())
            {
                txt_User_Name.Text = odr["User_Name"].ToString();
                txt_Password.Text = odr["Password"].ToString();
                txt_Con_Password.Text = odr["Password"].ToString();
                cbx_security_q.Text = odr["Security_Qestion"].ToString();
                txt_Sec_q_Ans.Text = odr["Security_Answer"].ToString();

            }

            pnl_view.Visible = false;
            pnl_edit.Visible = true;
        }

        private void View_admin_detail_Load(object sender, EventArgs e)
        {
            SqlDataReader odr = user_op.select_owner();
            if (odr.Read())
            {
                lbl_user_nm.Text = odr["User_Name"].ToString();
                //lbl_pas.Text = odr["Password"].ToString();
                lbl_qt.Text = odr["Security_Qestion"].ToString();
                lbl_ans.Text = odr["Security_Answer"].ToString();

            }


        }

        

        //private void btn_cancel_Click(object sender, EventArgs e)
        //{
        //    Main.ActiveForm.Disposed += new EventHandler(close_Main_account);
        //}

        //private void close_Main_account(object sender, EventArgs e)
        //{
        //    Main.ActiveForm.Dispose();
        //}
        


        private void btn_ok_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_User_Name, "");
            errorProvider2.SetError(txt_Password, "");
            errorProvider3.SetError(txt_Con_Password, "");
            errorProvider4.SetError(cbx_security_q, "");
            errorProvider5.SetError(txt_Sec_q_Ans, ""); 

            try
            {
                if (txt_User_Name.Text != "" && txt_Password.Text != "" && txt_Sec_q_Ans.Text != "" && cbx_security_q.Text != "")
                {
                    if (txt_Password.Text == txt_Con_Password.Text)
                    {

                        user_op.Update_Owner_acc(txt_User_Name.Text, txt_Password.Text, txt_Con_Password.Text, cbx_security_q.Text, txt_Sec_q_Ans.Text, lbl_user_nm.Text);
                        if (MessageBox.Show("Owner Details Updated Sucessfuly", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            pnl_view.Visible = true;
                            pnl_edit.Visible = false;

                            SqlDataReader odr = user_op.select_owner();
                            if (odr.Read())
                            {
                                lbl_user_nm.Text = odr["User_Name"].ToString();
                                //lbl_pas.Text = odr["Password"].ToString();
                                lbl_qt.Text = odr["Security_Qestion"].ToString();
                                lbl_ans.Text = odr["Security_Answer"].ToString();

                            }

                        }
                    }
                    else
                    {
                        toolTip1.Show("Passwords does not Match", btn_ok);
                        errorProvider2.SetError(txt_Password, "Passwords does not Match Password");
                        errorProvider3.SetError(txt_Con_Password, "Passwords does not Match Password");
                    }
                }
                else
                {
                    if (txt_User_Name.Text == "") { errorProvider1.SetError(txt_User_Name, "Enter Owner Name"); }
                    if (txt_Password.Text == "") { errorProvider2.SetError(txt_Password, "Enter Password"); }
                    if (txt_Con_Password.Text == "") { errorProvider3.SetError(txt_Con_Password, "Conform Password"); }
                    if (cbx_security_q.Text == "") { errorProvider4.SetError(cbx_security_q, "Chosse Question"); }
                    if (txt_Sec_q_Ans.Text == "") { errorProvider5.SetError(txt_Sec_q_Ans, "Enter Awnser "); }

                }

            }
            catch (Exception) { }
            
        }

        private void btn_cann1_Click(object sender, EventArgs e)
        {
            pnl_view.Visible = true;
            pnl_edit.Visible = false;
        }

        private void View_admin_detail_FormClosed(object sender, FormClosedEventArgs e)
        {
       
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_User_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && !char.IsWhiteSpace(e.KeyChar))
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txt_User_Name, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && !char.IsWhiteSpace(e.KeyChar))
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txt_Password, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txt_Con_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && !char.IsWhiteSpace(e.KeyChar))
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txt_Con_Password, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txt_Sec_q_Ans_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && !char.IsWhiteSpace(e.KeyChar))
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txt_Sec_q_Ans, 0, -50, 700);
                e.Handled = true;
            } 
        }

       
    }
}
