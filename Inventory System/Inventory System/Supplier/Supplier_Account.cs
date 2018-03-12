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
    public partial class Supplier_Account : Form
    {
        Sup_account_get gc;
        public Supplier_Account(Sup_account_get accD)
        {
            InitializeComponent();
            gc = accD;
        }

        Supplier_DB_Operetion supOp = new Supplier_DB_Operetion();
        DataTable dtbl;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblBlance_Click(object sender, EventArgs e)
        {

        }

       
        private void Supplier_Account_Load(object sender, EventArgs e)
        {
            string fn = gc.sp_acFnme;
            string lm = gc.sp_acLnme;
            string nm = fn + " " + lm;

            lblSupNo.Text = gc.sp_acNo;
            lblSupName.Text = nm;
            lblSupBusName.Text = gc.sp_acBisnme;
            lblSupMob.Text = gc.sp_acMob;
            lblSupEmail.Text = gc.sp_acemail;



            DataSet ds = supOp.each_sup_stock(lblSupBusName.Text);
            dgv_sup_acc.DataSource = ds.Tables["tbl_Recive_Stock"];

            //dgv_sup_acc.Columns[2].Width = 350;






        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                SupAcc_update sAccUp = new SupAcc_update();
                sAccUp.stNo = dgv_sup_acc.CurrentRow.Cells["Stock_No"].Value.ToString();
                sAccUp.stDate = dgv_sup_acc.CurrentRow.Cells["Recive_date"].Value.ToString();
                sAccUp.st_descrip = dgv_sup_acc.CurrentRow.Cells["Discription"].Value.ToString();
                sAccUp.stSup = dgv_sup_acc.CurrentRow.Cells["Supplier"].Value.ToString();
                sAccUp.purchPriz = dgv_sup_acc.CurrentRow.Cells["Purchase_Price"].Value.ToString();
                sAccUp.paid = dgv_sup_acc.CurrentRow.Cells["Payment"].Value.ToString();
                sAccUp.payMethd = dgv_sup_acc.CurrentRow.Cells["payment_Method"].Value.ToString();
                sAccUp.nme = dgv_sup_acc.CurrentRow.Cells["Item_Name"].Value.ToString();
                sAccUp.catgy = dgv_sup_acc.CurrentRow.Cells["Catogory"].Value.ToString();
                sAccUp.subcgy = dgv_sup_acc.CurrentRow.Cells["Sub_Catogory"].Value.ToString();
                sAccUp.brand = dgv_sup_acc.CurrentRow.Cells["Brande"].Value.ToString();
                sAccUp.qqty = dgv_sup_acc.CurrentRow.Cells["Quntity"].Value.ToString();
                sAccUp.un_piz = dgv_sup_acc.CurrentRow.Cells["Unit_purchas_price"].Value.ToString();
                sAccUp.un_sal = dgv_sup_acc.CurrentRow.Cells["Unit_sale_price"].Value.ToString();
                sAccUp.styp = dgv_sup_acc.CurrentRow.Cells["Stock_type"].Value.ToString();
                sAccUp.itype = dgv_sup_acc.CurrentRow.Cells["Item_Type"].Value.ToString();

                this.Visible = false;
                Edit_Receive_Stock stockEdit = new Edit_Receive_Stock(sAccUp);
                stockEdit.ShowDialog(this);
            }

            catch (Exception)
            { 
                //MessageBox.Show("This Supplier No Add Stock"); 
                toolTip1.Show("This Supplier No Add Stock",groupBox2 , 3000);
            }
            

           
        }

        private void txtStrockNo_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Recive_Stock WHERE Supplier='" + lblSupBusName.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_sup_acc.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Stock_No like '%" + txtStrockNo.Text + "%' ";
            dgv_sup_acc.DataSource = dv;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Recive_Stock WHERE Supplier='" + lblSupBusName.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_sup_acc.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Discription like '%" + txt_descipt.Text + "%' ";
            dgv_sup_acc.DataSource = dv;

        }

        private void dgv_sup_acc_Click(object sender, EventArgs e)
        {
            


        }

        private void dgv_sup_acc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                lblTotPrice.Text = "";
                lblPaid.Text = "";
                lblBlance.Text = "";

                if (dgv_sup_acc.CurrentRow.Cells["Purchase_Price"].Value.ToString() != "" && dgv_sup_acc.CurrentRow.Cells["Payment"].Value.ToString() != "")
                {


                    string tot, paid, balnce;
                    decimal tot1, paid1, balnce1;
                    tot = dgv_sup_acc.CurrentRow.Cells["Purchase_Price"].Value.ToString();
                    paid = dgv_sup_acc.CurrentRow.Cells["Payment"].Value.ToString();
                    tot1 = decimal.Parse(tot);
                    paid1 = decimal.Parse(paid);
                    balnce1 = (tot1 - paid1);
                    balnce = balnce1.ToString();



                    lblTotPrice.Text = "Rs : " + tot;
                    lblPaid.Text = "Rs : " + paid;
                    lblBlance.Text = "Rs : " + balnce;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStrockNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void txt_descipt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            } 
        }

        private void cbxView_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxView_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        
        

        
        
       
       
    }
}
