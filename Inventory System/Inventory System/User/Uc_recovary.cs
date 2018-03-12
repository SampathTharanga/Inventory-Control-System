using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Uc_recovary : UserControl
    {
        public Uc_recovary()
        {
            InitializeComponent();
        }

        User_acc_DB_Operations usrOp = new User_acc_DB_Operations();
        
        public static TextBox tx_pas = new TextBox();
        public static TextBox tx_comP = new TextBox();
        public static TextBox tx_anser = new TextBox();
        public static ComboBox cb_qus = new ComboBox();
        public static Label lb_nm = new Label();


        private void Uc_recovary_Load(object sender, EventArgs e)
        {
            lbl_unnmm.Text = Froget_Login.unnmm;
            cbx_security_question.Text = Froget_Login.qqus;
            txt_Security_Answer.Text = Froget_Login.awns;

            tx_pas = txt_pass;
            tx_comP = txt_comPass;
            tx_anser = txt_Security_Answer;
            cb_qus = cbx_security_question;
            lb_nm = lbl_unnmm;

            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                
                e.Handled = true;
            } 
        }

        private void txt_comPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {

                e.Handled = true;
            } 
        }

        private void txt_Security_Answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {

                e.Handled = true;
            } 
        }

        

        
    }
}
