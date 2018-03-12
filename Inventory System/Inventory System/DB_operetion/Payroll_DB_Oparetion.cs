using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Inventory_System
{
    class Payroll_DB_Oparetion
    {


        public DataSet all()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT*FROM tbl_Salary_And_Target";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Salary_And_Target");
            return ds;

        }


        public void update_sal_and_taget(string unm, decimal sal,  decimal tgt)
        {
            string sql = "UPDATE tbl_Salary_And_Target SET Monthly_Salary='" + sal + "',Monthly_Trget='" + tgt + "' WHERE User_Name='" + unm + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }



        public SqlDataReader select_User_Acc(string User_Nam)
        {
            string sql = "SELECT*FROM tbl_UserAccount WHERE User_Name='" + User_Nam + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }


        public SqlDataReader select_sal_tgt(string User_Nam)
        {
            string sql = "SELECT*FROM tbl_Salary_And_Target WHERE User_Name='" + User_Nam + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }


        public SqlDataReader select_sal_blnce(string User_Nam)
        {
            string sql = "SELECT*FROM tbl_Salary_balnce WHERE User_Name='" + User_Nam + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }


        public void Insert_sal_blnce(string unme, decimal arrears, decimal Remainng)
        {
            string sql = @"INSERT INTO tbl_Salary_balnce(User_Name,Arrears,Remaining)VALUES('" + unme + "','" + arrears + "','" + Remainng + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }

        public void Update_sal_blnce(string unme, decimal arias, decimal reming)
        {
            string sql = "UPDATE tbl_Salary_balnce SET Arrears='" + arias + "',Remaining='" + reming + "' WHERE User_Name='" + unme + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        public SqlDataReader select_sale_ref_invoice(string User_Nam,string dte)
        {
            string sql = "SELECT Invoice_Date FROM tbl_Invoice WHERE Seals_ref='" + User_Nam + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }


        public void Insert_sal_history(string unme,string yer,string mon,decimal mon_sal, decimal arrears, decimal Remainng,decimal net_mon_sal,decimal mon_tgt,decimal comp_tgt,decimal etra_comp_tgt,decimal etra_sal,decimal tot_sal,decimal recevd_sal, decimal aditional_recevd,decimal rest_sal)
        {
            string sql = @"INSERT INTO tbl_Salary_History(User_Name,Year,Month,Monthly_Salary,Arears,Remaining,Net_Month_Salary,Monthly_Trget,Completed_Target,Extra_Completed_Target,Extra_Salary,Total_Salary,Received_Salary,Additional_Received,Rest_Salary)VALUES('" + unme + "','" + yer + "','" + mon + "','" + mon_sal + "','" + arrears + "','" + Remainng + "','" + net_mon_sal + "','" + mon_tgt + "','" + comp_tgt + "','" + etra_comp_tgt + "','" + etra_sal + "','" + tot_sal + "','" + recevd_sal + "','" + aditional_recevd + "','" + rest_sal + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        public SqlDataReader select_sal_histy(string User_Nam,string yer,string mon)
        {
            string sql = "SELECT * FROM tbl_Salary_History WHERE User_Name='" + User_Nam + "' AND Year='" + yer + "'AND Month='" + mon + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }


        public DataSet all_sal_histry()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT*FROM tbl_Salary_History";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Salary_History");
            return ds;
        }




        public void Insert_payrol_setting(string unme, decimal tgt_rte)
        {
            string sql = @"INSERT INTO tbl_Payroll_setting(User_Name,Target_rate)VALUES('" + unme + "','" + tgt_rte + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        public SqlDataReader select_tgt_rte(string User_Nam)
        {
            string sql = "SELECT * FROM tbl_Payroll_setting WHERE User_Name='" + User_Nam + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }

        public void Update_tgt_rte(string unme, decimal rte)
        {
            string sql = "UPDATE tbl_Payroll_setting SET Target_rate='" + rte + "' WHERE User_Name='" + unme + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        public void Insert_Received_Salary(string unme, decimal sal, DateTime dte,string yer,string mon)
        {
            string sql = @"INSERT INTO tbl_Salary_Received(User_Name,Received_Date,Received_Salary,Year,Month)VALUES('" + unme + "','" + dte + "','" + sal + "','" + yer + "','" + mon + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }

        public SqlDataReader select_Received_Salary(string User_Nam)
        {
            string sql = "SELECT * FROM tbl_Salary_Received WHERE User_Name='" + User_Nam + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }


        

        public DataSet all_Receives_sal()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT User_Name,Received_Date,Received_Salary FROM tbl_Salary_Received";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Salary_Received");
            return ds;

        }





        public void Insert_Temp_data(string yer,string mon)
        {
            string sql = @"INSERT INTO tbl_Salary_Temp(Year,Month)VALUES('" + yer + "','" + mon + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        public SqlDataReader select_Temp_data()
        {
            string sql = "SELECT * FROM tbl_Salary_Temp";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }

        public void Update_temp_data(string yer,string mon)
        {
            string sql = "UPDATE tbl_Salary_Temp SET Year='" + yer + "',Month='" + mon + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }



        public DataSet user_receved_sal(string unme, string yer, string mon)
        {
            DataSet ds = new DataSet();
            string sql = "SELECT User_Name,Received_Date,Received_Salary FROM tbl_Salary_Received WHERE User_Name='" + unme + "' AND Year='" + yer + "' AND Month='" + mon + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Salary_Received");
            return ds;

        }


        public DataSet Month_Receives_sal(string yer,string mon)
        {
            DataSet ds = new DataSet();
            string sql = "SELECT User_Name,Received_Date,Received_Salary FROM tbl_Salary_Received WHERE Year='" + yer + "' AND Month='" + mon + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Salary_Received");
            return ds;

        }









    }
}
