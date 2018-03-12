using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Inventory_System
{
    class Customer_DB_Operation

    {
        string cno;
        public string getCusno()
        {

            string atosql = "SELECT MAX(Coustomer_No) FROM tbl_Add_Customer";
            SqlCommand com = new SqlCommand(atosql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read() == true)
            {
                cno = dr[0].ToString();
            }
            return cno;


        }




        public void insert(string No, string FName, string LName, string BussName, string AddLine1, string AddLine2, string City, string ZipCod, string Phone, string Mob, string fax, string Discu, string Email, string Note)
        {
            string Cucsql = "INSERT INTO tbl_Add_Customer(Coustomer_No,First_Name,Last_Name,Bussiness_Name,Address_Line1,Address_Line2,City,Zip_Postal_Code,Phone,Mobile,Fax,Discount,Email,Notes)VALUES('" + No + "','" + FName + "','" + LName + "','" + BussName + "','" + AddLine1 + "','" + AddLine2 + "','" + City + "','" + ZipCod + "','" + Phone + "','" + Mob + "','" + fax + "','" + Discu + "','" + Email + "','" + Note + "')";
            SqlCommand com = new SqlCommand(Cucsql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }

       

        /*public DataSet Auto()
        {
            DataSet dst = new DataSet();
            string ts = "SELECT MAX(Coustomer_No) FROM tbl_Add_Customer";
            SqlDataAdapter tst = new SqlDataAdapter(ts, ConnectionDB.Connection());
            tst.Fill(dst, "tbl_Add_Customer");
            return dst;
        }

        /////////////////////////////////////////////////////////////////////////////
         
        public SqlDataReader select(string max)
        {
            string ts = "SELECT MAX(Coustomer_No) FROM tbl_Add_Customer";
            SqlCommand com = new SqlCommand(ts, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
        */

        public DataSet all()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT*FROM tbl_Add_Customer";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Add_Customer");
            return ds;

            
        }

       


        public DataSet SelectCus(String findcus)
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * FROM tbl_Add_Customer WHERE Coustomer_No='" + findcus + "'OR First_Name='" + findcus + "'OR Last_Name='" + findcus + "'OR Mobile='" + findcus + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Add_Customer");
            return ds;

        }



        /*
        public DataTable selectCus(int cusno, string cusFname, string cusLname, string cus4n)
        {
            DataTable dt = new DataTable();
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newcmd = conn.CreateCommand();
            newcmd.Connection = conn;
            newcmd.CommandType = CommandType.Text;
            newcmd.CommandText = "SELECT * FROM tbl_Add_Customer WHERE Coustomer_No='" + cusno + "'OR First_Name='" + cusFname + "'OR Last_Name='" + cusLname + "'OR Mobile='" + cus4n + "'";
            SqlDataAdapter da = new SqlDataAdapter(newcmd);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
       

         */


        public void updete(string No,string FName, string LName, string BussName, string AddLine1, string AddLine2, string City, string ZipCod, string Phone, string Mob, string fax, string Discu, string Email, string Note)
        {
            string sql = ("UPDATE tbl_Add_Customer SET First_Name='" + FName + "',Last_Name='" + LName + "',Bussiness_Name='" + BussName + "',Address_Line1='" + AddLine1 + "',Address_Line2='" + AddLine2 + "',City='" + City + "',Zip_Postal_Code='" + ZipCod + "',Phone='" + Phone + "',Mobile='" + Mob + "',Fax='" + fax + "',Discount='" + Discu + "',Email='" + Email + "',Notes='" + Note + "'WHERE Coustomer_No='"+No+"'");
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();

        }

        public void delete(string No)
        {
            string sql = "DELETE FROM tbl_Add_Customer WHERE Coustomer_No='"+No+"'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();


        }





        }
    }



