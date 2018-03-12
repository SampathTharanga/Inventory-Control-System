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
    public partial class Warranty_Details : Form
    {
        public Warranty_Details()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        DataTable dtbl = new DataTable();
        Warranty_DB_Operetion wrty = new Warranty_DB_Operetion();

        public static DataGridView dgvw = new DataGridView();
        public static Panel ppw = new Panel();

        private void Warranty_Details_Load(object sender, EventArgs e)
        {
            ds = wrty.allWarty();
            dgv_viewWarty.DataSource = ds.Tables["tbl_Warranty"];

            dgvw = dgv_viewWarty;
            ppw = pnl_wtyDtail;


        }

        private void dgv_viewWarty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_viewWarty.CurrentRow.Cells["Warranty_Complete"].Value.ToString() == "InComplete")
            {
                pnl_wtyDtail.Controls.Clear();
                wty_dtail_inconplete incpte = new wty_dtail_inconplete();
                incpte.TopLevel = false;
                incpte.Visible = true;
                pnl_wtyDtail.Controls.Add(incpte);
            }
            else if (dgv_viewWarty.CurrentRow.Cells["Warranty_Complete"].Value.ToString() == "Complete")
            {
                pnl_wtyDtail.Controls.Clear();
                wty_dtail_Conplete comte = new wty_dtail_Conplete();
                comte.TopLevel = false;
                comte.Visible = true;
                pnl_wtyDtail.Controls.Add(comte);
            }
            else
            { 
            
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
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
        }

        private void txt_invoNo_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Warranty";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_viewWarty.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Invoice_No like '%" + txt_invoNo.Text + "%' ";
            dgv_viewWarty.DataSource = dv;
        }

        private void txt_itmnme_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Warranty";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_viewWarty.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Item_Name like '%" + txt_itmnme.Text + "%' ";
            dgv_viewWarty.DataSource = dv;
        }

        private void txt_serial_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Warranty";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_viewWarty.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Serial_No like '%" + txt_serial.Text + "%' ";
            dgv_viewWarty.DataSource = dv;
        }

        private void txt_cusnnm_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Warranty";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_viewWarty.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Customer_Name like '%" + txt_cusnnm.Text + "%' ";
            dgv_viewWarty.DataSource = dv;
        }

        //private void Warranty_Details_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (wty_dtail_inconplete.bt_save == true)
        //    {
        //        MessageBox.Show("Plese save Warranty changes");

            
        //    }
        //}

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (wty_dtail_inconplete.bt_save == true)
            {
                MessageBox.Show("Plese save Warranty changes","Sharp Creation",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                errorProvider_save.SetError(wty_dtail_inconplete.btClick_save, "Save warranty Details");
                e.Cancel = true;
                base.OnFormClosing(e);
            }
            else 
            {
                e.Cancel = false;
                base.OnFormClosing(e);
            }
        }

        private void txt_invoNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void txt_itmnme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void txt_serial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void txt_cusnnm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

       

        

       
    }
}
