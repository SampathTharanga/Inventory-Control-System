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
    public partial class Splsh_Screen : Form
    {
        public Splsh_Screen()
        {
           
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar_splsh.Value < 100)
            {
                progressBar_splsh.Value = progressBar_splsh.Value + 4;

            }
            else
            {
                String emty = "SELECT*FROM tbl_Admin_Accounts";
                SqlDataAdapter iigemty = new SqlDataAdapter(emty, ConnectionDB.Connection());
                DataTable iemty = new DataTable();
                iigemty.Fill(iemty);
                if (0 != iemty.Rows.Count) // does not exist
                {
                    timer_splh.Enabled = false;
                    Log_main start = new Log_main();
                    start.Show();
                    this.Visible = false;

                }
                else
                {
                    timer_splh.Enabled = false;
                    Main_account start = new Main_account();
                    start.Show();
                    Main_account.tx_unmmee.Focus();
                    this.Visible = false;


                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
