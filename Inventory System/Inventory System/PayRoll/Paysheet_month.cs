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
    public partial class Paysheet_month : Form
    {
        public Paysheet_month()
        {
            InitializeComponent();
        }


        Payroll_DB_Oparetion pay_op = new Payroll_DB_Oparetion();
        DataTable dtbl;
        decimal mon_sal, mon_tgt, arias, reminig, compt_tgt, net_sal, tot_sal, etra_com_tgt, tgt_rte, etra_sal, recevd_sal, rest_sal, additionl_sal;
        string now_yer, now_mon, invo_yer, invo_mon, recev_yer, recev_mon, DB_yer, DB_mon;
        DateTime invo_dte, receive_date;

        
        

        private void Paysheet_month_Load(object sender, EventArgs e)
        {
            now_yer = DateTime.Today.Year.ToString();
            now_mon = DateTime.Today.Month.ToString();

            SqlDataReader tmpdr = pay_op.select_Temp_data();
            if (tmpdr.Read())
            {
                DB_yer = tmpdr["Year"].ToString();
                DB_mon = tmpdr["Month"].ToString();

            }


           
            Month_payroll.lbl.Text = now_yer + " / " + now_mon + " Payroll Details";

            String sql = "SELECT*FROM tbl_UserAccount";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbx_usernn.Items.Add(ns.Rows[i]["User_Name"]);
            }

            if (Main.UT1 == "Standard User" || Main.UT1 == "Administrator")
            {
                btn_mon_sal.Enabled = false;
                btn_getSal.Enabled = false;
                btn_mon_tgt.Enabled = false;
                btn_payrolDetails.Enabled = false;
                button3.Enabled = false; 
            }
        }

        private void cbx_usernn_SelectedIndexChanged(object sender, EventArgs e)
        {
            mon_sal = 0; mon_tgt = 0; arias = 0; reminig = 0; compt_tgt = 0; net_sal = 0; tot_sal = 0; etra_com_tgt = 0; tgt_rte = 0; etra_sal = 0; recevd_sal = 0; rest_sal = 0; additionl_sal = 0;
            invo_yer = ""; invo_mon = ""; recev_yer = ""; recev_mon = "";

            SqlDataReader usdr = pay_op.select_User_Acc(cbx_usernn.Text);
            if (usdr.Read())
            {
                lbl_fulnm.Text = usdr["First_Name"].ToString() + " " + usdr["Last_Name"].ToString() + " , " + usdr["Address_Line1"].ToString() + " " + usdr["Address_Line2"].ToString(); ;
                
            }

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

            net_sal = (mon_sal + reminig )- arias;
//___________________________________________________________________________________________________________________________


           


//_______________________________________get completed target_________________________________________________________________

            String iisql = "SELECT Invoice_Date,Total_Price FROM tbl_Invoice WHERE Seals_ref='" + cbx_usernn.Text + "'";
            SqlDataAdapter iiget = new SqlDataAdapter(iisql, ConnectionDB.Connection());
            DataTable iins = new DataTable();
            iiget.Fill(iins);
            for (int ii = 0; ii < iins.Rows.Count; ii++)
            {
                decimal invo_tot =Convert.ToDecimal(iins.Rows[ii]["Total_Price"].ToString());
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

            //________________________Lable Display_________________________________________________________________________________________

            lbl_mon_sal.Text = mon_sal.ToString();
            lbl_mon_tgt.Text = mon_tgt.ToString();
            lbl_reming.Text = reminig.ToString();
            lbl_arias.Text = arias.ToString();
            lbl_net_sal.Text = net_sal.ToString();
            lbl_com_tgt.Text = compt_tgt.ToString();
            lbl_extr_com_tgt.Text = etra_com_tgt.ToString();
            lbl_etra_sal.Text = etra_sal.ToString();
            lbl_tot_sal.Text = tot_sal.ToString();
            lbl_totsal1.Text = tot_sal.ToString();
            lbl_recevd_sal.Text = recevd_sal.ToString();
            lbl_sal_rest.Text = rest_sal.ToString();
            lbl_aditionl_receved.Text = additionl_sal.ToString();

            //_____________________________________________________________________________________________________________________________






        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tget_settings ttget = new Tget_settings();
            ttget.ShowDialog();
        }

        private void lbl_mon_sal_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btn_mon_sal_Click(object sender, EventArgs e)
        {
            Set_ref_salary_taget refsal = new Set_ref_salary_taget();
            refsal.ShowDialog();
        }

        private void btn_mon_tgt_Click(object sender, EventArgs e)
        {
            Set_ref_salary_taget refsal = new Set_ref_salary_taget();
            refsal.ShowDialog();
        }

        private void btn_getSal_Click(object sender, EventArgs e)
        {
            Main.p1.Controls.Clear();
            Get_Sallery View_pay = new Get_Sallery();
            View_pay.TopLevel = false;
            View_pay.Visible = true;
            Main.p1.Controls.Add(View_pay);
        }

        private void btn_payrolDetails_Click(object sender, EventArgs e)
        {
            Month_payroll.ppl.Controls.Clear();
            paysheet_histry View_pay = new paysheet_histry();
            View_pay.TopLevel = false;
            View_pay.Visible = true;
            Month_payroll.ppl.Controls.Add(View_pay);
        }

       

        

       
    }
}
