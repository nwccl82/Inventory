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
    public class busColors
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public DataTable allCategories()
        {
            //FrameWork.Login log = new FrameWork.Login();
            //DataTable logDt = new DataTable("Hello");
            //logDt = log.UserTable;

            DataTable dt = new DataTable("Colors");
            dt.Clear();

            string query = "Select  [ID] ,[Colors]  FROM [inventory].[dbo].[Color]";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            return dt;
        }
        public Color isUserExisting(string Category)
        {
            DataTable dt = new DataTable("Colors");
            dt.Clear();
            string query = "SELECT * FROM Color where Colors='" + Category + "'";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            Color log = null;
            if (dt.Rows.Count > 0)
            {
                log = new Color(dt.Rows[0]);
            }
            return log;
        }
        public string insertCategory(Color cats)
        {
            string Message = string.Empty;
            int result = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Color]([Colors]) VALUES (@Colors)", con);
            cmd.Parameters.AddWithValue("@Colors", cats.Colors);

            result = cmd.ExecuteNonQuery();


            con.Close();
            return Message;
        }
    }
}
