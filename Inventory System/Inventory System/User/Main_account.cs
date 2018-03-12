using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Main_account : Form
    {
        public Main_account()
        {
            InitializeComponent();
        }


        User_acc_DB_Operations user_op = new User_acc_DB_Operations();
        bool accCreat;
        public static TextBox tx_unmmee = new TextBox();
        private void Main_account_Load(object sender, EventArgs e)
        {
            accCreat = false;

            tx_unmmee = txt_User_Name;

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_User_Name, "");
            errorProvider2.SetError(txt_Password, ""); 
            errorProvider3.SetError(txt_Con_Password, ""); 
            errorProvider4.SetError(cbx_security_q, ""); 
            errorProvider5.SetError(txt_Sec_q_Ans, ""); 

            
            if (txt_User_Name.Text != "" && txt_Password.Text != "" && txt_Sec_q_Ans.Text != "" && cbx_security_q.Text != "")
            {
                if (txt_Password.Text == txt_Con_Password.Text)
                {
                    user_op.Insert_Onwer_Acc(txt_User_Name.Text, txt_Password.Text, txt_Con_Password.Text, cbx_security_q.Text, txt_Sec_q_Ans.Text);
                    if (MessageBox.Show("Owner Account Created Sucessfuly", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        accCreat = true;
                        this.Visible = false;
                        Log_main logg = new Log_main();
                        logg.Show();

                    }
                }
                else 
                {
                    toolTip1.Show("Passwords does not Match", btn_OK);
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

        private void Main_account_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.admin_details = false;
            if (accCreat == false)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            //------------clear all textbox.text-----------------
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

            cbx_security_q.SelectedItem=null;

            errorProvider1.SetError(txt_User_Name, "");
            errorProvider2.SetError(txt_Password, "");
            errorProvider3.SetError(txt_Con_Password, "");
            errorProvider4.SetError(cbx_security_q, "");
            errorProvider5.SetError(txt_Sec_q_Ans, ""); 

        }

        
    }
}
