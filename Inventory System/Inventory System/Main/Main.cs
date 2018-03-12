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
    public partial class Main : Form
    {
        public static string un, UT1;

        public Main(string val,string UserVal)
        {
            InitializeComponent();
            un = val;
            UT1 = UserVal;
        }

        public static Panel p1 = new Panel();
        public static bool firstlod;
        public static bool admin_details;
        public static bool opsity=false;

        int cNo;

        Parse_UserAcc_Details op = new Parse_UserAcc_Details();
        Item_DB_Operation itemdb = new Item_DB_Operation();
        Customer_DB_Operation NoAuto = new Customer_DB_Operation();
        Payroll_DB_Oparetion pay_op = new Payroll_DB_Oparetion();
        User_acc_DB_Operations op2 = new User_acc_DB_Operations();


        decimal mon_sal, mon_tgt, arias, reminig, compt_tgt, net_sal, tot_sal, etra_com_tgt, tgt_rte, etra_sal, recevd_sal, rest_sal, additionl_sal;
        string now_yer, now_mon, invo_yer, invo_mon, recev_yer, recev_mon, DB_yer, DB_mon;
        DateTime invo_dte, receive_date;
        string own_un;
        string Bpth,Rpth;
        public static bool logut,rstor; 

       // public static ToolStripMenuItem rpottt = new ToolStripMenuItem();

        private void Main_Load(object sender, EventArgs e)
        {
            

             logut = false;  rstor = false;



//--------------------------------Close Log_main-----------------------------------//
            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                if (Application.OpenForms[1].Name == "Log_main")
                {
                    Application.OpenForms[1].Close();
                }
            }
//---------------------------------------------------------------------------------//
            SqlDataReader owndr = op2.select_owner();
            if (owndr.Read())
            {
               own_un = owndr["User_Name"].ToString();
               if (un == own_un)
               {

                   notifyIcon2.Icon = SystemIcons.Information;
                   notifyIcon2.Visible = true;
                   notifyIcon2.ShowBalloonTip(2000, "Owner Account", "Welcome to Mars ComputerSystem", ToolTipIcon.Info);
               }
                
            }
            
            


            if (UT1 == "Administrator")
            {
                salaryAndTargrtToolStripMenuItem.Enabled = false;
                receivedSalaryToolStripMenuItem.Enabled = false;
                ownerAccountToolStripMenuItem.Enabled = false;
                //backupDatabaseToolStripMenuItem.Enabled = false;
                //restorDatabaseToolStripMenuItem.Enabled = false;


            }
            if (UT1 == "Standard User")
            {
                reportsToolStripMenuItem.Enabled = false;
                payrollToolStripMenuItem.Enabled = false;
                employersToolStripMenuItem.Enabled = false;
                toolStripSplitButton_prol.Enabled = false;
                toolStripButton9.Enabled = false;
                backupDatabaseToolStripMenuItem.Enabled = false;
                restorDatabaseToolStripMenuItem.Enabled = false;




            }

            panelMain.Controls.Clear();
            New_invoice addinvoice = new New_invoice(un, UT1);
            addinvoice.TopLevel = false;
            addinvoice.Visible = true;
            panelMain.Controls.Add(addinvoice);
            p1 = panelMain;



            firstlod = true;

            now_yer = DateTime.Today.Year.ToString();
            now_mon = DateTime.Today.Month.ToString();



            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++check temp Table is Null++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//
            String emty = "SELECT*FROM tbl_Salary_Temp";
            SqlDataAdapter iigemty = new SqlDataAdapter(emty, ConnectionDB.Connection());
            DataTable iemty = new DataTable();
            iigemty.Fill(iemty);
            if (0 == iemty.Rows.Count) // does not exist
            {

                pay_op.Insert_Temp_data(now_yer, now_mon);


            }

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            SqlDataReader tmpdr = pay_op.select_Temp_data();
            if (tmpdr.Read())
            {
                DB_yer = tmpdr["Year"].ToString();
                DB_mon = tmpdr["Month"].ToString();

            }

            if (DB_yer != now_yer || DB_mon != now_mon)
            {
                if (Convert.ToDouble(DB_yer) < Convert.ToDouble(now_yer) || Convert.ToDouble(DB_mon) < Convert.ToDouble(now_mon))
                {

                    if (MessageBox.Show("Accoding System Date Time This Is A New Month \nIf You Sure System Date time Correct Press \"OK\" To Complete Old Month Payroll Details", "Sharp Creation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        //=+=+=+=+=+=+=+=+=  Update payroll  +=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=


                        String sql = "SELECT*FROM tbl_UserAccount";
                        SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
                        DataTable ns = new DataTable();
                        get.Fill(ns);
                        for (int i = 0; i < ns.Rows.Count; i++)
                        {
                            string unme = ns.Rows[i]["User_Name"].ToString();
                            // MessageBox.Show(unme);


                            mon_sal = 0; mon_tgt = 0; arias = 0; reminig = 0; compt_tgt = 0; net_sal = 0; tot_sal = 0; etra_com_tgt = 0; tgt_rte = 0; etra_sal = 0; recevd_sal = 0; rest_sal = 0; additionl_sal = 0;
                            invo_yer = ""; invo_mon = ""; recev_yer = ""; recev_mon = "";

                            SqlDataReader htydr = pay_op.select_sal_tgt(unme);
                            if (htydr.Read())
                            {
                                mon_sal = Convert.ToDecimal(htydr["Monthly_Salary"].ToString());
                                mon_tgt = Convert.ToDecimal(htydr["Monthly_Trget"].ToString());

                            }

                            SqlDataReader blncdr = pay_op.select_sal_blnce(unme);
                            if (blncdr.Read())
                            {
                                arias = Convert.ToDecimal(blncdr["Arrears"].ToString());
                                reminig = Convert.ToDecimal(blncdr["Remaining"].ToString());
                            }

                            //____________________net month sal__________________________________________________________________________________________

                            net_sal = (mon_sal + reminig) - arias;
                            //___________________________________________________________________________________________________________________________

                            //_______________________________________get completed target_________________________________________________________________

                            String iisql = "SELECT Invoice_Date,Total_Price FROM tbl_Invoice WHERE Seals_ref='" + unme + "'";
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

                            SqlDataReader rtedr = pay_op.select_tgt_rte(unme);
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

                            String siisql = "SELECT * FROM tbl_Salary_Received WHERE User_Name='" + unme + "'";
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


                            //_________________________Insert sal Histry___________________________________________________________________________________
                            try
                            {
                                pay_op.Insert_sal_history(unme, DB_yer, DB_mon, mon_sal, arias, reminig, net_sal, mon_tgt, compt_tgt, etra_com_tgt, etra_sal, tot_sal, recevd_sal, additionl_sal, rest_sal);
                            }
                            catch (Exception) { }



                            //_____________________________________________________________________________________________________________________________

                            //_________________________Update sal Balance___________________________________________________________________________________
                            try
                            {
                                pay_op.Update_sal_blnce(unme, additionl_sal, rest_sal);
                            }
                            catch (Exception) { }
                            //_____________________________________________________________________________________________________________________________


                        }

                        //______________________Update temp data_______________________________________________________________________________________
                        try
                        {
                            pay_op.Update_temp_data(now_yer, now_mon);
                        }
                        catch (Exception) { }

                        //______________________________________________________________________________________________________________________________


                        //=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=
                        notifyIcon1.Icon = SystemIcons.Information;
                        notifyIcon1.Visible = true;
                        notifyIcon1.ShowBalloonTip(2000, "Sharp Creation", "\"" + DB_yer + " / " + DB_mon + " \"  Payroll Details Completed Sucessfully.\nAnd Start New Payroll " + "\"" + now_yer + " / " + now_mon + " \"", ToolTipIcon.Info);


                    }
                }
                else { MessageBox.Show("Your System Date is Wrong","Sharp Creatuon",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
                
            }


           // rpottt = reportsToolStripMenuItem;

            logoutToolStripMenuItem.Font = new Font(Font, Font.Style | FontStyle.Regular);


            
        }

        

        private void newInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            New_invoice addinvoice = new New_invoice(un, UT1);
            addinvoice.TopLevel = false;
            addinvoice.Visible = true;
            panelMain.Controls.Add(addinvoice);
            New_invoice.tx_bcrd.Focus();
        }

       

        private void findItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Find_item finditm = new Find_item();
            finditm.TopLevel = false;
            finditm.Visible = true;
            panelMain.Controls.Add(finditm);
            Find_item.tx_bcde.Focus();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            New_invoice addinvoice = new New_invoice(un, UT1);
            addinvoice.TopLevel = false;
            addinvoice.Visible = true;
            panelMain.Controls.Add(addinvoice);
            New_invoice.tx_bcrd.Focus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Add_Items Itadd = new Add_Items();
            Itadd.TopLevel = false;
            Itadd.Visible = true;
            panelMain.Controls.Add(Itadd);
            Add_Items.tx_brcde.Focus();




        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Find_item finditm = new Find_item();
            finditm.TopLevel = false;
            finditm.Visible = true;
            panelMain.Controls.Add(finditm);
            Find_item.tx_bcde.Focus();
        }

        private void findItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Find_item finditm = new Find_item();
            finditm.TopLevel = false;
            finditm.Visible = true;
            panelMain.Controls.Add(finditm);
        }

        private void toolStripButton10_ButtonClick(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Find_item finditm = new Find_item();
            finditm.TopLevel = false;
            finditm.Visible = true;
            panelMain.Controls.Add(finditm);
        }

        private void findInvoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Find_Invoice invofind = new Find_Invoice();
            invofind.TopLevel = false;
            invofind.Visible = true;
            panelMain.Controls.Add(invofind);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Add_customer AddCust = new Add_customer();
            AddCust.TopLevel = false;
            AddCust.Visible = true;
            panelMain.Controls.Add(AddCust);
            Add_customer.tx_fnmc.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Find_Invoice invofind = new Find_Invoice();
            invofind.TopLevel = false;
            invofind.Visible = true;
            panelMain.Controls.Add(invofind);
            Find_Invoice.dgvf.Columns["Description"].Width = 250;

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Add_Supplier AddSup = new Add_Supplier();
            AddSup.TopLevel = false;
            AddSup.Visible = true;
            panelMain.Controls.Add(AddSup);
            Add_Supplier.tx_fnnms.Focus();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Find_Customer FindCous = new Find_Customer();
            FindCous.TopLevel = false;
            FindCous.Visible = true;
            panelMain.Controls.Add(FindCous);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            View_Suppliers ViewSup = new View_Suppliers();
            ViewSup.TopLevel = false;
            ViewSup.Visible = true;
            panelMain.Controls.Add(ViewSup);


        }

        private void findCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Find_Customer FindCous = new Find_Customer();
            FindCous.TopLevel = false;
            FindCous.Visible = true;
            panelMain.Controls.Add(FindCous);
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_MouseEnter(object sender, EventArgs e)
        {
            toolStripButton1.Image = Properties.Resources._1_new_invoice;
        }

        private void toolStripButton1_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton1.Image = Properties.Resources._1_new_invoice1;
        }

        private void toolStripButton2_MouseEnter(object sender, EventArgs e)
        {
            toolStripButton2.Image = Properties.Resources._2_invoice;
        }

        private void toolStripButton2_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton2.Image = Properties.Resources._2_invoice1;
        }

        private void toolStripButton3_MouseEnter(object sender, EventArgs e)
        {
            toolStripButton3.Image = Properties.Resources._3_new_inventory;
        }

        private void toolStripButton3_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton3.Image = Properties.Resources._3_new_inventory1;
        }

        private void toolStripButton4_MouseEnter(object sender, EventArgs e)
        {
            toolStripButton4.Image = Properties.Resources._4_inventory;
        }

        private void toolStripButton4_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton4.Image = Properties.Resources._4_inventory1;
        }

        private void toolStripButton5_MouseEnter(object sender, EventArgs e)
        {
            toolStripButton5.Image = Properties.Resources._6_add_customer;
        }

        private void toolStripButton5_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton5.Image = Properties.Resources._6_add_customer1;
        }

        private void toolStripButton6_MouseEnter(object sender, EventArgs e)
        {
            toolStripButton6.Image = Properties.Resources._5_customer;
        }

        private void toolStripButton6_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton6.Image = Properties.Resources._5_customer1;
        }

        private void toolStripButton8_MouseEnter(object sender, EventArgs e)
        {
            toolStripButton8.Image = Properties.Resources._8_add_vendor;
        }

        private void toolStripButton8_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton8.Image = Properties.Resources._8_add_vendor1;
        }

        private void toolStripButton7_MouseEnter(object sender, EventArgs e)
        {
            toolStripButton7.Image = Properties.Resources._7_vendor;
        }

        private void toolStripButton7_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton7.Image = Properties.Resources._7_vendor1;
        }

       /* private void toolStripButton10_MouseEnter(object sender, EventArgs e)
        {
            toolStripButton10.Image = Properties.Resources._10_find_item;
        }

        private void toolStripButton10_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton10.Image = Properties.Resources._10_find_item1;
        }*/

        private void toolStripButton9_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton9_MouseEnter(object sender, EventArgs e)
        {
            toolStripButton9.Image = Properties.Resources._9_report;
        }

        private void toolStripButton9_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton9.Image = Properties.Resources._9_report1;
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Customer_order AddCusOrder = new Add_Customer_order();
            AddCusOrder.ShowDialog();
        }

        private void addReciveOrderStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Receive_Strock AddResStok = new Add_Receive_Strock();
            AddResStok.ShowDialog();
        }

        private void addRequstOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Request_Order ReqOr = new Request_Order();
            ReqOr.ShowDialog();
        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Customer_Order ViewCosOrd = new View_Customer_Order();
            ViewCosOrd.ShowDialog();
        }

        private void viewRequstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Requst_Order ViewReqOdr = new View_Requst_Order();
            ViewReqOdr.ShowDialog();
        }

        private void receiveStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Receive_Strock AddResStok = new Add_Receive_Strock();
            AddResStok.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkWarrantyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Warranty adawrty = new Add_Warranty();
            adawrty.ShowDialog();
            Add_Warranty.tx_bcds.Focus();
        }

        private void viewWarrantyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Warranty_Details wtydel = new Warranty_Details();
            wtydel.ShowDialog();
        }

        private void addDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Item_Details itdl = new Item_Details();
            itdl.ShowDialog();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Item_details mitdl = new Manage_Item_details();
            mitdl.ShowDialog();
        }


        
           
        
        private void toolStripButton9_ButtonClick(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Report_main View_rpt = new Report_main();
            View_rpt.TopLevel = false;
            View_rpt.Visible = true;
            panelMain.Controls.Add(View_rpt);
        }

       

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Details op3 = new User_Details();
            op3.ShowDialog();

        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Account op4 = new User_Account();
            op4.ShowDialog();

        }

        private void toolStripSplitButton_prol_ButtonClick(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Month_payroll View_pay = new Month_payroll();
            View_pay.TopLevel = false;
            View_pay.Visible = true;
            panelMain.Controls.Add(View_pay);
        }

        private void toolStripSplitButton_prol_MouseEnter(object sender, EventArgs e)
        {
            toolStripSplitButton_prol.Image = Properties.Resources.payRool1;
        }

        private void toolStripSplitButton_prol_MouseLeave(object sender, EventArgs e)
        {
            toolStripSplitButton_prol.Image = Properties.Resources.payRool2;
        }

        private void saleryAndTargetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_ref_salary_taget refsal = new Set_ref_salary_taget();
            refsal.ShowDialog();
        }

        private void getSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Get_Sallery View_pay = new Get_Sallery();
            View_pay.TopLevel = false;
            View_pay.Visible = true;
            panelMain.Controls.Add(View_pay);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            firstlod = false;
           

            notifyIcon3.Visible = false;
            notifyIcon3.Icon = null;
            notifyIcon3.Dispose();

            

            
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            notifyIcon1.Icon = null;
            notifyIcon1.Dispose();
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            notifyIcon1.Icon = null;
            notifyIcon1.Dispose();
        }

        private void ownerAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_details = true;
            View_admin_detail ac_main = new View_admin_detail();
            ac_main.ShowDialog();



            
        }

        private void notifyIcon2_BalloonTipClosed(object sender, EventArgs e)
        {
            notifyIcon2.Visible = false;
            notifyIcon2.Icon = null;
            notifyIcon2.Dispose();
        }

        private void notifyIcon2_Click(object sender, EventArgs e)
        {
            notifyIcon2.Visible = false;
            notifyIcon2.Icon = null;
            notifyIcon2.Dispose();
        }


       

        private void Main_Resize(object sender, EventArgs e)
        {
            //______________Mibimize Show System Tray___________________________
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon3.ShowBalloonTip(3000, "Sharp Creation", "Inventory Control v1.0 has been minimized to the taskbar.", ToolTipIcon.Info);
               
            }


        }

        private void notifyIcon3_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon3.ShowBalloonTip(3000, "Sharp Creation", "Inventory Control v1.0 work on Desktop.", ToolTipIcon.Info);


        }

        private void notifyIcon3_BalloonTipClosed(object sender, EventArgs e)
        {
            //notifyIcon3.Visible = false;
            //notifyIcon3.Icon = null;
            //notifyIcon3.Dispose();
        }

        private void invoiceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Find_Invoice invofind = new Find_Invoice();
            invofind.TopLevel = false;
            invofind.Visible = true;
            panelMain.Controls.Add(invofind);
            Find_Invoice.dgvf.Columns["Description"].Width = 250;
        }

        private void printInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Find_Invoice invofind = new Find_Invoice();
            invofind.TopLevel = false;
            invofind.Visible = true;
            panelMain.Controls.Add(invofind);
            Find_Invoice.dgvf.Columns["Description"].Width = 250;
        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Add_Items Itadd = new Add_Items();
            Itadd.TopLevel = false;
            Itadd.Visible = true;
            panelMain.Controls.Add(Itadd);
            Add_Items.tx_brcde.Focus();
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Find_Customer FindCous = new Find_Customer();
            FindCous.TopLevel = false;
            FindCous.Visible = true;
            panelMain.Controls.Add(FindCous);
        }

        private void addCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Add_customer AddCust = new Add_customer();
            AddCust.TopLevel = false;
            AddCust.Visible = true;
            panelMain.Controls.Add(AddCust);
        }

        private void viewSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            View_Suppliers ViewSup = new View_Suppliers();
            ViewSup.TopLevel = false;
            ViewSup.Visible = true;
            panelMain.Controls.Add(ViewSup);
        }

        private void addVendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Add_Supplier AddSup = new Add_Supplier();
            AddSup.TopLevel = false;
            AddSup.Visible = true;
            panelMain.Controls.Add(AddSup);
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panelMain.Controls.Clear();
            //Report_main View_rpt = new Report_main();
            //View_rpt.TopLevel = false;
            //View_rpt.Visible = true;
            //panelMain.Controls.Add(View_rpt);
        }

        private void receivedSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Get_Sallery View_pay = new Get_Sallery();
            View_pay.TopLevel = false;
            View_pay.Visible = true;
            panelMain.Controls.Add(View_pay);
        }

        private void payrollToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Month_payroll View_pay = new Month_payroll();
            View_pay.TopLevel = false;
            View_pay.Visible = true;
            panelMain.Controls.Add(View_pay);
        }

        private void salaryAndTargrtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_ref_salary_taget refsal = new Set_ref_salary_taget();
            refsal.ShowDialog();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Report_main View_rpt = new Report_main();
            View_rpt.TopLevel = false;
            View_rpt.Visible = true;
            panelMain.Controls.Add(View_rpt);

            Report_main.pn_Rpot.Controls.Clear();
            Rpot_Sales rsale = new Rpot_Sales();
            rsale.TopLevel = false;
            rsale.Visible = true;
            Report_main.pn_Rpot.Controls.Add(rsale);
        }

        private void incomeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Report_main View_rpt = new Report_main();
            View_rpt.TopLevel = false;
            View_rpt.Visible = true;
            panelMain.Controls.Add(View_rpt);

            Report_main.pn_Rpot.Controls.Clear();
            Rpot_Income rincm = new Rpot_Income();
            rincm.TopLevel = false;
            rincm.Visible = true;
            Report_main.pn_Rpot.Controls.Add(rincm);
        }

        private void stockLevalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Report_main View_rpt = new Report_main();
            View_rpt.TopLevel = false;
            View_rpt.Visible = true;
            panelMain.Controls.Add(View_rpt);

            Report_main.pn_Rpot.Controls.Clear();
            Rpot_StockLeval rstokl = new Rpot_StockLeval();
            rstokl.TopLevel = false;
            rstokl.Visible = true;
            Report_main.pn_Rpot.Controls.Add(rstokl);
        }

        private void receivedStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Report_main View_rpt = new Report_main();
            View_rpt.TopLevel = false;
            View_rpt.Visible = true;
            panelMain.Controls.Add(View_rpt);

            Report_main.pn_Rpot.Controls.Clear();
            Rpot_ReceivedStock rrceivs = new Rpot_ReceivedStock();
            rrceivs.TopLevel = false;
            rrceivs.Visible = true;
            Report_main.pn_Rpot.Controls.Add(rrceivs);
        }

        private void customerOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Report_main View_rpt = new Report_main();
            View_rpt.TopLevel = false;
            View_rpt.Visible = true;
            panelMain.Controls.Add(View_rpt);

            Report_main.pn_Rpot.Controls.Clear();
            Rpot_CusOrder rcuso = new Rpot_CusOrder();
            rcuso.TopLevel = false;
            rcuso.Visible = true;
            Report_main.pn_Rpot.Controls.Add(rcuso);
        }

        private void requestOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Report_main View_rpt = new Report_main();
            View_rpt.TopLevel = false;
            View_rpt.Visible = true;
            panelMain.Controls.Add(View_rpt);

            Report_main.pn_Rpot.Controls.Clear();
            Rpot_RequestOrder rrqst = new Rpot_RequestOrder();
            rrqst.TopLevel = false;
            rrqst.Visible = true;
            Report_main.pn_Rpot.Controls.Add(rrqst);
        }

        private void returnItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Report_main View_rpt = new Report_main();
            View_rpt.TopLevel = false;
            View_rpt.Visible = true;
            panelMain.Controls.Add(View_rpt);


            Report_main.pn_Rpot.Controls.Clear();
            Rpot_ReturnItem rrutun = new Rpot_ReturnItem();
            rrutun.TopLevel = false;
            rrutun.Visible = true;
            Report_main.pn_Rpot.Controls.Add(rrutun);
        }

        private void warrantyItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Report_main View_rpt = new Report_main();
            View_rpt.TopLevel = false;
            View_rpt.Visible = true;
            panelMain.Controls.Add(View_rpt);

            Report_main.pn_Rpot.Controls.Clear();
            Rpot_WarrantyItem rwarrnt = new Rpot_WarrantyItem();
            rwarrnt.TopLevel = false;
            rwarrnt.Visible = true;
            Report_main.pn_Rpot.Controls.Add(rwarrnt);
        }

        private void supplierListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Report_main View_rpt = new Report_main();
            View_rpt.TopLevel = false;
            View_rpt.Visible = true;
            panelMain.Controls.Add(View_rpt);

            Report_main.pn_Rpot.Controls.Clear();
            Rpot_SupplierList rsupp = new Rpot_SupplierList();
            rsupp.TopLevel = false;
            rsupp.Visible = true;
            Report_main.pn_Rpot.Controls.Add(rsupp);
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Report_main View_rpt = new Report_main();
            View_rpt.TopLevel = false;
            View_rpt.Visible = true;
            panelMain.Controls.Add(View_rpt);

            Report_main.pn_Rpot.Controls.Clear();
            Rpot_CustomerList rcusl = new Rpot_CustomerList();
            rcusl.TopLevel = false;
            rcusl.Visible = true;
            Report_main.pn_Rpot.Controls.Add(rcusl);
        }

        private void salfRefListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Report_main View_rpt = new Report_main();
            View_rpt.TopLevel = false;
            View_rpt.Visible = true;
            panelMain.Controls.Add(View_rpt);

            Report_main.pn_Rpot.Controls.Clear();
            Rpot_SalesRefList rsaleref = new Rpot_SalesRefList();
            rsaleref.TopLevel = false;
            rsaleref.Visible = true;
            Report_main.pn_Rpot.Controls.Add(rsaleref);
        }

        private void priceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Report_main View_rpt = new Report_main();
            View_rpt.TopLevel = false;
            View_rpt.Visible = true;
            panelMain.Controls.Add(View_rpt);

            Report_main.pn_Rpot.Controls.Clear();
            Rpot_PriceList rpiz = new Rpot_PriceList();
            rpiz.TopLevel = false;
            rpiz.Visible = true;
            Report_main.pn_Rpot.Controls.Add(rpiz);
        }

        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Report_main View_rpt = new Report_main();
            View_rpt.TopLevel = false;
            View_rpt.Visible = true;
            panelMain.Controls.Add(View_rpt);

            Report_main.pn_Rpot.Controls.Clear();
            Rpot_ItemList ritem = new Rpot_ItemList();
            ritem.TopLevel = false;
            ritem.Visible = true;
            Report_main.pn_Rpot.Controls.Add(ritem);
        }

        private void backupDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog B_path = new FolderBrowserDialog();

                if (B_path.ShowDialog() == DialogResult.OK)
                {
                    Bpth = B_path.SelectedPath;
                    

                    string sql = "BACKUP DATABASE [" + System.Windows.Forms.Application.StartupPath + "\\InventoryDB.mdf] TO DISK = '" + Bpth + "\\" + "InventoryDB" + "-" + DateTime.Now.Ticks.ToString() + ".bak'";
                    SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
                    com.ExecuteNonQuery();
                    ConnectionDB.Connection().Close();
                    ConnectionDB.Connection().Dispose();



                    MessageBox.Show("Backup File Created Sucessfully", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception w) { MessageBox.Show(w.Message); }
           
        }

        private void restorDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("\"" + un + "\" Do you want to Logout from Inventory Control...? \nPress Ok to Save All Change and Logout. ", "Sharp Creation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                logut = true;

                Application.Restart(); 
            }
        }

        private void logoutToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            logoutToolStripMenuItem.Font = new Font(Font, Font.Style | FontStyle.Underline);
        }

        private void logoutToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            logoutToolStripMenuItem.Font = new Font(Font, Font.Style | FontStyle.Regular);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (logut == false && rstor==false) { Application.Exit(); }
        }

        private void custormizeRestorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog R_path = new OpenFileDialog();
                R_path.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
                R_path.FilterIndex = 0;
                if (R_path.ShowDialog() == DialogResult.OK)
                {
                    Rpth = R_path.FileName;


                    string sql = "Alter Database [" + System.Windows.Forms.Application.StartupPath + "\\InventoryDB_tmp.mdf] Set SINGLE_USER WITH ROLLBACK IMMEDIATE use master;";
                    sql += "Restore Database [" + System.Windows.Forms.Application.StartupPath + "\\InventoryDB_tmp.mdf] FROM Disk = '" + Rpth + "' WITH REPLACE;";
                    SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection_tmp());
                    com.ExecuteNonQuery();

                    ConnectionDB.Connection().Close();
                    ConnectionDB.Connection().Dispose();



                    Restor reto = new Restor();
                    reto.ShowDialog();
                }
            }
            catch (Exception w) { MessageBox.Show(w.Message); }
            
        }

        private void masterRestorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog R_path = new OpenFileDialog();
                R_path.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
                R_path.FilterIndex = 0;
                if (R_path.ShowDialog() == DialogResult.OK)
                {
                    Rpth = R_path.FileName;


                    string sql = "Alter Database [" + System.Windows.Forms.Application.StartupPath + "\\InventoryDB.mdf] Set SINGLE_USER WITH ROLLBACK IMMEDIATE use master;";
                    sql += "Restore Database [" + System.Windows.Forms.Application.StartupPath + "\\InventoryDB.mdf] FROM Disk = '" + Rpth + "' WITH REPLACE;";
                    SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
                    com.ExecuteNonQuery();

                    ConnectionDB.Connection().Close();
                    ConnectionDB.Connection().Dispose();



                    if (MessageBox.Show("Restor Database Sucessfully..!. \nInventory Control now will restart.", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        rstor = true;
                        Application.Restart();

                    }
                }
            }
            catch (Exception w) { MessageBox.Show(w.Message); }
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = .6;
            About_Sharp_Creations abut = new About_Sharp_Creations();
            abut.ShowDialog();
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (opsity == false) { this.Opacity = 1.0; }
        }

        private void Main_MouseEnter(object sender, EventArgs e)
        {
            if (opsity == false) { this.Opacity = 1.0; }
        }

       

        private void toolStrip1_MouseEnter(object sender, EventArgs e)
        {
            if (opsity == false) { this.Opacity = 1.0; }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        
        

        

        

        

        

       

       

       
        
       

      
       

       

       

        

        
        





       
        

        

       
        

       
        
        
        

       
    }

      
}
