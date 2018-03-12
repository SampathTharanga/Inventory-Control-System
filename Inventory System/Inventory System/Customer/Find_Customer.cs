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
    public partial class Find_Customer : Form
    {
        DataView viewcus = new DataView();
        public Find_Customer()
        {
            InitializeComponent();
        }

       

        DataSet ds;
        DataTable dtbl;
       
        Customer_DB_Operation cusop = new Customer_DB_Operation();


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        string custo;
        private void btnFindCustoSearch_Click(object sender, EventArgs e)
        {
             
           
            if (txtFindCustoCustoNo.Text != "")
            {
                custo = txtFindCustoCustoNo.Text;
            }
            else if (txtFindCustoFirstName.Text != "")
            {
                custo = txtFindCustoFirstName.Text;
            }
            else if (txtFindCustoLastName.Text != "")
            {
                custo = txtFindCustoLastName.Text;
            }
            else if (txtFindCusto4n.Text != "")
            {
                custo = txtFindCusto4n.Text;
            }

            else { }



            DataSet ds = cusop.SelectCus(custo);

            dgvFindCusto.DataSource = ds.Tables["tbl_Add_Customer"];

            
            

            
        }




        private void btnFindCustoAddItem_Click(object sender, EventArgs e)
        {
            Main.p1.Controls.Clear();
            Add_customer adcus = new Add_customer();
            adcus.TopLevel = false;
            adcus.Visible = true;
            Main.p1.Controls.Add(adcus);

        }

        private void Find_Customer_Load(object sender, EventArgs e)
        {
           
            ds = cusop.all();
            dgvFindCusto.DataSource=ds.Tables["tbl_Add_Customer"];

            string sql = "SELECT * FROM tbl_Add_Customer";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgvFindCusto.DataSource = bnsue;
            da.Update(dtbl);

        }

       

       

          

       
        

        private void btnFindCustoEditItem_Click(object sender, EventArgs e)
        {
            try
            {
                cusDupdate cusData = new cusDupdate();
                cusData.no = dgvFindCusto.CurrentRow.Cells["Coustomer_No"].Value.ToString();
                cusData.Fname = dgvFindCusto.CurrentRow.Cells["First_Name"].Value.ToString();
                cusData.lname = dgvFindCusto.CurrentRow.Cells["Last_Name"].Value.ToString();
                cusData.bisname = dgvFindCusto.CurrentRow.Cells["Bussiness_Name"].Value.ToString();
                cusData.add1 = dgvFindCusto.CurrentRow.Cells["Address_Line1"].Value.ToString();
                cusData.add2 = dgvFindCusto.CurrentRow.Cells["Address_Line2"].Value.ToString();
                cusData.city = dgvFindCusto.CurrentRow.Cells["City"].Value.ToString();
                cusData.zip = dgvFindCusto.CurrentRow.Cells["Zip_Postal_Code"].Value.ToString();
                cusData.phone = dgvFindCusto.CurrentRow.Cells["Phone"].Value.ToString();
                cusData.mobil = dgvFindCusto.CurrentRow.Cells["Mobile"].Value.ToString();
                cusData.fax = dgvFindCusto.CurrentRow.Cells["Fax"].Value.ToString();
                cusData.discount = dgvFindCusto.CurrentRow.Cells["Discount"].Value.ToString();
                cusData.email = dgvFindCusto.CurrentRow.Cells["Email"].Value.ToString();
                cusData.notes = dgvFindCusto.CurrentRow.Cells["Notes"].Value.ToString();



                Edit_Customer ccc = new Edit_Customer(cusData);
                ccc.ShowDialog(this);
            }
            catch (Exception) { }



        }

        private void btnFindCustoDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                /* if(dgvFindCusto.SelectedRows.Count>0)
                 {
                     int SelectedIndex = dgvFindCusto.SelectedRows[0].Index;
                     int cusNo = int.Parse(dgvFindCusto[0, SelectedIndex].Value.ToString());*/
                if (MessageBox.Show("Delete Customer " + dgvFindCusto.CurrentRow.Cells[1].Value.ToString() + " " + dgvFindCusto.CurrentRow.Cells[2].Value.ToString(), "Sharp Creation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    cusop.delete(dgvFindCusto.CurrentRow.Cells["Coustomer_No"].Value.ToString());
                    MessageBox.Show("Customer removed sucessfully", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Main.p1.Controls.Clear();
                Find_Customer finCus = new Find_Customer();
                finCus.TopLevel = false;
                finCus.Visible = true;
                Main.p1.Controls.Add(finCus);
            }
            catch (Exception) { }
        }

        private void btnFindCustoReset_Click(object sender, EventArgs e)
        {
            //------------clear all textbox.text-----------------
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

       

        private void txtFindCustoCustoNo_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Coustomer_No like '%" + txtFindCustoCustoNo.Text + "%' ";
            dgvFindCusto.DataSource = dv;
        }

        private void txtFindCustoFirstName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbl);
            dv.RowFilter = "First_Name like '%" + txtFindCustoFirstName.Text + "%'";
            dgvFindCusto.DataSource = dv;
        }

        private void txtFindCustoLastName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Last_Name like '%" + txtFindCustoLastName.Text + "%'";
            dgvFindCusto.DataSource = dv;
        }

        private void txtFindCusto4n_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Mobile like '%" + txtFindCusto4n.Text + "%'";
            dgvFindCusto.DataSource = dv;
        }

        private void txtFindCustoCustoNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void txtFindCustoLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void txtFindCustoFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void txtFindCusto4n_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void btnFindCustoReset_Click_1(object sender, EventArgs e)
        {
            //------------clear all textbox.text-----------------
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


       
        
       


    }
}
