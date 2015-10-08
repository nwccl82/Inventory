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
    public class busLength
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public DataTable allCategories()
        {
            //FrameWork.Login log = new FrameWork.Login();
            //DataTable logDt = new DataTable("Hello");
            //logDt = log.UserTable;

            DataTable dt = new DataTable("Length");
            dt.Clear();

            string query = "Select  [ID] ,[Lengths]  FROM [inventory].[dbo].[Length]";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            return dt;
        }
        public FrameWork.Length isUserExisting(string Category)
        {
            DataTable dt = new DataTable("Length");
            dt.Clear();
            string query = "SELECT * FROM Length where Lengths='" + Category + "'";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            FrameWork.Length log = null;
            if (dt.Rows.Count > 0)
            {
                log = new FrameWork.Length(dt.Rows[0]);
            }
            return log;
        }
        public string insertCategory(FrameWork.Length cats)
        {
            string Message = string.Empty;
            int result = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Length]([Lengths]) VALUES (@Length)", con);
            cmd.Parameters.AddWithValue("@Length", cats.Lengths);

            result = cmd.ExecuteNonQuery();


            con.Close();
            return Message;
        }
    }
}
