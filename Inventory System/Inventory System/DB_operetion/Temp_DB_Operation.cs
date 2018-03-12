using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Inventory_System
{
    class Temp_DB_Operation
    {

        Item_DB_Operation itemdb = new Item_DB_Operation();
        Order_DB_Operetion odr = new Order_DB_Operetion();
        Customer_DB_Operation CusOp = new Customer_DB_Operation();
        Supplier_DB_Operetion suppOp = new Supplier_DB_Operetion();

        public void invetry_insert()
        {
            String iisql = "SELECT*FROM tbl_catogory";
            SqlDataAdapter iiget = new SqlDataAdapter(iisql, ConnectionDB.Connection_tmp());
            DataTable iins = new DataTable();
            iiget.Fill(iins);
            for (int ii = 0; ii < iins.Rows.Count; ii++)
            {
                string ctgy = iins.Rows[ii]["catogory"].ToString();
                itemdb.catogary(ctgy);
            }

            String iisqls = "SELECT*FROM tbl_sub_catogory";
            SqlDataAdapter iigets = new SqlDataAdapter(iisqls, ConnectionDB.Connection_tmp());
            DataTable iinss = new DataTable();
            iigets.Fill(iinss);
            for (int iis = 0; iis < iinss.Rows.Count; iis++)
            {
                string ctgy = iinss.Rows[iis]["catogory"].ToString();
                string subCty = iinss.Rows[iis]["sub_catogory"].ToString();
                itemdb.Subcatogary(subCty,ctgy);
            }

            String iisqlb = "SELECT*FROM tbl_brande";
            SqlDataAdapter iigetb = new SqlDataAdapter(iisqlb, ConnectionDB.Connection_tmp());
            DataTable iinsb = new DataTable();
            iigetb.Fill(iinsb);
            for (int iib = 0; iib < iinsb.Rows.Count; iib++)
            {
                string brnd = iinsb.Rows[iib]["Brande"].ToString();
                itemdb.brande(brnd);
            }

            String iisqlt = "SELECT*FROM tbl_itype";
            SqlDataAdapter iigett = new SqlDataAdapter(iisqlt, ConnectionDB.Connection_tmp());
            DataTable iinst = new DataTable();
            iigett.Fill(iinst);
            for (int iit = 0; iit < iinst.Rows.Count; iit++)
            {
                string ttyp = iinst.Rows[iit]["Item_type"].ToString();
                itemdb.itype(ttyp);
            }
        
        
        }

        public void custo_insrt()
        {
            String iisql = "SELECT*FROM tbl_Add_Customer";
            SqlDataAdapter iiget = new SqlDataAdapter(iisql, ConnectionDB.Connection_tmp());
            DataTable iins = new DataTable();
            iiget.Fill(iins);
            for (int ii = 0; ii < iins.Rows.Count; ii++)
            {
                string Coustomer_No, First_Name, Last_Name, Bussiness_Name, Address_Line1, Address_Line2, City, Zip_Postal_Code, Phone, Mobile, Fax, Discount, Email, Notes;
                Coustomer_No = iins.Rows[ii]["Coustomer_No"].ToString();
                First_Name = iins.Rows[ii]["First_Name"].ToString();
                Bussiness_Name = iins.Rows[ii]["Bussiness_Name"].ToString();
                Address_Line1 = iins.Rows[ii]["Address_Line1"].ToString();
                Address_Line2 = iins.Rows[ii]["Address_Line2"].ToString();
                Last_Name = iins.Rows[ii]["Last_Name"].ToString();
                City = iins.Rows[ii]["City"].ToString();
                Zip_Postal_Code = iins.Rows[ii]["Zip_Postal_Code"].ToString();
                Phone = iins.Rows[ii]["Phone"].ToString();
                Mobile = iins.Rows[ii]["Mobile"].ToString();
                Fax = iins.Rows[ii]["Fax"].ToString();
                Discount = iins.Rows[ii]["Discount"].ToString();
                Email = iins.Rows[ii]["Email"].ToString();
                Notes = iins.Rows[ii]["Notes"].ToString();

                CusOp.insert(Coustomer_No, First_Name, Last_Name, Bussiness_Name, Address_Line1, Address_Line2, City, Zip_Postal_Code, Phone, Mobile, Fax, Discount, Email, Notes);
            }
        
        }

        public void supp_insrt()
        {
            String iisql = "SELECT*FROM tbl_AddS_Supplier";
            SqlDataAdapter iiget = new SqlDataAdapter(iisql, ConnectionDB.Connection_tmp());
            DataTable iins = new DataTable();
            iiget.Fill(iins);
            for (int ii = 0; ii < iins.Rows.Count; ii++)
            {
                string Supplier_No, First_Name, Last_Name, Business_Name, Address_Line1, Address_Line2, City, Phone, Mobile, Fax, Zip_Postal_Code, Email, Notes;
                Supplier_No = iins.Rows[ii]["Supplier_No"].ToString();
                First_Name = iins.Rows[ii]["First_Name"].ToString();
                Business_Name = iins.Rows[ii]["Business_Name"].ToString();
                Address_Line1 = iins.Rows[ii]["Address_Line1"].ToString();
                Address_Line2 = iins.Rows[ii]["Address_Line2"].ToString();
                Last_Name = iins.Rows[ii]["Last_Name"].ToString();
                City = iins.Rows[ii]["City"].ToString();
                Zip_Postal_Code = iins.Rows[ii]["Zip_Postal_Code"].ToString();
                Phone = iins.Rows[ii]["Phone"].ToString();
                Mobile = iins.Rows[ii]["Mobile"].ToString();
                Fax = iins.Rows[ii]["Fax"].ToString();
                Email = iins.Rows[ii]["Email"].ToString();
                Notes = iins.Rows[ii]["Notes"].ToString();

                suppOp.insert(Supplier_No, First_Name, Last_Name, Business_Name, Address_Line1, Address_Line2, City, Phone, Mobile, Fax, Zip_Postal_Code, Email, Notes);
            }

        }
    }
}
