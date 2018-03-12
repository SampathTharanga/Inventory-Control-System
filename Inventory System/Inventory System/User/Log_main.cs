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
    public partial class Log_main : Form
    {
        public Log_main()
        {
            InitializeComponent();
        }

        public static Panel plod = new Panel();
        public static bool firstlog1;
        private void Log_main_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
            plod = pnl_login;

            pnl_login.Controls.Clear();
           Login loo = new Login();
           loo.TopLevel = false;
           loo.Visible = true;
           pnl_login.Controls.Add(loo);


           firstlog1 = true;


           //--------------------------------Close Log_main-----------------------------------//
           for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
           {
               if (Application.OpenForms[1].Name == "Main_account")
               {
                   Application.OpenForms[1].Close();
               }
           }
            //---------------------------------------------------------------------------------//

           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text =DateTime.Now.ToLongTimeString();
            //DateTime dy = DateTime.Now;
            //this.Text = dy.ToShortDateString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Log_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            firstlog1 = false;
            
        }


        
    }
}
