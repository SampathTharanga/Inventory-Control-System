using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace Inventory_System
{
    class ConnectionDB
    {

        public static SqlConnection Connection()
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Enjoy my Lfie\My Kindom\Software Development\C#.net\Project\Inventory System\Inventory System\bin\Release\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30";
            //string ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=H:\Inventory\Inventory System\Inventory System\InventoryDB.mdf;Integrated Security=True;User Instance=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            return con;
        }


        public static SqlConnection Connection_tmp()
        {
            string ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|InventoryDB_tmp.mdf;Integrated Security=True;User Instance=True";
            //string ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=H:\Inventory\Inventory System\Inventory System\InventoryDB_tmp.mdf;Integrated Security=True;User Instance=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            return con;
        }
    }
}
