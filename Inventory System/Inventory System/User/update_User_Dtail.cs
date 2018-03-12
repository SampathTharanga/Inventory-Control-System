using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Inventory_System
{
    public partial class update_User_Dtail : Form
    {
        Parse_UserAcc_Details Parse_Details;

        public update_User_Dtail(Parse_UserAcc_Details udte)
        {
            InitializeComponent();
            Parse_Details = udte;
        }

        DataSet ds;
        Regex reg_email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Regex reg_NIC = new Regex(@"^[\d]{9}[v]$");
        User_Level_DB_Operation UL_Object = new User_Level_DB_Operation();
        
        string UN;

        private void update_User_Dtail_Load(object sender, EventArgs e)
        {
//_________START______________________________Parse Value_________________________________________________________
            txtFirstName.Text = Parse_Details.FName;
            txtLastName.Text = Parse_Details.LName;
            txt_NIC.Text = Parse_Details.NIC;
            
            txt_Mobile.Text = Parse_Details.Mob;
            txt_AddLine1.Text = Parse_Details.Add1;
            txt_AddLine2.Text = Parse_Details.Add2;
            txt_Email.Text = Parse_Details.Email;
            
            
            //dte = Parse_Details.Date;
            cbxUserType.Text = Parse_Details.UserType;
            lbl_User_Name.Text = Parse_Details.UserName;
            txtPassword.Text = Parse_Details.Password;
            txtConfirmPassword.Text = Parse_Details.ConPassword;
            cbx_security_q.Text = Parse_Details.Sec_question;
            txt_sec_answer.Text = Parse_Details.Sec_answer;
//_________END____________________________________________________________________________________________________
             UN = Parse_Details.UserName;
        }

       
        private void btn_update_Click(object sender, EventArgs e)
        {
            
            errorProvider_fnme.SetError(txtFirstName, "");
            errorProvider_lnme.SetError(txtLastName, "");
            errorProvider_add1.SetError(txt_AddLine1, "");
            errorProvider_add2.SetError(txt_AddLine2, "");
            errorProvider_mob.SetError(txt_Mobile, "");
            errorProvider_pass.SetError(txtPassword, "");
            errorProvider_conform.SetError(txtConfirmPassword, "");
            errorProvider_ans.SetError(txt_sec_answer, "");
            errorProvider_qus.SetError(cbx_security_q, "");
            errorProvider_utype.SetError(cbxUserType, "");
            errorProvider_unme.SetError(lbl_User_Name, "");
            errorProvider_email.SetError(txt_Email, "");
            errorProvider_nic.SetError(txt_NIC, "");


            if (txtFirstName.Text != "" && txtLastName.Text != "" && txt_Mobile.Text != "" && txt_AddLine1.Text != "" && txt_AddLine2.Text != ""  && cbxUserType.Text != "" && cbx_security_q.Text != "" && txt_sec_answer.Text != "" && txt_NIC.Text != "" && txt_Email.Text != "")
            {
                if (reg_email.IsMatch(txt_Email.Text) && reg_NIC.IsMatch(txt_NIC.Text))
                {

                    if (txtPassword.Text == txtConfirmPassword.Text)
                        {
                            if (checkBoxPolicy.Checked == true)
                            {
                                try
                                {

   //__________________________________________________________________________________________________________________________________________________________________


                                    if (MessageBox.Show("User Details Updated Succesfully", "Sharp Creations", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                    {
                                        UL_Object.update_Acc
                                            (
                                            txtFirstName.Text,
                                            txtLastName.Text,
                                            txt_NIC.Text,

                                            txt_Mobile.Text,
                                            txt_AddLine1.Text,
                                            txt_AddLine2.Text,
                                            txt_Email.Text,

                                            cbxUserType.Text,
                                            lbl_User_Name.Text,
                                            txtPassword.Text,
                                            txtConfirmPassword.Text,
                                            cbx_security_q.Text,
                                            txt_sec_answer.Text,
                                            lbl_User_Name.Text

                                            );

                                        ds = UL_Object.all_Users();
                                        User_Details.dgv_u.DataSource = ds.Tables["tbl_UserAccount"];
                                        this.Close();

                                    }
                                   
     //__________________________________________________________________________________________________________________________________________________________________

                                }
                                catch (Exception) { }
                            }
                            else { toolTip_pas.Show("Plese Acsept Mars Privacy Policy", checkBoxPolicy); }
                        }
                        else { toolTip_pas.Show("Password does not Match", txtConfirmPassword, 1000); }
                    }
                else
                {
                    if (!reg_email.IsMatch(txt_Email.Text)) toolTip_mail.Show("Invalid Email Address", txt_Email, 1000);
                    if (!reg_NIC.IsMatch(txt_NIC.Text)) toolTip_Nic.Show("NIC Number is not correct format", txt_NIC, 1000);
                }
            }

            else
            {
                if (txtFirstName.Text == "") { errorProvider_fnme.SetError(txtFirstName, "Enter First Name"); }
                if (txtLastName.Text == "") { errorProvider_lnme.SetError(txtLastName, "Enter Last Name"); }
                if (txt_AddLine1.Text == "") { errorProvider_add1.SetError(txt_AddLine1, "Enter Address line 1"); }
                if (txt_AddLine2.Text == "") { errorProvider_add2.SetError(txt_AddLine2, "Enter Address line 2"); }
                if (txt_Mobile.Text == "") { errorProvider_mob.SetError(txt_Mobile, "Enter Mobile"); }
                if (txtPassword.Text == "") { errorProvider_pass.SetError(txtPassword, "Enter Passward"); }
                if (txtConfirmPassword.Text == "") { errorProvider_conform.SetError(txtConfirmPassword, "Conform passward"); }
                if (txt_sec_answer.Text == "") { errorProvider_ans.SetError(txt_sec_answer, "Enter Awnser"); }
                if (cbx_security_q.Text == "") { errorProvider_qus.SetError(cbx_security_q, "Enter Question"); }
                if (cbxUserType.Text == "") { errorProvider_utype.SetError(cbxUserType, "Select user type"); }
                
                if (txt_Email.Text == "") { errorProvider_email.SetError(txt_Email, "Enter Email"); }
                if (txt_NIC.Text == "") { errorProvider_nic.SetError(txt_NIC, "Enter NIC Number"); }



            }

       
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ret_Click(object sender, EventArgs e)
        {
            //-----------------clear all textbox.text-----------------------
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);

            cbxUserType.SelectedItem = null; cbxUserType.Text = "";
            cbx_security_q.SelectedItem = null; cbx_security_q.Text = "";
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_unm.Show("Plase enter Number and Caractor!", txtFirstName, -1, -1, 2000);
                e.Handled = true;
            } 

        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_unm.Show("Plase enter Number and Caractor!", txtLastName, -1, -1, 700);
                e.Handled = true;
            } 
        }

        private void txt_NIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_unm.Show("Plase enter Number and Caractor!", txt_NIC, -1, -1, 700);
                e.Handled = true;
            } 
        }

        private void txt_Mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace,Delete
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
                toolTip_unm.Show("Invalid Phone", txt_Mobile, -1, -1, 2000);
                return;
            }

        }

        private void txt_AddLine1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_unm.Show("Plase enter Number and Caractor!", txt_AddLine1, -1, -1, 700);
                e.Handled = true;
            } 
        }

        private void txt_AddLine2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_unm.Show("Plase enter Number and Caractor!", txt_AddLine2, -1, -1, 700);
                e.Handled = true;
            } 
        }

        private void txt_Email_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_unm.Show("Plase enter Number and Caractor!", txtPassword, -1, -1, 700);
                e.Handled = true;
            } 
        }

        private void txtConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_unm.Show("Plase enter Number and Caractor!", txtConfirmPassword, -1, -1, 700);
                e.Handled = true;
            } 
        }

        private void txt_sec_answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_unm.Show("Plase enter Number and Caractor!", txt_sec_answer, -1, -1, 700);
                e.Handled = true;
            } 
        }


    }
}
