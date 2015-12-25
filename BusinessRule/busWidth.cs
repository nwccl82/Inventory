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
    public class busWidth
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public DataTable allCategories()
        {
            //FrameWork.Login log = new FrameWork.Login();
            //DataTable logDt = new DataTable("Hello");
            //logDt = log.UserTable;

            DataTable dt = new DataTable("Width");
            dt.Clear();

            string query = "Select  [ID] ,[Widths]  FROM [dbo].[Width]";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            return dt;
        }
        public FrameWork.Width isUserExisting(string Category)
        {
            DataTable dt = new DataTable("Width");
            dt.Clear();
            string query = "SELECT * FROM Width where Widths='" + Category + "'";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            FrameWork.Width log = null;
            if (dt.Rows.Count > 0)
            {
                log = new FrameWork.Width(dt.Rows[0]);
            }
            return log;
        }
        public string insertCategory(FrameWork.Width cats)
        {
            string Message = string.Empty;
            int result = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Width]([Widths]) VALUES (@Widths)", con);
            cmd.Parameters.AddWithValue("@Widths", cats.Widths);

            result = cmd.ExecuteNonQuery();


            con.Close();
            return Message;
        }
    }
}
