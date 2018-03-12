using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace Inventory_System
{
    class Supplier_DB_Operetion
    {


        string sno;
        public string Suppno()
        {

            string atosql = "SELECT MAX(Supplier_No) FROM tbl_AddS_Supplier";
            SqlCommand com = new SqlCommand(atosql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read() == true)
            {
                sno = dr[0].ToString();
            }
            return sno;


        }


        public void insert(string No, string FName, string LName, string BussName, string AddLine1, string AddLine2, string city,string Phone, string Mob, string Fax, string ZipCod, string Email, string Note)
        {
            string sql = "INSERT INTO tbl_AddS_Supplier(Supplier_No,First_Name,Last_Name,Business_Name,Address_Line1,Address_Line2,City,Phone,Mobile,Fax,Zip_Postal_Code,Email,Notes)VALUES('" + No + "','" + FName + "','" + LName + "','" + BussName + "','" + AddLine1 + "','" + AddLine2 + "','" + city + "','" + Phone + "','" + Mob + "','" + Fax + "','" + ZipCod + "','" + Email + "','" + Note + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();

        }

        public DataSet all()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT*FROM tbl_AddS_Supplier";
            SqlDataAdapter da = new SqlDataAdapter(sql,ConnectionDB.Connection());
            da.Fill(ds, "tbl_AddS_Supplier");
            return ds;

        }

        public void update(string No, string FName, string LName, string BussName, string AddLine1, string AddLine2, string city, string Phone, string Mob, string Fax, string ZipCod, string Email, string Note)
        {
            string sql = "UPDATE tbl_AddS_Supplier SET First_Name='" + FName + "',Last_Name='" + LName + "',Business_Name='" + BussName + "',Address_Line1='" + AddLine1 + "',Address_Line2='" + AddLine2 + "',City='" + city + "',Phone='" + Phone + "',Mobile='" + Mob + "',Fax='" + Fax + "',Zip_Postal_Code='" + ZipCod + "',Email='" + Email + "',Notes='" + Note + "'WHERE Supplier_No='" + No + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        public DataSet each_sup_stock(string sBno)
        {
            DataSet ds = new DataSet();
            string sql = "SELECT*FROM tbl_Recive_Stock WHERE Supplier='" + sBno + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Recive_Stock");
            return ds;

        }


        public SqlDataReader selectB(string no)
        {
            string sql = "SELECT*FROM tbl_Recive_Stock WHERE Stock_No='" + no + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }


        public SqlDataReader selectNB(string no)
        {
            string sql = "SELECT*FROM tbl_Recive_Stock WHERE Stock_No='" + no + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }



        public void Update_SupAcc(string sNum, DateTime sDate, string sSup, string sDis, string sPymthd, decimal sPrice, decimal sPaid,string ctgy,string sctgy, string brnd, decimal u_Ppiz, decimal u_Spiz,decimal qty, string itype,string stype )
        {
            string sql = "UPDATE tbl_Recive_Stock SET Recive_date='" + sDate + "',Discription='" + sDis + "',Supplier='" + sSup + "',Purchase_Price='" + sPrice + "',Payment='" + sPaid + "',payment_Method='" + sPymthd + "',Catogory='" + ctgy + "',Sub_Catogory='" + sctgy + "',Brande='" + brnd + "',Quntity='" + qty + "',Item_Type='" + itype + "',Unit_purchas_price='" + u_Ppiz + "',Unit_sale_price='" + u_Spiz + "',Stock_type='" + stype + "' WHERE Stock_No='" + sNum + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }



        public void update_paid(decimal paid, string sNum)
        {
            string sql = "UPDATE tbl_Recive_Stock SET Payment='" + paid + "' WHERE Stock_No='" + sNum + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        public void delete_sup(string No)
        {
            string sql = "DELETE FROM tbl_AddS_Supplier WHERE Supplier_No='" + No + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();


        }

    }

}
