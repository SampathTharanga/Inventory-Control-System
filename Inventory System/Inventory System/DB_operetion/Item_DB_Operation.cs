using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Inventory_System
{
    class Item_DB_Operation
    {
        string no,no2;
        public string Itemno()
        {

            string atosql = "SELECT MAX(Item_No) FROM tbl_Add_Items";
            SqlCommand com = new SqlCommand(atosql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read() == true)
            {
                no = dr[0].ToString();
            }
            return no;

            
        }

       








        public void insert(string ino, string serial, string iname, decimal selsPrice, decimal purchPrice, decimal tax, string barcode, string catogory, string subCatory,string brande, string itype, string supplier,string woraty, string discript)
        {
            string sql = @"INSERT INTO tbl_Add_Items(Item_No,Serial_No,Item_Name,Sales_Price,Purchase_Price,Tax_Rate,Barcode,Catogory,Sub_Catogory,Brande,Item_Type,Supplier,Warranty,Discription)VALUES('" + ino + "','" + serial + "','" + iname + "','" + selsPrice + "','" + purchPrice + "','" + tax + "','" + barcode + "','" + catogory + "','" + subCatory + "','" + brande + "','" + itype + "','" + supplier + "','"+woraty+"','" + discript + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();

        }


        public DataSet all()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT*FROM tbl_Add_Items";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Add_Items");
            return ds;
          
        }


        public void addchoosIt(string catagory, string subcatogory,string brande,string itype)
        {
            string sql = @"INSERT INTO tbl_item_choose_detalis(Catogory,Sub_catogory,Brande,Type)VALUES('" + catagory + "','" + subcatogory + "','" + brande + "','" + itype + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }

        public void catogary(string catogary)
        {
            string sql = @"INSERT INTO tbl_catogory(catogory)VALUES('" + catogary + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }

        public void Subcatogary(string Subcatogary, string catogry)
        {
            string sql = @"INSERT INTO tbl_sub_catogory(sub_catogory,catogory)VALUES('" + Subcatogary + "','"+catogry+"')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }

        public void itype(string itype)
        {
            string sql = @"INSERT INTO tbl_itype(Item_type)VALUES('" + itype + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        public void brande(string Brande)
        {
            string sql = @"INSERT INTO tbl_brande(Brande)VALUES('" + Brande + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        public DataSet show_Catogory()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT*FROM tbl_catogory";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_catogory");
            return ds;

        }


        public DataSet show_SubCatogory()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT*FROM tbl_sub_catogory";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_sub_catogory");
            return ds;

        }


        public DataSet show_Brande()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT*FROM tbl_brande";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_brande");
            return ds;
        }


        public DataSet show_itype()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT*FROM tbl_itype";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_itype");
            return ds;

        }

        public void delete_catogory(string No)
        {
            string sql = "DELETE FROM tbl_catogory WHERE catogory='" + No + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }

        public void delete_Subcatogory(string No)
        {
            string sql = "DELETE FROM tbl_sub_catogory WHERE sub_catogory='" + No + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        public void delete_Brande(string No)
        {
            string sql = "DELETE FROM tbl_brande WHERE Brande='" + No + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        public void delete_Type(string No)
        {
            string sql = "DELETE FROM tbl_itype WHERE Item_type='" + No + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        public void Quntity(string inme,string icatogory, string isubcatorogy, string ibrande, string iquntity,string ipercsPiz,string isalPiz)
        {
            string sql = @"INSERT INTO tbl_Item_Quntity(Item_Name,Item_catogory,Item_sub_catogory,Item_Brande,Quntity,Unit_purchas_price,Unit_sale_price)VALUES('" + inme + "','" + icatogory + "','" + isubcatorogy + "','" + ibrande + "','" + iquntity + "','" + ipercsPiz + "','" + isalPiz + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }

        public SqlDataReader select_to_Qntity(string icatogory, string isubcatorogy, string ibrande)
        {
            string sql = "SELECT * FROM tbl_Item_Quntity WHERE Item_catogory='" + icatogory + "'AND Item_sub_catogory='" + isubcatorogy + "'AND Item_Brande='" + ibrande + "'";
                SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
                SqlDataReader dr = com.ExecuteReader();
                return dr;
        }

        public void update_Quntity(string quty, string icatogory, string isubcatorogy, string ibrande)
        {
            string sql = "UPDATE tbl_Item_Quntity SET Quntity='" + quty + "' WHERE Item_catogory='" + icatogory + "'AND Item_sub_catogory='" + isubcatorogy + "'AND Item_Brande='" + ibrande + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }

        public void update_Quntity_add(string inme,string quty, string icatogory, string isubcatorogy, string ibrande, string ipercsPiz, string isalPiz)
        {
            string sql = "UPDATE tbl_Item_Quntity SET Item_Name='" + inme + "', Quntity='" + quty + "',Unit_purchas_price='" + ipercsPiz + "',Unit_sale_price='" + isalPiz + "' WHERE Item_catogory='" + icatogory + "'AND Item_sub_catogory='" + isubcatorogy + "'AND Item_Brande='" + ibrande + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        public void udteItem(string ino, string serial, string iname, decimal selsPrice, decimal purchPrice, decimal tax, string barcode, string catogory, string subCatory, string brande, string itype, string supplier,string watny, string discript)
        {
            string sql = "UPDATE tbl_Add_Items SET Serial_No='" + serial + "',Item_Name='" + iname + "',Sales_Price='" + selsPrice + "',Purchase_Price='" + purchPrice + "',Tax_Rate='" + tax + "',Barcode='" + barcode + "',Catogory='" + catogory + "',Sub_Catogory='" + subCatory + "',Brande='" + brande + "',Item_Type='" + itype + "',Supplier='" + supplier + "',Warranty='"+ watny +"',Discription='" + discript + "' WHERE Item_No='" + no + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();

        }

       


        
        

        public void delete_item(string No)
        {
            string sql = "DELETE FROM tbl_Add_Items WHERE Item_No='" + No + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }




        string cno;
        public string getCusno()
        {

            string atosql = "SELECT MAX(Item_No) FROM tbl_Invoice_details";
            SqlCommand com = new SqlCommand(atosql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read() == true)
            {
                cno = dr[0].ToString();
            }
            return cno;


        }


        public SqlDataReader select_frm_barcode(string barcc)
        {
            string sql = "SELECT * FROM tbl_Add_Items WHERE Barcode='" + barcc + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }


        public SqlDataReader select_seril_alrdy(string sril)
        {
            string sql = "SELECT * FROM tbl_Add_Items WHERE Serial_No='" + sril + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }

    }

}
