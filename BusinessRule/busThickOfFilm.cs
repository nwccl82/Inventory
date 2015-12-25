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
    public class busThickOfFilm
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public DataTable allCategories()
        {
            //FrameWork.Login log = new FrameWork.Login();
            //DataTable logDt = new DataTable("Hello");
            //logDt = log.UserTable;

            DataTable dt = new DataTable("ThickOfFilm");
            dt.Clear();

            string query = "Select  [ID] ,[Thickness]  FROM [dbo].[ThickOfFilm]";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            return dt;
        }
        public ThickOfFilm isUserExisting(string Category)
        {
            DataTable dt = new DataTable("Thickness");
            dt.Clear();
            string query = "SELECT * FROM ThickOfFilm where Thickness='" + Category + "'";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            ThickOfFilm log = null;
            if (dt.Rows.Count > 0)
            {
                log = new ThickOfFilm(dt.Rows[0]);
            }
            return log;
        }
        public string insertCategory(ThickOfFilm cats)
        {
            string Message = string.Empty;
            int result = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [ThickOfFilm]([Thickness]) VALUES (@Thickness)", con);
            cmd.Parameters.AddWithValue("@Thickness", cats.Thickness);

            result = cmd.ExecuteNonQuery();


            con.Close();
            return Message;
        }
    }
}
