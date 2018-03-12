using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Inventory_System
{
    public partial class User_Account : Form
    {
       

        public User_Account()
        {
            InitializeComponent();
           
        }


        public static decimal m_sal=0;
        public static decimal m_targt=0;
        public static bool firt_set;
        bool alrady;
        Regex reg_email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Regex reg_NIC = new Regex(@"^[\d]{9}[v]$");


        //_________START________________________Objects_________________________________________________
        User_acc_DB_Operations DB_Op = new User_acc_DB_Operations();
        Login lo = new Login();
        User_Level_DB_Operation UL_Object = new User_Level_DB_Operation();
        Payroll_DB_Oparetion pay_op = new Payroll_DB_Oparetion();
        //Parse_UserAcc_Details parse_UserAcc = new Parse_UserAcc_Details();
        //_______END_____________________________________________________________________________________




        
        private void User_Account_Load(object sender, EventArgs e)
        {
            timer1.Start();
           // lbl_dte.Text = DateTime.Now.ToString();
        }



       
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            alrady = false;
             errorProvider_fnme.SetError(txt_FirstName, ""); 
             errorProvider_lnme.SetError(txt_LastName, ""); 
             errorProvider_add1.SetError(txt_AddLine1, ""); 
             errorProvider_add2.SetError(txt_AddLine2, ""); 
             errorProvider_mob.SetError(txt_Mobile, ""); 
             errorProvider_pass.SetError(txtPassword, ""); 
             errorProvider_conform.SetError(txtConfirmPassword, ""); 
             errorProvider_ans.SetError(txt_sec_answer, ""); 
             errorProvider_qus.SetError(cbx_security_q, ""); 
             errorProvider_utype.SetError(cbxUserType, "");
             errorProvider_unme.SetError(txtUserName, "");
             errorProvider_email.SetError(txt_Email, ""); 
             errorProvider_nic.SetError(txt_NIC, ""); 

            
            if (txt_FirstName.Text != "" && txt_LastName.Text != "" && txt_Mobile.Text != "" && txt_AddLine1.Text != "" && txt_AddLine2.Text != "" && txtUserName.Text != "" && cbxUserType.Text != "" && cbx_security_q.Text != "" && txt_sec_answer.Text != "" && txt_NIC.Text!="" && txt_Email.Text!="")
            {
                if (reg_email.IsMatch(txt_Email.Text) && reg_NIC.IsMatch(txt_NIC.Text))
                {
                    
                        String iisql = "SELECT User_Name FROM tbl_UserAccount";
                        SqlDataAdapter iiget = new SqlDataAdapter(iisql, ConnectionDB.Connection());
                        DataTable iins = new DataTable();
                        iiget.Fill(iins);
                        for (int ii = 0; ii < iins.Rows.Count; ii++)
                        {
                            string uun = iins.Rows[ii]["User_Name"].ToString();
                            if (uun == txtUserName.Text)
                            { alrady = true; }
                        }

                        String oiisql = "SELECT User_Name FROM tbl_Admin_Accounts";
                        SqlDataAdapter oiiget = new SqlDataAdapter(oiisql, ConnectionDB.Connection());
                        DataTable oiins = new DataTable();
                        oiiget.Fill(oiins);
                        for (int oii = 0; oii < oiins.Rows.Count; oii++)
                        {
                            string ouun = oiins.Rows[oii]["User_Name"].ToString();
                            if (ouun == txtUserName.Text)
                            { alrady = true; }
                        }

                        if (alrady == false)
                        {

                            if (txtPassword.Text == txtConfirmPassword.Text)
                            {
                                if (checkBoxPolicy.Checked == true)
                                {
                                    try
                                    {

                                        //__________________________________________________________________________________________________________________________________________________________________


                                        DB_Op.insert(txt_FirstName.Text, txt_LastName.Text, txt_NIC.Text, txt_Mobile.Text, txt_AddLine1.Text, txt_AddLine2.Text, txt_Email.Text, DateTime.Now.ToString(), cbxUserType.Text, txtUserName.Text, txtPassword.Text, txtConfirmPassword.Text, cbx_security_q.Text, txt_sec_answer.Text);

                                        //_______________________set sal and target____________________________________________________________________________________________________________________


                                        DB_Op.set_sal_tgt(txtUserName.Text, m_sal, m_targt);

                                        //____________________________________________________________________________________________________________________________________________________________

                                        //_______________________Sat sal Balance______________________________________________________________________________________________________________________

                                        pay_op.Insert_sal_blnce(txtUserName.Text, 0, 0);


                                        //______________________________________________________________________________________________________________________________________________________________
                                        if (MessageBox.Show("Account Created Sussesful.", "Sharp Creations", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                        {
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
                        { toolTip_unm.Show("User name alrady exits", txtUserName, 1000);}
                           
                    
                }
                else 
                {
                    if(!reg_email.IsMatch(txt_Email.Text))toolTip_mail.Show("Invalid Email Address", txt_Email, 1000); 
                    if(!reg_NIC.IsMatch(txt_NIC.Text)) toolTip_Nic.Show("NIC Number is not correct format", txt_NIC, 1000);
                }
            }

            else
            {
                if (txt_FirstName.Text == "") { errorProvider_fnme.SetError(txt_FirstName, "Enter First Name"); }
                if (txt_LastName.Text == "") { errorProvider_lnme.SetError(txt_LastName, "Enter Last Name"); }
                if (txt_AddLine1.Text == "") { errorProvider_add1.SetError(txt_AddLine1, "Enter Address line 1"); }
                if (txt_AddLine2.Text == "") { errorProvider_add2.SetError(txt_AddLine2, "Enter Address line 2"); }
                if (txt_Mobile.Text == "") { errorProvider_mob.SetError(txt_Mobile, "Enter Mobile"); }
                if (txtPassword.Text == "") { errorProvider_pass.SetError(txtPassword, "Enter Passward"); }
                if (txtConfirmPassword.Text == "") { errorProvider_conform.SetError(txtConfirmPassword, "Conform passward"); }
                if (txt_sec_answer.Text == "") { errorProvider_ans.SetError(txt_sec_answer, "Enter Awnser"); }
                if (cbx_security_q.Text == "") { errorProvider_qus.SetError(cbx_security_q, "Enter Question"); }
                if (cbxUserType.Text == "") { errorProvider_utype.SetError(cbxUserType, "Select user type"); }
                if (txtUserName.Text == "") { errorProvider_unme.SetError(txtUserName, "Enter User Name"); }
                if (txt_Email.Text == "") { errorProvider_email.SetError(txt_Email, "Enter Email"); }
                if (txt_NIC.Text == "") { errorProvider_nic.SetError(txt_NIC, "Enter NIC Number"); }

            
            
            }

              
            
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            ////Log_main.plod.Controls.Clear();
            ////Login lloog = new Login();
            ////lloog.TopLevel = false;
            ////lloog.Visible = true;

            ////Log_main.plod.Controls.Add(lloog);
           
        }

        private void btn_clear_Click(object sender, EventArgs e)
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

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_unm.Show("Plase enter Number and Caractor!", txt_FirstName, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_unm.Show("Plase enter Number and Caractor!", txt_LastName, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txt_Mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace,Delete
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
                toolTip_unm.Show("Invalid Phone", txt_Mobile, 0, -50, 2000);
                return;
            }
        }

        private void txt_Mobile_TextChanged(object sender, EventArgs e)
        {
            txt_Mobile.MaxLength = 10;
        }

        private void txt_NIC_TextChanged(object sender, EventArgs e)
        {
            txt_NIC.MaxLength = 10;
        }

        private void txt_AddLine1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_unm.Show("Plase enter Number and Caractor!", txt_AddLine1, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txt_AddLine2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_unm.Show("Plase enter Number and Caractor!", txt_AddLine2, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txt_NIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_unm.Show("Plase enter Number and Caractor!", txt_NIC, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_dte.Text = DateTime.Now.ToShortDateString();
        }

        private void label18_Click(object sender, EventArgs e)
        {

            firt_set = true;
            Change_saery_target sal_tar = new Change_saery_target();
            sal_tar.ShowDialog();
        }

        private void User_Account_FormClosed(object sender, FormClosedEventArgs e)
        {
            firt_set = false;
        }

        

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            label18.Font = new Font(Font, Font.Style | FontStyle.Regular);
        }

        private void label18_MouseMove(object sender, MouseEventArgs e)
        {
            label18.Font = new Font(Font, Font.Style | FontStyle.Underline);
        }

        
    }
}
