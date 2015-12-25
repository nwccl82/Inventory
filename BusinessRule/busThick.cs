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
    public class busThick
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public DataTable allCategories()
        {
            //FrameWork.Login log = new FrameWork.Login();
            //DataTable logDt = new DataTable("Hello");
            //logDt = log.UserTable;

            DataTable dt = new DataTable("ThickOfFilm");
            dt.Clear();

            string query = "Select  [ID] ,[Thickness]  FROM [dbo].[Thick]";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            return dt;
        }
        public Thick isUserExisting(string Category)
        {
            DataTable dt = new DataTable("Thickness");
            dt.Clear();
            string query = "SELECT * FROM Thick where Thickness='" + Category + "'";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            Thick log = null;
            if (dt.Rows.Count > 0)
            {
                log = new Thick(dt.Rows[0]);
            }
            return log;
        }
        public string insertCategory(Thick cats)
        {
            string Message = string.Empty;
            int result = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Thick]([Thickness]) VALUES (@Thick)", con);
            cmd.Parameters.AddWithValue("@Thick", cats.Thickness);

            result = cmd.ExecuteNonQuery();


            con.Close();
            return Message;
        }
    }
}
