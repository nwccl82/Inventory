using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DBAdapter
    {

        public static DataTable GetRecordSet(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, DBConnection.connect());
            DataTable table = new DataTable();
            adapter.Fill(table);
            //DBConnection.connect().Close();
            return table;
            // DBConnection.connect().Dispose();
            //DBConnection.connect().Close();
        }

        //public static DataTable GetGPRecordSet(string query)
        //{
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, DBGPConnection.connect());
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;
        //}

        //public static DataTable GetClaimsRecordSet(string query)
        //{
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, DBClaimsConnection.connect());
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;
        //}
    }
}
