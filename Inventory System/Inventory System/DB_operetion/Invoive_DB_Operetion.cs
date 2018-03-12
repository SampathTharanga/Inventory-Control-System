using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Inventory_System
{
    class Invoive_DB_Operetion
    {
        string no;
        public string InvoiceNo()
        {

            string atosql = "SELECT MAX(Invoice_No) FROM tbl_Invoice";
            SqlCommand com = new SqlCommand(atosql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read() == true)
            {
                no = dr[0].ToString();
            }
            return no;



        }
        //_________________________________________________________________________________________________________________

        string qino;
        public string Invoice_itm_No()
        {

            string atosql = "SELECT MAX(Item_No) FROM tbl_Invoice_Item";
            SqlCommand com = new SqlCommand(atosql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read() == true)
            {
                qino = dr[0].ToString();
            }
            return qino;



        }

        //____________________________________________________________________________________________________________________


        public DataSet all_Item()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT Item_No,Item_Name,Serial_No,Purchase_Price,Sales_Price,Tax_Rate,Warranty,Catogory,Sub_Catogory,Brande,Quntity,Item_Type,Barcode,Supplier,Discription,Selct  FROM tbl_Invoice_Item";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Invoice_Item");
            return ds;
        }


        public DataSet all_Invoice_date(string fdate, string tdate)
        {
            DataSet ds = new DataSet();
            string sql = "SELECT Invoice_No,Invoice_Date,Description,Total_Price,Paid_Price,Coustomer_No,Seals_ref,Payment FROM tbl_Invoice WHERE Invoice_Date >='" + fdate + "' AND Invoice_Date <='" + tdate + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Invoice");
            return ds;
        }



        public void insert_Invo_item(string ino, string serial, string iname, decimal selsPrice, decimal purchPrice, decimal tax, string barcode, string catogory, string subCatory, string brande, string woraty, string supp, string tpe, string descrip, string qty,string selct,decimal amut)
        {
            string sql = @"INSERT INTO tbl_Invoice_Item(Item_No,Serial_No,Item_Name,Sales_Price,Purchase_Price,Tax_Rate,Barcode,Catogory,Sub_Catogory,Brande,Warranty,Supplier,Item_Type,Discription,Quntity,Selct,Amount)VALUES('" + ino + "','" + serial + "','" + iname + "','" + selsPrice + "','" + purchPrice + "','" + tax + "','" + barcode + "','" + catogory + "','" + subCatory + "','" + brande + "','" + woraty + "','" + supp + "','" + tpe + "','" + descrip + "','" + qty + "','" + selct + "','" + amut + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();

        }


        public void delete_Invo_item(string No)
        {
            string sql = "DELETE FROM tbl_Invoice_Item WHERE Item_No='" + No + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();

        }



        public void Updte_Invo_item(string ino, string serial, string iname, decimal selsPrice, decimal purchPrice, decimal tax, string barcode, string catogory, string subCatory, string brande, string woraty,string supp,string tpe,string descrip,string qty,decimal amut)
        {
            string sql = "UPDATE tbl_Invoice_Item SET Serial_No='" + serial + "',Item_Name='" + iname + "',Sales_Price='" + selsPrice + "',Purchase_Price='" + purchPrice + "',Tax_Rate='" + tax + "',Barcode='" + barcode + "',Catogory='" + catogory + "',Sub_Catogory='" + subCatory + "',Brande='" + brande + "',Warranty='" + woraty + "',Supplier='" + supp + "',Item_Type='" + tpe + "',Discription='" + descrip + "',Quntity='" + qty + "',Amount='" + amut + "' WHERE Item_No='" + ino + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }



        public void insert_Invoice(string ivno, DateTime ivDate, decimal totPrice, decimal paidPrice,decimal balnce,string method, string discip, string slRef, string custNO, decimal grdtot,decimal disc ,decimal tax ,string pymnt)
        {
            string sql = @"INSERT INTO tbl_Invoice(Invoice_No,Invoice_Date,Description,Total_Price,Paid_Price,Balance,Payment_Method,Coustomer_No,Seals_ref,Grande_total,Discount,Tax,Payment)VALUES('" + ivno + "','" + ivDate + "','" + discip + "','" + totPrice + "','" + paidPrice + "','" + balnce + "','" + method + "','" + custNO + "','" + slRef + "','" + grdtot + "','" + disc + "','" + tax + "','" + pymnt + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();

        }


        public void insert_Invoice_detalis(string InvoNo, DateTime InvoDate, string ino, string serial, string iname, decimal selsPrice, decimal purchPrice, string barcode, string catogory, string subCatory, string brande, string woraty, string supp, string tpe, string descrip,decimal pofit,string satus,string qty)
        {
            string sql = @"INSERT INTO tbl_Invoice_details(Invoice_No,Invoice_Date,Item_No,Item_Name,Serial_No,Barcode,Sales_Price,Purchase_Price,Catogory,Sub_Catogory,Brande,Warranty,Supplier,Item_Type,Discription,Item_Profit,Status,Quntity)VALUES('" + InvoNo + "','" + InvoDate + "','" + ino + "','" + iname + "','" + serial + "','" + barcode + "','" + selsPrice + "','" + purchPrice + "','" + catogory + "','" + subCatory + "','" + brande + "','" + woraty + "','" + supp + "','" + tpe + "','" + descrip + "','" + pofit + "','" + satus + "','" + qty + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();


        }

