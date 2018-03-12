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
    public partial class Get_Sallery : Form
    {
        public Get_Sallery()
        {
            InitializeComponent();
        }
        public static Label lb_m = new Label();

        private void btn_month_Click(object sender, EventArgs e)
        {
            pnl_get_sal.Controls.Clear();
            Get_sal_Month View_pay = new Get_sal_Month();
            View_pay.TopLevel = false;
            View_pay.Visible = true;
            pnl_get_sal.Controls.Add(View_pay);
        }

        private void btn_histy_Click(object sender, EventArgs e)
        {
            pnl_get_sal.Controls.Clear();
            Get_sal_history View_pay = new Get_sal_history();
            View_pay.TopLevel = false;
            View_pay.Visible = true;
            pnl_get_sal.Controls.Add(View_pay);

        }

        private void Get_Sallery_Load(object sender, EventArgs e)
        {
            pnl_get_sal.Controls.Clear();
            Get_sal_Month View_pay = new Get_sal_Month();
            View_pay.TopLevel = false;
            View_pay.Visible = true;
            pnl_get_sal.Controls.Add(View_pay);

            lb_m = lbl_m;

        }
    }
}
