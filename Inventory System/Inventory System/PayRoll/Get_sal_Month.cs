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
    public partial class Get_sal_Month : Form
    {
        public Get_sal_Month()
        {
            InitializeComponent();
        }

        Payroll_DB_Oparetion pay_op = new Payroll_DB_Oparetion();
        DateTime Now_dte;
        DataTable dtbl;

        decimal mon_sal, mon_tgt, arias, reminig, compt_tgt, net_sal, tot_sal, etra_com_tgt, tgt_rte, etra_sal, recevd_sal, rest_sal, additionl_sal;
        string now_yer, now_mon, invo_yer, invo_mon, recev_yer, recev_mon, DB_yer, DB_mon;
        DateTime invo_dte, receive_date;

       

        

        private void Get_sal_Month_Load(object sender, EventArgs e)
        {

           

            //_______________________________________________________________________________________________________________________________
            now_yer = DateTime.Today.Year.ToString();
            now_mon = DateTime.Today.Month.ToString();

            SqlDataReader tmpdr = pay_op.select_Temp_data();
            if (tmpdr.Read())
            {
                DB_yer = tmpdr["Year"].ToString();
                DB_mon = tmpdr["Month"].ToString();
                
            }

            //______________________________________________________________________________________________________________________________
           


            String sql = "SELECT*FROM tbl_UserAccount";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbx_usernn.Items.Add(ns.Rows[i]["User_Name"]);
            }

            DataSet rds = pay_op.Month_Receives_sal(now_yer,now_mon);
            dgv_get_Month.DataSource = rds.Tables["tbl_Salary_Received"];

            dgv_get_Month.Columns["User_Name"].Width = 140;
            dgv_get_Month.Columns["Received_Date"].Width = 200;
            dgv_get_Month.Columns["Received_Salary"].Width = 190;

            



        }

        private void cbx_usernn_SelectedIndexChanged(object sender, EventArgs e)
        {
            mon_sal = 0; mon_tgt = 0; arias = 0; reminig = 0; compt_tgt = 0; net_sal = 0; tot_sal = 0; etra_com_tgt = 0; tgt_rte = 0; etra_sal = 0; recevd_sal = 0; rest_sal = 0; additionl_sal = 0;
            invo_yer = ""; invo_mon = ""; recev_yer = ""; recev_mon = "";



            string sql = "SELECT * FROM tbl_Salary_Received WHERE Month='"+DB_mon+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_get_Month.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "User_Name like '%" + cbx_usernn.Text + "%' ";
            dgv_get_Month.DataSource = dv;


//______________________________________________________________________________________________________________________________
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            SqlDataReader htydr = pay_op.select_sal_tgt(cbx_usernn.Text);
            if (htydr.Read())
            {
                mon_sal = Convert.ToDecimal(htydr["Monthly_Salary"].ToString());
                mon_tgt = Convert.ToDecimal(htydr["Monthly_Trget"].ToString());

            }

            SqlDataReader blncdr = pay_op.select_sal_blnce(cbx_usernn.Text);
            if (blncdr.Read())
            {
                arias = Convert.ToDecimal(blncdr["Arrears"].ToString());
                reminig = Convert.ToDecimal(blncdr["Remaining"].ToString());
            }

            //____________________net month sal__________________________________________________________________________________________

            net_sal = (mon_sal + reminig) - arias;
            //___________________________________________________________________________________________________________________________





            //_______________________________________get completed target_________________________________________________________________

            String iisql = "SELECT Invoice_Date,Total_Price FROM tbl_Invoice WHERE Seals_ref='" + cbx_usernn.Text + "'";
            SqlDataAdapter iiget = new SqlDataAdapter(iisql, ConnectionDB.Connection());
            DataTable iins = new DataTable();
            iiget.Fill(iins);
            for (int ii = 0; ii < iins.Rows.Count; ii++)
            {
                decimal invo_tot = Convert.ToDecimal(iins.Rows[ii]["Total_Price"].ToString());
                invo_dte = Convert.ToDateTime(iins.Rows[ii]["Invoice_Date"].ToString());
                invo_yer = invo_dte.Year.ToString();
                invo_mon = invo_dte.Month.ToString();

                if (DB_yer == invo_yer && DB_mon == invo_mon)
                {
                    compt_tgt += invo_tot;
                }


            }

            //_____________________________________________________________________________________________________________________________



            //_____________________Extra completed_________________________________________________________________________________________

            if (compt_tgt > mon_tgt)
            {
                etra_com_tgt = compt_tgt - mon_tgt;

            }

            //_____________________________________________________________________________________________________________________________

            //_____________________Extra salary _________________________________________________________________________________________

            SqlDataReader rtedr = pay_op.select_tgt_rte(cbx_usernn.Text);
            if (rtedr.Read())
            {
                tgt_rte = Convert.ToDecimal(rtedr["Target_rate"].ToString());
            }



            etra_sal = Math.Round((etra_com_tgt / 100) * tgt_rte,2);



            //_____________________________________________________________________________________________________________________________

            //_____________________Total salary ___________________________________________________________________________________________
            tot_sal = net_sal + etra_sal;
            //_____________________________________________________________________________________________________________________________


            //_______________Received Salary_______________________________________________________________________________________________

            String siisql = "SELECT * FROM tbl_Salary_Received WHERE User_Name='" + cbx_usernn.Text + "'";
            SqlDataAdapter siiget = new SqlDataAdapter(siisql, ConnectionDB.Connection());
            DataTable siins = new DataTable();
            siiget.Fill(siins);
            for (int sii = 0; sii < siins.Rows.Count; sii++)
            {
                decimal recevid_tot = Convert.ToDecimal(siins.Rows[sii]["Received_Salary"].ToString());
                receive_date = Convert.ToDateTime(siins.Rows[sii]["Received_Date"].ToString());
                recev_yer = receive_date.Year.ToString();
                recev_mon = receive_date.Month.ToString();

                if (DB_yer == recev_yer && DB_mon == recev_mon)
                {
                    recevd_sal += recevid_tot;
                }


            }

            //_____________________________________________________________________________________________________________________________



            //______________________________Sal_rest_______________________________________________________________________________________

            if (recevd_sal <= tot_sal)
            {
                rest_sal = tot_sal - recevd_sal;
            }
            //_____________________________________________________________________________________________________________________________


            //______________________________Additional received_____________________________________________________________________________
            if (recevd_sal > tot_sal)
            {
                additionl_sal = recevd_sal - tot_sal;
            }
            //_____________________________________________________________________________________________________________________________



            lbl_tot_sal.Text = tot_sal.ToString();
            lbl_recevd_sal.Text = recevd_sal.ToString();
            lbl_sal_rest.Text = rest_sal.ToString();
            lbl_aditionl_reced.Text = additionl_sal.ToString();



//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//___________________________________________________________________________________________________________________________


        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (cbx_usernn.Text != "" && txt_getSal.Text!="")
            {


                try
                {
                    pay_op.Insert_Received_Salary(cbx_usernn.Text, Convert.ToDecimal(txt_getSal.Text), DateTime.Now, now_yer, now_mon);
                    MessageBox.Show("\"" + cbx_usernn.Text + "\"  Received \"Rs." + txt_getSal.Text + "\"" + " Sucessfully", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception) { }


                DataSet rds = pay_op.user_receved_sal(cbx_usernn.Text, now_yer, now_mon);
                dgv_get_Month.DataSource = rds.Tables["tbl_Salary_Received"];




                //______________________________________________________________________________________________________________________________
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


                mon_sal = 0; mon_tgt = 0; arias = 0; reminig = 0; compt_tgt = 0; net_sal = 0; tot_sal = 0; etra_com_tgt = 0; tgt_rte = 0; etra_sal = 0; recevd_sal = 0; rest_sal = 0; additionl_sal = 0;
                invo_yer = ""; invo_mon = ""; recev_yer = ""; recev_mon = "";


                SqlDataReader htydr = pay_op.select_sal_tgt(cbx_usernn.Text);
                if (htydr.Read())
                {
                    mon_sal = Convert.ToDecimal(htydr["Monthly_Salary"].ToString());
                    mon_tgt = Convert.ToDecimal(htydr["Monthly_Trget"].ToString());

                }

                SqlDataReader blncdr = pay_op.select_sal_blnce(cbx_usernn.Text);
                if (blncdr.Read())
                {
                    arias = Convert.ToDecimal(blncdr["Arrears"].ToString());
                    reminig = Convert.ToDecimal(blncdr["Remaining"].ToString());
                }

                //____________________net month sal__________________________________________________________________________________________

                net_sal = (mon_sal + reminig) - arias;
                //___________________________________________________________________________________________________________________________





                //_______________________________________get completed target_________________________________________________________________

                String iisql = "SELECT Invoice_Date,Total_Price FROM tbl_Invoice WHERE Seals_ref='" + cbx_usernn.Text + "'";
                SqlDataAdapter iiget = new SqlDataAdapter(iisql, ConnectionDB.Connection());
                DataTable iins = new DataTable();
                iiget.Fill(iins);
                for (int ii = 0; ii < iins.Rows.Count; ii++)
                {
                    decimal invo_tot = Convert.ToDecimal(iins.Rows[ii]["Total_Price"].ToString());
                    invo_dte = Convert.ToDateTime(iins.Rows[ii]["Invoice_Date"].ToString());
                    invo_yer = invo_dte.Year.ToString();
                    invo_mon = invo_dte.Month.ToString();

                    if (DB_yer == invo_yer && DB_mon == invo_mon)
                    {
                        compt_tgt += invo_tot;
                    }


                }

                //_____________________________________________________________________________________________________________________________



                //_____________________Extra completed_________________________________________________________________________________________

                if (compt_tgt > mon_tgt)
                {
                    etra_com_tgt = compt_tgt - mon_tgt;

                }

                //_____________________________________________________________________________________________________________________________

                //_____________________Extra salary _________________________________________________________________________________________

                SqlDataReader rtedr = pay_op.select_tgt_rte(cbx_usernn.Text);
                if (rtedr.Read())
                {
                    tgt_rte = Convert.ToDecimal(rtedr["Target_rate"].ToString());
                }



                etra_sal = (Math.Round(etra_com_tgt) / 100) * tgt_rte;



                //_____________________________________________________________________________________________________________________________

                //_____________________Total salary ___________________________________________________________________________________________
                tot_sal = net_sal + etra_sal;
                //_____________________________________________________________________________________________________________________________


                //_______________Received Salary_______________________________________________________________________________________________

                String siisql = "SELECT * FROM tbl_Salary_Received WHERE User_Name='" + cbx_usernn.Text + "'";
                SqlDataAdapter siiget = new SqlDataAdapter(siisql, ConnectionDB.Connection());
                DataTable siins = new DataTable();
                siiget.Fill(siins);
                for (int sii = 0; sii < siins.Rows.Count; sii++)
                {
                    decimal recevid_tot = Convert.ToDecimal(siins.Rows[sii]["Received_Salary"].ToString());
                    receive_date = Convert.ToDateTime(siins.Rows[sii]["Received_Date"].ToString());
                    recev_yer = receive_date.Year.ToString();
                    recev_mon = receive_date.Month.ToString();

                    if (DB_yer == recev_yer && DB_mon == recev_mon)
                    {
                        recevd_sal += recevid_tot;
                    }


                }

                //_____________________________________________________________________________________________________________________________



                //______________________________Sal_rest_______________________________________________________________________________________

                if (recevd_sal <= tot_sal)
                {
                    rest_sal = tot_sal - recevd_sal;
                }
                //_____________________________________________________________________________________________________________________________


                //______________________________Additional received_____________________________________________________________________________
                if (recevd_sal > tot_sal)
                {
                    additionl_sal = recevd_sal - tot_sal;
                }
                //_____________________________________________________________________________________________________________________________



                lbl_tot_sal.Text = tot_sal.ToString();
                lbl_recevd_sal.Text = recevd_sal.ToString();
                lbl_sal_rest.Text = rest_sal.ToString();
                lbl_aditionl_reced.Text = additionl_sal.ToString();



                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //___________________________________________________________________________________________________________________________


                txt_getSal.Clear();

            }
            else 
            {
                if (cbx_usernn.Text == "") { toolTip1.Show("Select User name", cbx_usernn, 1000); }
                if (txt_getSal.Text == "") { toolTip2.Show("Enter Value", txt_getSal, 1000); }
                
                
            }



        }

        private void txt_getSal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 127))
            {
                e.Handled = true;
                toolTip_sal.Show("Invalid Value", txt_getSal, 0, -50, 2000);
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

       
        

        


    }
}
