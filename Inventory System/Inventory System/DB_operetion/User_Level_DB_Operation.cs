using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_System
{
    class User_Level_DB_Operation
    {







//______START_____________________Administrator or Standuser check______________________________________________________________________
        public SqlDataReader log(string UserLevel)
        {
            string sql = "SELECT * FROM tbl_UserAccount";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr_UL = com.ExecuteReader();
            return dr_UL;
        }
//______END______________________________________________________________________________________________________________________________





//______START_____________________security question & answer check_____________________________________________________________________
        public SqlDataReader security_q_select()
        {
            string sql = "SELECT * FROM tbl_UserAccount";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr2 = com.ExecuteReader();
            return dr2;
        }
//______END______________________________________________________________________________________________________________________________





//______START_____________________dgv get tbl_UserAccount details_____________________________________________________________________
        public DataSet all_Users()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * FROM tbl_UserAccount";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_UserAccount");
            return ds;
        }
//______END______________________________________________________________________________________________________________________________



//---START______________________________________________________________________________________________________________________________
        public void delete(string UserName)
        {
            string sql = "DELETE FROM tbl_UserAccount WHERE User_Name='" + UserName + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }

//_________________________________________________________________________________________________________________________________________







        //______START_____________________get username combo box select _______________________________________________________________________________________
        public SqlDataReader select_UserName(string UserName)
        {
            string sql = "SELECT * FROM tbl_UserAccount WHERE User_Name='" + UserName + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
        //______END______________________________________________________________________________________________________________________________ 







      






        //______START_____________________Update User Account_____________________________________________________________________

        /*+++++Updadte user Account+++++*/
        public void update
            (
                string FName,
                string LName,
                string NIC,
                string Pasort,
                string Mob,
                string Add1,
                string Add2,
                string Email,
                string BirthDay,
                string UserType,
                string Password,
                string ConPassword,
                string Sec_question,
                string Sec_answer,
                string UN
            )
        {
            string sql = "UPDATE tbl_UserAccount SET First_Name='" + FName + "',Last_Name='" + LName + "',NIC='" + NIC + "',Pasport='" + Pasort + "',Mobile='" + Mob + "',Address_Line1='" + Add1 + "',Address_Line2='" + Add2 + "',Email='" + Email + "',BirthDay='" + BirthDay + "',User_Type='" + UserType + "',Password='" + Password + "',Confirm_Password='" + ConPassword + "',Security_Qestion='" + Sec_question + "',Security_Answer='" + Sec_answer + "' WHERE User_Name='" + UN + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        /*+++++Select Update User Name +++++*/
        public SqlDataReader Update_UN_Check(string UN)
        {
            string sql = "SELECT * FROM tbl_UserAccount WHERE User_Name='" + UN + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }



        //______END______________________________________________________________________________________________________________________________






        public void update_Acc
    (
        string FName,
        string LName,
        string NIC,
        
        string Mob,
        string Add1,
        string Add2,
        string Email,
        

        string UserType,
        string UserName,
        string Password,
        string ConPassword,
        string Sec_question,
        string Sec_answer,
        string UN

    )
        {
            string sql = "UPDATE tbl_UserAccount SET First_Name='" + FName + "',Last_Name='" + LName + "',NIC='" + NIC + "',Mobile='" + Mob + "',Address_Line1='" + Add1 + "',Address_Line2='" + Add2 + "',Email='" + Email + "', User_Name='" + UserName + "',User_Type='" + UserType + "',Password='" + Password + "',Confirm_Password='" + ConPassword + "',Security_Qestion='" + Sec_question + "',Security_Answer='" + Sec_answer + "' WHERE User_Name='" + UN + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }







    }
}
