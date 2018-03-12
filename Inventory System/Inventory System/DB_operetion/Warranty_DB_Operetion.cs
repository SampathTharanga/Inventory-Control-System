using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Inventory_System
{
    class Warranty_DB_Operetion
    {

        string no;
        public string AutoWrtyno()
        {

            string atosql = "SELECT MAX(Warranty_No) FROM tbl_Warranty";
            SqlCommand com = new SqlCommand(atosql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read() == true)
            {
                no = dr[0].ToString();
            }
            return no;


        }



        public DataSet each_Item(string stus,string seria)
        {
            DataSet ds = new DataSet();
            string sql = "SELECT Invoice_No,Invoice_Date,Item_No,Item_Name,Serial_No,Barcode,Sales_Price,Catogory,Sub_Catogory,Brande,Warranty,Supplier FROM tbl_Invoice_details WHERE Status='" + stus + "'AND Serial_No !='" + seria + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Invoice_details");
            return ds;
        }

        public SqlDataReader select_cus(string cno)
        {
            string sql = "SELECT*FROM tbl_Add_Customer WHERE Coustomer_No='" + cno + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }



        public SqlDataReader select_cusNo(string ino)
        {
            string sql = "SELECT*FROM tbl_Invoice WHERE Invoice_No='" + ino + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }


        public void addWarranty(string wtno, string invono, string itno, string itnme, string serial, string barcode, string supp, string wtyfrom, string wtyto, string cusnme, string cusmob, string descript, string wtycomplte, string compteby)
        {
            string sql = @"INSERT INTO tbl_Warranty(Warranty_No,Invoice_No,Item_No,Item_Name,Serial_No,Barcode,Supplier,Customer_Name,Customer_Mobile,Description,Warranty_Complete,Completed_by,Warranty_from,Warranty_to)VALUES('" + wtno + "','" + invono + "','" + itno + "','" + itnme + "','" + serial + "','" + barcode + "','" + supp + "','" + cusnme + "','" + cusmob + "','" + descript + "','" + wtycomplte + "','" + compteby + "','" + wtyfrom + "','" + wtyto + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();

        }


        public DataSet allWarty()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT*FROM tbl_Warranty";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Warranty");
            return ds;

        }

        public void updt_waty(string wno, string cmplteBy,string compt)
        {
            string sql = "UPDATE tbl_Warranty SET Completed_by='" + cmplteBy + "',Warranty_Complete='" + compt + "' WHERE Warranty_No='" + wno + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();

        }

        public void addWary_foundItm(string wtno,string invono, string itno, string itnme, string serial, string barcode, string catgry, string subCtogy, string brand, string itype,string descripn)
        {
            string sql = @"INSERT INTO tbl_warrnty_found_Item(Warranty_No,Invoice_No,Item_No,Item_Name,Serial_No,Barcode,Catogory,Sub_Catogory,Brande,Item_Type,Discription)VALUES('" + wtno + "','" + invono + "','" + itno + "','" + itnme + "','" + serial + "','" + barcode + "','" + catgry + "','" + subCtogy + "','" + brand + "','" + itype + "','" + descripn + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();

        }

        public DataSet wtyFounditm(string wtno)
        {
            DataSet ds = new DataSet();
            string sql = "SELECT*FROM tbl_warrnty_found_Item WHERE Warranty_No='" + wtno + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_warrnty_found_Item");
            return ds;

        }


        public void update_invoicItem(string invono, string itno, string itnme, string serial, string barcode, string catgry, string subCtogy, string brand)
        {
            string sql = "UPDATE tbl_Invoice_details SET Item_Name='" + itnme + "',Serial_No='" + serial + "',Barcode='" + barcode + "',Catogory='" + catgry + "',Sub_Catogory='" + subCtogy + "',Brande='" + brand + "' WHERE Invoice_No='" + invono + "'AND Item_No='" + itno + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }




        public void update_ChangeItem(string InvoNo, string ino, string serial, string iname, string selsPrice, string purchPrice, string barcode, string catogory, string subCatory, string brande, string woraty, string supp, string itype, string descrip,string ino2)
        {
            string sql = "UPDATE tbl_Invoice_details SET Item_No='" + ino2 + "',Item_Name='" + iname + "',Serial_No='" + serial + "',Barcode='" + barcode + "',Sales_Price='" + selsPrice + "',Purchase_Price='" + purchPrice + "',Catogory='" + catogory + "',Sub_Catogory='" + subCatory + "',Brande='" + brande + "',Warranty='" + woraty + "',Supplier='" + supp + "',Item_Type='" + itype + "',Discription='" + descrip + "' WHERE Invoice_No='" + InvoNo + "'AND Item_No='" + ino + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }


        public void update_item_status(string InvoNo, string ino, string stus)
        {
            string sql = "UPDATE tbl_Invoice_details SET Status='" + stus + "' WHERE Invoice_No='" + InvoNo + "'AND Item_No='" + ino + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }



        public void insert_back_item(string ino, string serial, string iname, decimal selsPrice, decimal purchPrice, decimal tax, string barcode, string catogory, string subCatory,string brande,  string supplier,string woraty,string itype,string descrip)
        {
            string sql = @"INSERT INTO tbl_Add_Items(Item_No,Serial_No,Item_Name,Sales_Price,Purchase_Price,Tax_Rate,Barcode,Catogory,Sub_Catogory,Brande,Supplier,Warranty,Item_Type,Discription)VALUES('" + ino + "','" + serial + "','" + iname + "','" + selsPrice + "','" + purchPrice + "','" + tax + "','" + barcode + "','" + catogory + "','" + subCatory + "','" + brande + "','" + supplier + "','" + woraty + "','" + itype + "','" + descrip + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();

        }

        public SqlDataReader select_invo_backI(string itmNo, string invoNo)
        {
            string sql = "SELECT * FROM tbl_Invoice_details WHERE Invoice_No='" + invoNo + "'AND Item_No='" + itmNo + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }





        public void insert_retn_itm(string ino, string serial, string iname, decimal selsPrice, decimal purchPrice, decimal tax, string barcode, string catogory, string subCatory, string brande, string itype, string supplier, string woraty, string discript)
        {
            string sql = @"INSERT INTO tbl_Return_items(Item_No,Serial_No,Item_Name,Sales_Price,Purchase_Price,Tax_Rate,Barcode,Catogory,Sub_Catogory,Brande,Item_Type,Supplier,Warranty,Discription)VALUES('" + ino + "','" + serial + "','" + iname + "','" + selsPrice + "','" + purchPrice + "','" + tax + "','" + barcode + "','" + catogory + "','" + subCatory + "','" + brande + "','" + itype + "','" + supplier + "','" + woraty + "','" + discript + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();

        }











    }
}
