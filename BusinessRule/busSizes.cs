using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrameWork;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace BusinessRule
{
    public class busSizes
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public DataTable allSize()
        {
            //FrameWork.Login log = new FrameWork.Login();
            //DataTable logDt = new DataTable("Hello");
            //logDt = log.UserTable;

            DataTable dt = new DataTable("sizes");
            dt.Clear();

            string query = "Select  [ID] ,[ProductSize]  FROM [inventory].[dbo].[Sizes]";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            return dt;
        }
        public Sizes isUserExisting(string sizes)
        {
            DataTable dt = new DataTable("Category");
            dt.Clear();
            string query = "SELECT * FROM Sizes where ProductSize='" + sizes + "'";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            Sizes log = null;
            if (dt.Rows.Count > 0)
            {
                log = new Sizes(dt.Rows[0]);
            }
            return log;
        }
        public string insertSizes(Sizes cats)
        {
            string Message = string.Empty;
            int result = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Sizes]([ProductSize]) VALUES (@ProductSize)", con);
            cmd.Parameters.AddWithValue("@ProductSize", cats.ProductSize);

            result = cmd.ExecuteNonQuery();


            con.Close();
            return Message;
        }
    }
}
