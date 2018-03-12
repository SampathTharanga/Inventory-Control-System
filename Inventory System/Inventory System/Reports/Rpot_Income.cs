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
    public partial class Rpot_Income : Form
    {
        public Rpot_Income()
        {
            InitializeComponent();
        }

        public static string invocomplet;
        public static DateTimePicker dtp_Fdate = new DateTimePicker();
        public static DateTimePicker dtp_Tdate = new DateTimePicker();

        private void Rpot_Income_Load(object sender, EventArgs e)
        {
            DateTime tdy = DateTime.Now.AddDays(1);
            dateTimePicker_to.Text = tdy.ToShortDateString();


            dtp_Fdate = dateTimePicker_From;
            dtp_Tdate = dateTimePicker_to;



            pnl_Rpot_Invoice.Controls.Clear();
            Rpot_Income1 rinvo = new Rpot_Income1();
            rinvo.TopLevel = false;
            rinvo.Visible = true;
            pnl_Rpot_Invoice.Controls.Add(rinvo);
        }

        private void cbx_payComple_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_payComple.Text == "Complete")
            {
                invocomplet = "Ok";

                pnl_Rpot_Invoice.Controls.Clear();
                Rpot_Income2 rinvo = new Rpot_Income2();
                rinvo.TopLevel = false;
                rinvo.Visible = true;
                pnl_Rpot_Invoice.Controls.Add(rinvo);
            }

            else if (cbx_payComple.Text == "Not Complete")
            {
                invocomplet = "Not Complete";

                pnl_Rpot_Invoice.Controls.Clear();
                Rpot_Income2 rinvo = new Rpot_Income2();
                rinvo.TopLevel = false;
                rinvo.Visible = true;
                pnl_Rpot_Invoice.Controls.Add(rinvo);
            }
            else
            {
                pnl_Rpot_Invoice.Controls.Clear();
                Rpot_Income1 rinvo = new Rpot_Income1();
                rinvo.TopLevel = false;
                rinvo.Visible = true;
                pnl_Rpot_Invoice.Controls.Add(rinvo);
            }

            

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Report_main.pn_Rpot.Controls.Clear();
            Rpot_Income rinvo = new Rpot_Income();
            rinvo.TopLevel = false;
            rinvo.Visible = true;
            Report_main.pn_Rpot.Controls.Add(rinvo);
        }

       

       
    }
}
