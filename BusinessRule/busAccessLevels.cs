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
    public class busAccessLevels
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public DataTable allAccessLevel()
        {
            //FrameWork.Login log = new FrameWork.Login();
            //DataTable logDt = new DataTable("Hello");
            //logDt = log.UserTable;

            DataTable dt = new DataTable("allAccessLevel");
            dt.Clear();

            string query = "Select  [IDAccess] ,[AccessName], AccessDef  FROM [dbo].[AccessLevels]";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            return dt;
        }
    }
}
