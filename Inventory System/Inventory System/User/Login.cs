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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        User_acc_DB_Operations op2 = new User_acc_DB_Operations();
        User_Level_DB_Operation opUL = new User_Level_DB_Operation();
        Log_main mainLog = new Log_main();
        string own_un, own_pw;
        public static TextBox unmm = new TextBox();


        private void Login_Load(object sender, EventArgs e)
        {
            SqlDataReader owndr = op2.select_owner();
            if (owndr.Read())
            {
                own_un = owndr["User_Name"].ToString();
                own_pw = owndr["Password"].ToString();
            }


            unmm = txtUserName; 

        }

        string un, ut;
        int check = 0;
        

        private void btn_newuser_Click(object sender, EventArgs e)
        {

            //________START______________________New user Acc button__________________________________________________________________________
            Log_main.plod.Controls.Clear();
            AdministratorNEW adnw = new AdministratorNEW();
            adnw.TopLevel = false;
            adnw.Visible = true;
            Log_main.plod.Controls.Add(adnw);
            //_________END_________________________________________________________________________________________________________________
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            txtUserName.MaxLength = 20;
        }

        private void L_lbl_froget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Froget_Login op3 = new Froget_Login();
            op3.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            un = "Mars";
            ut = "Super User";
            Main home = new Main(un, ut);
            home.Show();
            this.Close();
            mainLog.Close();


        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip2.Show("Please Enter Digits and Charactor!", txtUserName, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.MaxLength = 20;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip2.Show("Please Enter Digits and Charactor!", txtPassword, 0, -50, 700);
                e.Handled = true;
            }

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            un = ""; ut = "";

            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                if (txtUserName.Text == own_un && txtPassword.Text == own_pw)
                {
                    un = own_un;
                    ut = "Super User";
                    Main home = new Main(un, ut);
                    home.Show();

                    this.Close();


                }
                else
                {
                    SqlDataReader accdr=op2.select(txtUserName.Text, txtPassword.Text);
                    if (accdr.Read())
                    {
                        un = accdr["User_Name"].ToString();
                        ut = accdr["User_Type"].ToString();
                        Main home = new Main(un, ut);
                        home.Show();


                        this.Close();
                    }
                    else
                    {
                        if (MessageBox.Show("The Username or Password you entered is incorrect", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            txtPassword.Clear();
                            txtUserName.Clear();
                            check++;
                            txtUserName.Focus();
                            if (check == 3) 
                            {
                                if (MessageBox.Show("Did You Forget Your Password", "Sharp Creation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                {
                                    Froget_Login op3 = new Froget_Login();
                                    op3.ShowDialog();
                                }
                            
                            }
                            if (check == 5) { Application.Exit(); }

                        
                        }
                    }

                
                }

            }
            else 
            {
                if (txtUserName.Text == "") { toolTip1.Show("Enter User Name", txtUserName, 1000); }
                if (txtPassword.Text == "") { toolTip2.Show("Enter Passward", txtPassword, 1000); }
                
            }
            
        }

       

        

        
      
    }
}
