using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_System
{
    class User_acc_DB_Operations
    {



        //________START___________________________insert New Acc--(User_Account)________________________________________________________________
        public void insert
            (
            string FName,
            string LName,
            string NIC,
            
            string Mob,
            string Add1,
            string Add2,
            string Email,
           
            string date,
            string userType,
            string userName,
            string Pass,
            string conPass,
            string security_q,
            string security_ans
            )
        {
            string sql = "INSERT INTO tbl_UserAccount(First_Name,Last_Name,NIC,Mobile,Address_Line1,Address_Line2,Email,Date,User_Type,User_Name,Password,Confirm_Password,Security_Qestion,Security_Answer) VALUES ('" + FName + "','" + LName + "','" + NIC + "','" + Mob + "','" + Add1 + "','" + Add2 + "','" + Email + "','" + date + "','" + userType + "','" + userName + "','" + Pass + "','" + conPass + "','" + security_q + "','" + security_ans + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }
        //_________END____________________________________________________________________________________________________________________________






        //________START___________________________select user name & password______________________________________________________________________
        public SqlDataReader select(string User_Name, string Pass)
        {
            string sql = "SELECT*FROM tbl_UserAccount WHERE User_Name='" + User_Name + "' AND Password='" + Pass + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
        //________END____________________________________________________________________________________________________________________________






        //________START___________________________________select user level_________________________________________________________________
        public SqlDataReader User_Level(string UserLevel)
        {
            string sql = "SELECT*tbl_UserAccount WHERE User_Type='" + UserLevel + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr_UL = com.ExecuteReader();
            return dr_UL;
        }
        //________END_______________________________________________________________________________________________________________________



        public SqlDataReader select_Old_User_Acc(string User_Nam)
        {
            string sql = "SELECT*FROM tbl_UserAccount WHERE User_Name='" + User_Nam + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }



        public void set_sal_tgt(string unme,decimal m_sal, decimal m_tget)
        {
            string sql = @"INSERT INTO tbl_Salary_And_Target(User_Name,Monthly_Salary,Monthly_Trget)VALUES('" + unme + "','" + m_sal + "','" + m_tget + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }




        public void Insert_Onwer_Acc(string UN, string Pass, string Con_Pass, string Sec_Q, string Sec_Ans)
        {
            string sql = "INSERT INTO tbl_Admin_Accounts (User_Name,Password,Confirm_Password,Security_Qestion,Security_Answer) VALUES ('" + UN + "','" + Pass + "','" + Con_Pass + "','" + Sec_Q + "','" + Sec_Ans + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        public void Update_Owner_acc(string unme_new, string Pass, string Con_Pass, string Sec_Q, string Sec_Ans, string unme_old)
        {
            string sql = "UPDATE tbl_Admin_Accounts SET User_Name='" + unme_new + "', Password='" + Pass + "',Confirm_Password='" + Con_Pass + "',Security_Qestion='" + Sec_Q + "',Security_Answer='" + Sec_Ans + "' WHERE User_Name='" + unme_old + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        public SqlDataReader select_owner()
        {
            string sql = "SELECT * FROM tbl_Admin_Accounts";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }

        public SqlDataReader select_owner_recory(string unm,string qus,string awns)
        {
            string sql = "SELECT * FROM tbl_Admin_Accounts WHERE User_Name='" + unm + "' AND Security_Qestion='" + qus + "' AND Security_Answer='" + awns + "' ";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }

        public SqlDataReader select_user_recory(string unm, string qus, string awns)
        {
            string sql = "SELECT * FROM tbl_UserAccount WHERE User_Name='" + unm + "' AND Security_Qestion='" + qus + "' AND Security_Answer='" + awns + "' ";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }

        public void Update_Owner_acc_rcoy(string unme_new, string Pass, string Con_Pass, string Sec_Q, string Sec_Ans)
        {
            string sql = "UPDATE tbl_Admin_Accounts SET  Password='" + Pass + "',Confirm_Password='" + Con_Pass + "',Security_Qestion='" + Sec_Q + "',Security_Answer='" + Sec_Ans + "' WHERE User_Name='" + unme_new + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        public void Update_user_acc_rcoy(string unme_new, string Pass, string Con_Pass, string Sec_Q, string Sec_Ans)
        {
            string sql = "UPDATE tbl_UserAccount SET  Password='" + Pass + "',Confirm_Password='" + Con_Pass + "',Security_Qestion='" + Sec_Q + "',Security_Answer='" + Sec_Ans + "' WHERE User_Name='" + unme_new + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }




    }
}
