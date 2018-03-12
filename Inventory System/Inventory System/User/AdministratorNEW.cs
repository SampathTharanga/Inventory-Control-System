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
    public partial class AdministratorNEW : Form
    {
        public AdministratorNEW()
        {
            InitializeComponent();
        }

        User_acc_DB_Operations op2 = new User_acc_DB_Operations();
        User_Level_DB_Operation op1 = new User_Level_DB_Operation();
        Login lo = new Login();
        Parse_UserAcc_Details op = new Parse_UserAcc_Details();
        string un, ut;
        string own_un, own_pw;
        int check = 0;

        private void AdministratorNEW_Load(object sender, EventArgs e)
        {
            SqlDataReader owndr = op2.select_owner();
            if (owndr.Read())
            {
                own_un = owndr["User_Name"].ToString();
                own_pw = owndr["Password"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Log_main.plod.Controls.Clear();
            Login loo = new Login();
            loo.TopLevel = false;
            loo.Visible = true;
            Log_main.plod.Controls.Add(loo);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            un = ""; ut = "";

            if (txt_AD_UserN.Text != "" && txt_AD_Pass.Text != "")
            {
                if (txt_AD_UserN.Text == own_un && txt_AD_Pass.Text == own_pw)
                {
                    
                    
                    Login loo = new Login();
                    Log_main.plod.Controls.Clear();
                    loo.TopLevel = false;
                    loo.Visible = true;
                    Log_main.plod.Controls.Add(loo);
                    User_Account nhome = new User_Account();
                    nhome.ShowDialog();

                    //this.Close();


                }
                else
                {
                    SqlDataReader accdr=op2.select(txt_AD_UserN.Text, txt_AD_Pass.Text);
                    if (accdr.Read())
                    {
                        ut = accdr["User_Type"].ToString();
                        if(ut=="Administrator")
                        {
                            Log_main.plod.Controls.Clear();
                            Login loo = new Login();
                            loo.TopLevel = false;
                            loo.Visible = true;
                            Log_main.plod.Controls.Add(loo);
                            User_Account nhome = new User_Account();
                            nhome.ShowDialog();
                           

                            
                           // this.Close();

                        }
                        else {toolTip1.Show("Thia Details not an Administrator ",button1,1500);}
                       
                    }
                    else
                    {
                        if (MessageBox.Show("The username or password you entered is incorrect", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            txt_AD_Pass.Clear();
                            txt_AD_UserN.Clear();
                            check++;
                            
                            if (check == 6) { Application.Exit(); }

                        
                        }
                    }

                
                }

            }
            else 
            {
                if (txt_AD_UserN.Text == "") { toolTip1.Show("Enter User Name", txt_AD_UserN, 1000); }
                if (txt_AD_Pass.Text == "") { toolTip2.Show("Enter Passward", txt_AD_Pass, 1000); }
                
            }
            
        }
        

        private void txt_AD_UserN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar))
            {
                toolTip1.Show("Please Enter Digits and Charactor!", txt_AD_UserN, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_AD_UserN_TextChanged(object sender, EventArgs e)
        {
            txt_AD_UserN.MaxLength = 10;
        }

        private void txt_AD_Pass_TextChanged(object sender, EventArgs e)
        {
            txt_AD_Pass.MaxLength = 20;
        }
    }
}
