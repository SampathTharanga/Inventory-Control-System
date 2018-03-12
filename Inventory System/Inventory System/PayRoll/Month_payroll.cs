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
    public partial class Month_payroll : Form
    {
        public Month_payroll()
        {
            InitializeComponent();
        }

        public static Panel ppl = new Panel();
        public static Label lbl = new Label();

        private void Month_payroll_Load(object sender, EventArgs e)
        {
            ppl = panel_payroll;
            lbl = lbl_now_d;

            panel_payroll.Controls.Clear();
            Paysheet_month View_pay = new Paysheet_month();
            View_pay.TopLevel = false;
            View_pay.Visible = true;
            panel_payroll.Controls.Add(View_pay);
        }


        private void btn_month_Click(object sender, EventArgs e)
        {
            panel_payroll.Controls.Clear();
            Paysheet_month View_pay = new Paysheet_month();
            View_pay.TopLevel = false;
            View_pay.Visible = true;
            panel_payroll.Controls.Add(View_pay);
        }

        private void btn_histy_Click(object sender, EventArgs e)
        {
            panel_payroll.Controls.Clear();
            paysheet_histry View_pay = new paysheet_histry();
            View_pay.TopLevel = false;
            View_pay.Visible = true;
            panel_payroll.Controls.Add(View_pay);
        }

       

        

        
    }
}
