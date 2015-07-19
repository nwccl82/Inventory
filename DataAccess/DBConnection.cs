using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class DBConnection
    {
        static SqlConnection con = null;
        static string ConnectionStr;
        //= ConfigurationManager.ConnectionStrings["ECS_MED_SUITEConnectionString"].ConnectionString;//"Data Source = 192.168.99.143\\medisuitetest; Initial Catalog= ECS_MED_SUITE_NEW; UID = sa; pwd = m3d1l1nk";
        //static string ConnectionStr = "Data Source = 210.8.1.53\\mnisqldb_2; Initial Catalog= ECS_MED_SUITE_NEW; UID = sa; pwd = m3d1l1nk";
        //static string ConnectionStr = "Data Source = 210.8.1.55\\medisuite; Initial Catalog= ECS_MED_SUITE; UID = sa; pwd = m3d1l1nk09";

        public static SqlConnection connect()
        {
            GetConnectionStr();
            if (con == null)
            {
                con = new SqlConnection(ConnectionStr);

            }
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();


            return con;
        }

        public static void GetConnectionStr()
        {
            //  ConnectionStr = EncDec.EncDecPass.Decrypt(ConfigurationManager.ConnectionStrings["ECS_MED_SUITEConnectionString"].ConnectionString, "3m3dsu!t3");
            ConnectionStr = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        }
    }
}
