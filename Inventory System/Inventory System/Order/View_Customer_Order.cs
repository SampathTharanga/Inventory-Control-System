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
    public partial class View_Customer_Order : Form
    {
        public View_Customer_Order()
        {
            InitializeComponent();
        }
        DataTable dtbl;
        Order_DB_Operetion odr = new Order_DB_Operetion();

        private void View_Customer_Order_Load(object sender, EventArgs e)
        {
          DataSet ds = odr.all();
          dataGridView1.DataSource = ds.Tables["tbl_Customer_Order"];

          dataGridView1.Columns[4].Width = 250;

          string sql = "SELECT * FROM tbl_Customer_Order";
          SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
          dtbl = new DataTable();
          da.Fill(dtbl);
          BindingSource bnsue = new BindingSource();
          bnsue.DataSource = dtbl;
          dataGridView1.DataSource = bnsue;
          da.Update(dtbl);

        }
        string custo;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            

            if (txtOrdorNo.Text != "")
            {
                custo = txtOrdorNo.Text;
            }
            if (txtName.Text != "")
            {
                custo = txtName.Text;
            }
            if (txtMobile.Text != "")
            {
                custo = txtMobile.Text;
            }
            
                        
            DataSet ds = odr.SelectCusOrder(custo);
           

            dataGridView1.DataSource = ds.Tables["tbl_Customer_Order"];
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Delete Customer Order " + dataGridView1.CurrentRow.Cells[0].Value.ToString(), "Delete Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    odr.delete(dataGridView1.CurrentRow.Cells["Order_No"].Value.ToString());
                    MessageBox.Show("Order removed successfuly","Sharp Creatios",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception) { }


        }
       




        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Cusdata_update odrupdte = new Cusdata_update();
                odrupdte.odrno = dataGridView1.CurrentRow.Cells["Order_No"].Value.ToString();
                odrupdte.oName = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                odrupdte.odate = dataGridView1.CurrentRow.Cells["Date"].Value.ToString();
                odrupdte.omobile = dataGridView1.CurrentRow.Cells["Mobile"].Value.ToString();
                odrupdte.oDiscrip = dataGridView1.CurrentRow.Cells["Discription"].Value.ToString();

                updte_cus_order ucodr = new updte_cus_order(odrupdte);
                ucodr.ShowDialog(this);
            }
            catch (Exception) { }


        }

        

        private void txtOrdorNo_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Order_No like '%" + txtOrdorNo.Text + "%'";
            dataGridView1.DataSource = dv;
                

            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Name like '%" + txtName.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Mobile like '%" + txtMobile.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            } 
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            } 
        }

        private void txtOrdorNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            } 
        }
    }
}