///==================================================================
        public void insert_Invoice_Bill(string InvoNo, DateTime InvoDate, string cus, string add, string mob,  decimal GradTotal, decimal Discu, decimal tax, decimal Total, decimal paid, string payMethod, decimal Balnce,string itseril,string itctory,string itsubcty,string itbrnd,string descrip,decimal u_priz,decimal qty,decimal amut)
        {
            string sql = @"INSERT INTO tbl_Invoice_bill(Invoice_No,Invoice_Date,Customer,Address,Mobile,Grande_Total,Discount,Tax,Total,Paid,Payment_Methord,Balance,Serial_No,Brande,Sub_Catogory,Catogory,Description,Unit_Price,Quantity,Amount)VALUES('" + InvoNo + "','" + InvoDate + "','" + cus + "','" + add + "','" + mob + "','" + GradTotal + "','" + Discu + "','" + tax + "','" + Total + "','" + paid + "','" + payMethod + "','" + Balnce + "','" + itseril + "','" + itbrnd + "','" + itsubcty + "','" + itctory + "','" + descrip + "','" + u_priz + "','" + qty + "','" + amut + "')";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }

        public void Updte_invc_bill(string ctgy, string subCtgy,string brnd,decimal qty,decimal amut,string srial)
        {
            string sql = "UPDATE tbl_Invoice_bill SET Quantity='" + qty + "',Amount='" + amut + "',Serial_No='" + srial + "' WHERE Catogory='" + ctgy + "' AND Sub_Catogory='" + subCtgy + "' AND Brande='" + brnd + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }
        




        public void insertCus(string No, string FName, string LName, string AddLine1, string AddLine2,  string Mob,  string Email )
        {
            string Cucsql = "INSERT INTO tbl_Add_Customer(Coustomer_No,First_Name,Last_Name,Address_Line1,Address_Line2,Mobile,Email)VALUES('" + No + "','" + FName + "','" + LName + "','" + AddLine1 + "','" + AddLine2 + "','" + Mob + "','" + Email + "')";
            SqlCommand com = new SqlCommand(Cucsql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }



        public SqlDataReader select_inItm()
        {
            string sql = "SELECT*FROM tbl_Invoice_Item";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }

        public SqlDataReader select_inItm_br(string brcd)
        {
            string sql = "SELECT*FROM tbl_Invoice_Item WHERE  Barcode='"+brcd+"'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }




        public SqlDataReader select_incus(string cno)
        {
            string sql = "SELECT*FROM tbl_Add_Customer WHERE Coustomer_No='" + cno + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }



        public void delete_item(string No)
        {
            string sql = "DELETE FROM tbl_Add_Items WHERE Item_No='" + No + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }




        public DataSet all_Invoice()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT Invoice_No,Invoice_Date,Description,Total_Price,Paid_Price,Coustomer_No,Seals_ref,Payment FROM tbl_Invoice";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Invoice");
            return ds;
        }


        public SqlDataReader select_invoNo(string ino)
        {
            string sql = "SELECT*FROM tbl_Invoice WHERE Invoice_No='" + ino + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }




        public SqlDataReader select_itmPriz(string ivono, string itmno)
        {
            string sql = "SELECT*FROM tbl_Invoice_details WHERE Invoice_No='" + ivono + "' AND Item_No='" + itmno + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }





       


        public DataSet each_Item(string ino)
        {
            DataSet ds = new DataSet();
            string sql = "SELECT Item_No,Item_Name,Serial_No,Barcode,Sales_Price,Catogory,Sub_Catogory,Brande,Warranty,Supplier,Status FROM tbl_Invoice_details WHERE Invoice_No='" + ino + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            da.Fill(ds, "tbl_Invoice_details");
            return ds;
        }


        public void Updte_Invo_Payment(string ino,decimal paid,decimal ble,string pymt)
        {
            string sql = "UPDATE tbl_Invoice SET Paid_Price='" + paid + "',Balance='" + ble + "',Payment='" + pymt + "' WHERE Invoice_No='" + ino + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }



        public SqlDataReader select_inItm_qtyy(string ctgy,string sctgy,string brnd,string slct)
        {
            string sql = "SELECT*FROM tbl_Invoice_Item WHERE  Catogory='" + ctgy + "' AND Sub_Catogory='" + sctgy + "' AND Brande='" + brnd + "' AND Selct='" + slct + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        
        }


        public void Updte_Invo_item_qty(string catogory, string subCatory, string brande,string slct,decimal selsPrice,decimal purchPrice, string qty,decimal amut)
        {
            string sql = "UPDATE tbl_Invoice_Item SET Quntity='" + qty + "',Sales_Price='" + selsPrice + "',Purchase_Price='" + purchPrice + "',Amount='" + amut + "' WHERE Catogory='" + catogory + "' AND Sub_Catogory='" + subCatory + "' AND Brande='" + brande + "' AND Selct='" + slct + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            com.ExecuteNonQuery();
        }



        public SqlDataReader select_invtmp_bil(string ctgy, string sctgy, string brnd)
        {
            string sql = "SELECT*FROM tbl_Invoice_bill WHERE  Catogory='" + ctgy + "' AND Sub_Catogory='" + sctgy + "' AND Brande='" + brnd + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;

        }


        public SqlDataReader select_inItm_decrip(string ctgy)
        {
            string sql = "SELECT*FROM tbl_Invoice_Item WHERE  Catogory='" + ctgy + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;

        }

    }


}
