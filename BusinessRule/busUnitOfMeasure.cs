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
    public class busUnitOfMeasure
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public DataTable allUOM()
        {
            //FrameWork.Login log = new FrameWork.Login();
            //DataTable logDt = new DataTable("Hello");
            //logDt = log.UserTable;

            DataTable dt = new DataTable("UOM");
            dt.Clear();

            string query = "Select  [ID] ,[UnitOfMeasure]  FROM [dbo].[UnitOfMeasures]";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            return dt;
        }
        public UnitOfMeasures isUserExisting(string sizes)
        {
            DataTable dt = new DataTable("Category");
            dt.Clear();
            string query = "SELECT * FROM UnitOfMeasures where UnitOfMeasure='" + sizes + "'";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            UnitOfMeasures log = null;
            if (dt.Rows.Count > 0)
            {
                log = new UnitOfMeasures(dt.Rows[0]);
            }
            return log;
        }
        public string insertMeasures(UnitOfMeasures cats)
        {
            string Message = string.Empty;
            int result = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [UnitOfMeasures]([UnitOfMeasure]) VALUES (@UnitOfMeasure)", con);
            cmd.Parameters.AddWithValue("@UnitOfMeasure", cats.UnitOfMeasure);

            result = cmd.ExecuteNonQuery();


            con.Close();
            return Message;
        }
    }
}
