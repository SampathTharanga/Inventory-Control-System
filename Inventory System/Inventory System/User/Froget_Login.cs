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
    public partial class Froget_Login : Form
    {
        public Froget_Login()
        {
            InitializeComponent();
        }
        User_Level_DB_Operation op = new User_Level_DB_Operation();
        User_acc_DB_Operations usrOp = new User_acc_DB_Operations();
        public static string unnmm, qqus, awns;
        public static bool own, usr;
        private void Froget_Login_Load(object sender, EventArgs e)
        {
            own = false;
            usr = false;


        }

       
        private void btn_ok_Click(object sender, EventArgs e)
        {
            SqlDataReader ow_rcy = usrOp.select_owner_recory(txt_unme.Text, cbx_security_question.Text, txt_Security_Answer.Text);
            if (ow_rcy.Read())
            {
                own = true;
                unnmm = txt_unme.Text;
                qqus = cbx_security_question.Text;
                awns = txt_Security_Answer.Text;
                panel_fget.Controls.Clear();
                Uc_recovary rec = new Uc_recovary();
                panel_fget.Controls.Add(rec);
                btn_ok.Visible = false; btn_recvr.Visible = true;
            
            }

            SqlDataReader use_rcy = usrOp.select_user_recory(txt_unme.Text, cbx_security_question.Text, txt_Security_Answer.Text);
            if ( use_rcy.Read())
            {
                usr = true;
                unnmm = txt_unme.Text;
                qqus = cbx_security_question.Text;
                awns = txt_Security_Answer.Text;
                panel_fget.Controls.Clear();
                Uc_recovary rec = new Uc_recovary();
                panel_fget.Controls.Add(rec);
                btn_ok.Visible = false; btn_recvr.Visible = true;

            }
            else { lbl_error.Visible = true; }
            
        }

        private void cbx_security_question_Click(object sender, EventArgs e)
        {
            cbx_security_question.Text = "";
        }

        private void btn_recvr_Click(object sender, EventArgs e)
        {
            if (Uc_recovary.tx_pas.Text != "" && Uc_recovary.tx_comP.Text != "" && Uc_recovary.tx_anser.Text != "" && Uc_recovary.cb_qus.Text != "")
            {
                if (Uc_recovary.tx_pas.Text == Uc_recovary.tx_comP.Text)
                {
                    if (Froget_Login.own == true)
                    {
                        usrOp.Update_Owner_acc_rcoy(Uc_recovary.lb_nm.Text, Uc_recovary.tx_pas.Text, Uc_recovary.tx_comP.Text, Uc_recovary.cb_qus.Text, Uc_recovary.tx_anser.Text);
                        if (MessageBox.Show("Account recover sucessfuly", "Sharp creation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        { this.Close();  }

                    }
                    if (Froget_Login.usr == true)
                    {
                        usrOp.Update_user_acc_rcoy(Uc_recovary.lb_nm.Text, Uc_recovary.tx_pas.Text, Uc_recovary.tx_comP.Text, Uc_recovary.cb_qus.Text, Uc_recovary.tx_anser.Text);
                        if (MessageBox.Show("Account recover sucessfuly", "Sharp creation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        { this.Close();  }
                    }

                }
                else { toolTip1.Show("Password does not match", Uc_recovary.tx_comP, 1500); }

            }
            else { toolTip1.Show("Enter Details", Uc_recovary.tx_comP, 1500); }
        }

       
    }
}
