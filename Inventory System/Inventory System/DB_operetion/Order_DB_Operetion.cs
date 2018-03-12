using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Inventory_System
{
    class Order_DB_Operetion
    {
        string cno;
        public string cusodr_no()
        {

            string atosql = "SELECT MAX(Order_No) FROM tbl_Customer_Order";
            SqlCommand com = new SqlCommand(atosql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read() == true)
            {
                cno = dr[0].ToString();
            }
            return cno;


        }




        //---------------------------------------//
         string sno;
         public string stockno()
         {

             string atosql = "SELECT MAX(Stock_No) FROM tbl_Recive_Stock";
             SqlCommand com = new SqlCommand(atosql, ConnectionDB.Connection());
             SqlDataReader dr = com.ExecuteReader();
             while (dr.Read() == true)
             {
                 sno = dr[0].ToString();
             }
             return sno;


         }


        //--------------------------------------//

         string rno;
         public string requestOdr_no()
         {

             string atosql = "SELECT MAX(Order_No) FROM tbl_Request_Order";
             SqlCommand com = new SqlCommand(atosql, ConnectionDB.Connection());
             SqlDataReader dr = com.ExecuteReader();
             while (dr.Read() == true)
             {
                 rno = dr[0].ToString();
             }
             return rno;


         }



         public void insert(string ordNO, string Date, string Name, string mobile, string discrip)
         {
             string sql = @"INSERT INTO tbl_Customer_Order(Order_No,Date,Name,Mobile,Discription)VALUES('" + ordNO + "','" + Date + "','" + Name + "','" + mobile + "','" + discrip + "')";
             SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
             com.ExecuteNonQuery();

         }

         public DataSet all()
         {
             DataSet ds = new DataSet();
             string sql = "SELECT*FROM tbl_Customer_Order";
             SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
             da.Fill(ds, "tbl_Customer_Order");
             return ds;


         }

         public DataSet SelectCusOrder(String findcusO)
         {
             DataSet ds = new DataSet();
             string sql = "SELECT * FROM tbl_Customer_Order WHERE Order_No='" + findcusO + "'OR Name='" + findcusO + "'OR Mobile='" + findcusO + "'";
             SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
             da.Fill(ds, "tbl_Customer_Order");
             return ds;

         }


         public DataSet all_request_oder()
         {
             DataSet ds = new DataSet();
             string sql = "SELECT*FROM tbl_Request_Order";
             SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
             da.Fill(ds, "tbl_Request_Order");
             return ds;


         }

         public DataSet only_Not_Receiv_request_oder(string odr)
         {
             DataSet ds = new DataSet();
             string sql = "SELECT*FROM tbl_Request_Order WHERE Oder='" +odr+ "'";
             SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
             da.Fill(ds, "tbl_Request_Order");
             return ds;


         }


        /* public DataView SlecCuOdr(String findcusO)
         {
             DataView ds = new DataView();
             string sql = "SELECT * FROM tbl_Customer_Order WHERE Order_No='" + findcusO + "'";
             SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
             DataTable dtbl = new DataTable();
             da.Fill(dtbl);
             BindingSource bnsue = new BindingSource();
             bnsue.DataSource = dtbl;
             View_Customer_Order.dgv.DataSource = bnsue;
             da.Update(dtbl);
             
             return ds;

         }*/

         public SqlDataReader selectCorder(string fidCno,string fidCname,string fidCmob)
         {
             string sql = "SELECT * FROM tbl_Customer_Order WHERE Order_No='" + fidCno + "'OR Name='" + fidCname + "'OR Mobile='" + fidCmob + "'";
             SqlCommand com = new SqlCommand(sql,ConnectionDB.Connection());
             SqlDataReader dr = com.ExecuteReader();
             return dr;
         }


         public void Update(string ordNO, string Date, string Name, string mobile, string discrip)
         {
             string sql = "UPDATE tbl_Customer_Order SET Date='" + Date + "',Name='"+Name+"',Mobile='" + mobile + "',Discription='" + discrip + "'WHERE Order_No='" + ordNO + "'";
             SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
             com.ExecuteNonQuery();

         }

         public void delete(string No)
         {
             string sql = "DELETE FROM tbl_Customer_Order WHERE Order_No='" + No + "'";
             SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
             com.ExecuteNonQuery();


         }


         public void delete_rqst_odr(string No)
         {
             string sql = "DELETE FROM tbl_Request_Order WHERE Order_No='" + No + "'";
             SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
             com.ExecuteNonQuery();


         }


         public void insert_stock(string sNo, DateTime sDate, string sSup, string sDis, string sPymthd, decimal sPrice, decimal sPaid,string ctgy,string sctgy,string brnd,int qty,string stc,decimal u_P_Piz,decimal u_s_piz,string itype,string imne,string ad_cout,string sroktyp)
         {
             string sql = @"INSERT INTO tbl_Recive_Stock(Stock_No,Recive_date,Supplier,Discription,Purchase_Price,payment_Method,Payment,Catogory,Sub_Catogory,Brande,Quntity,Stock,Unit_purchas_price,Unit_sale_price,Item_Type,Item_Name,Add_Count,Stock_type)VALUES('" + sNo + "','" + sDate + "','" + sSup + "','" + sDis + "','" + sPrice + "','" + sPymthd + "','" + sPaid + "','" + ctgy + "','" + sctgy + "','" + brnd + "','" + qty + "','" + stc + "','" + u_P_Piz + "','" + u_s_piz + "','" + itype + "','" + imne + "','" + ad_cout + "','" + sroktyp + "')";
             SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
             com.ExecuteNonQuery();

         }


         //public SqlDataReader R_stock_selec(string cty,string sCty,string brnd,string supp)
         //{
         //    string sql = "SELECT Quntity FROM tbl_Recive_Stock WHERE Catogory='" + cty + "' AND Sub_Catogory='" + sCty + "' AND Brande='" + brnd + "' AND Supplier='" + supp + "'";
         //    SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
         //    SqlDataReader dr = com.ExecuteReader();
         //    return dr;

         //}

         public SqlDataReader R_stock_selec(string stok,string sup)
         {
             string sql = "SELECT * FROM tbl_Recive_Stock WHERE Stock='" + stok + "' AND Supplier='" + sup + "'";
             SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
             SqlDataReader dr = com.ExecuteReader();
             return dr;

         }



         public SqlDataReader supName(string sname)
         {
             string sql = "SELECT * FROM tbl_AddS_Supplier WHERE First_Name='"+sname+"'";
             SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
             SqlDataReader dr = com.ExecuteReader();
             return dr;
             
             

         }

         public void insert_reqstO(string ordNO, DateTime Date, string sName, string mobile,string eml, string discrip,string odrr,string ctgy,string subctgy,string brnd,string nme,decimal qty,string typ)
         {
             string sql = @"INSERT INTO tbl_Request_Order(Order_No,Order_Date,Supplier,Mobile,Email,Discription,Oder,Name,Catogory,Sub_Catogory,Brande,Item_Type,Quntity)VALUES('" + ordNO + "','" + Date + "','" + sName + "','" + mobile + "','" + eml + "','" + discrip + "','" + odrr + "','" + nme + "','" + ctgy + "','" + subctgy + "','" + brnd + "','" + typ + "','" + qty + "')";
             SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
             com.ExecuteNonQuery();

         }



         public SqlDataReader select_suppD_to_request(string supnm)
         {
             string sql = "SELECT * FROM tbl_AddS_Supplier WHERE Business_Name='" + supnm + "'";
             SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
             SqlDataReader dr = com.ExecuteReader();
             return dr;
         }

         public void Update_rqst_odr(string ordNO, string Date, string Name, string mobile, string emal, string discrip, string ctgy, string subctgy, string brnd, string nme, decimal qty, string typ)
         {
             string sql = "UPDATE tbl_Request_Order SET Order_Date='" + Date + "',Supplier='" + Name + "',Mobile='" + mobile + "',Discription='" + discrip + "',Email='" + emal + "',Name='" + nme + "',Catogory='" + ctgy + "',Sub_Catogory='" + subctgy + "',Brande='" + brnd + "',Item_Type='" + typ + "',Quntity='" + qty + "' WHERE Order_No='" + ordNO + "'";
             SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
             com.ExecuteNonQuery();

         }

         public void Update_rqst_odr2(string ordNO,string oddr)
         {
             string sql = "UPDATE tbl_Request_Order SET Oder='" + oddr + "' WHERE Order_No='" + ordNO + "'";
             SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
             com.ExecuteNonQuery();

         }




         public void Update_R_stok_qty(string stok, string supp,string qqty)
         {
             string sql = "UPDATE tbl_Recive_Stock SET Add_Count='" + qqty + "' WHERE Stock='" + stok + "' AND Supplier='" + supp + "'";
             SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
             com.ExecuteNonQuery();

         }


    }
}
