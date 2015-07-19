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
    public class busCategories
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public DataTable allCategories()
        {
            //FrameWork.Login log = new FrameWork.Login();
            //DataTable logDt = new DataTable("Hello");
            //logDt = log.UserTable;

            DataTable dt = new DataTable("Categories");
            dt.Clear();

            string query = "Select  [ID] ,[Category]  FROM [inventory].[dbo].[Categories]";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            return dt;
        }
        public Categories isUserExisting(string Category)
        {
            DataTable dt = new DataTable("Category");
            dt.Clear();
            string query = "SELECT * FROM Categories where Category='" + Category + "'";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            Categories log = null;
            if (dt.Rows.Count > 0)
            {
                log = new Categories(dt.Rows[0]);
            }
            return log;
        }
        public string insertCategory(Categories cats)
        {
            string Message = string.Empty;
            int result = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Categories]([Category]) VALUES (@Category)", con);
            cmd.Parameters.AddWithValue("@Category", cats.Category);
       
            result = cmd.ExecuteNonQuery();


            con.Close();
            return Message;
        }
    }
}
