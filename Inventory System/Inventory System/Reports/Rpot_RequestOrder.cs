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
    public partial class Rpot_RequestOrder : Form
    {
        public Rpot_RequestOrder()
        {
            InitializeComponent();
        }

        public static DateTimePicker frmdte_Rqstodr = new DateTimePicker();
        public static DateTimePicker todte_Rqstodr = new DateTimePicker();
        public static ComboBox cb_odr = new ComboBox();

        private void Rpot_RequestOrder_Load(object sender, EventArgs e)
        {
            frmdte_Rqstodr = dateTimePicker_From;
            todte_Rqstodr = dateTimePicker_to;
            cb_odr = cbx_reqstrodr;


            pn_RqstOdr.Controls.Clear();
            Rpot_RequestOdr1 roder = new Rpot_RequestOdr1();
            roder.TopLevel = false;
            roder.Visible = true;
            pn_RqstOdr.Controls.Add(roder);

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            pn_RqstOdr.Controls.Clear();
            Rpot_RequestOdr1 roder = new Rpot_RequestOdr1();
            roder.TopLevel = false;
            roder.Visible = true;
            pn_RqstOdr.Controls.Add(roder);
        }

        private void cbx_reqstrodr_SelectedIndexChanged(object sender, EventArgs e)
        {
            pn_RqstOdr.Controls.Clear();
            Rpot_RequestOdr2 roder = new Rpot_RequestOdr2();
            roder.TopLevel = false;
            roder.Visible = true;
            pn_RqstOdr.Controls.Add(roder);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Report_main.pn_Rpot.Controls.Clear();
            Rpot_RequestOdr1 rRqst = new Rpot_RequestOdr1();
            rRqst.TopLevel = false;
            rRqst.Visible = true;
            Report_main.pn_Rpot.Controls.Add(rRqst);
        
        }
    }
}
