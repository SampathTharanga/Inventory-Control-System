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
    public partial class Restor : Form
    {
        public Restor()
        {
            InitializeComponent();
        }

        Temp_DB_Operation tempOp = new Temp_DB_Operation();

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked=true;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void btn_rstor_Click(object sender, EventArgs e)
        {
            if (checkBox_Detail.Checked)
            {
                //______________________________________________________________________________________________________________
                string sqlTrunc_qty = "TRUNCATE TABLE " + "tbl_catogory";
                SqlCommand cmd = new SqlCommand(sqlTrunc_qty, ConnectionDB.Connection());
                cmd.ExecuteNonQuery();

                string sqlTrunc_sub_qty = "TRUNCATE TABLE " + "tbl_sub_catogory";
                SqlCommand cmd1 = new SqlCommand(sqlTrunc_sub_qty, ConnectionDB.Connection());
                cmd1.ExecuteNonQuery();

                string sqlTrunc_brd = "TRUNCATE TABLE " + "tbl_brande";
                SqlCommand cmd2 = new SqlCommand(sqlTrunc_brd, ConnectionDB.Connection());
                cmd2.ExecuteNonQuery();

                string sqlTrunc_typ = "TRUNCATE TABLE " + "tbl_itype";
                SqlCommand cmd3 = new SqlCommand(sqlTrunc_typ, ConnectionDB.Connection());
                cmd3.ExecuteNonQuery();

                //______________________________________________________________________________________________________________

                tempOp.invetry_insert();
                //MessageBox.Show("okk");

      
            }
            if (checkBox_custo.Checked)
            {

                string sqlTrunc_qty = "TRUNCATE TABLE " + "tbl_Add_Customer";
                SqlCommand cmd = new SqlCommand(sqlTrunc_qty, ConnectionDB.Connection());
                cmd.ExecuteNonQuery();
                tempOp.custo_insrt();
                //MessageBox.Show("okk");
            }

            if (checkBox_supp.Checked)
            {
                string sqlTrunc_qty = "TRUNCATE TABLE " + "tbl_AddS_Supplier";
                SqlCommand cmd = new SqlCommand(sqlTrunc_qty, ConnectionDB.Connection());
                cmd.ExecuteNonQuery();
                tempOp.supp_insrt();
                //MessageBox.Show("okk");
            }

            if (MessageBox.Show("Checked Details Restored Sucessfully..!. \nInventory Control now will restart.", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Main.rstor = true;
                Application.Restart();

            }
                
                
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
