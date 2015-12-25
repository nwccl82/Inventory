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
    public class busEmployees
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);



        public string insertEmployee(Employees emp)
        {
            string Message = string.Empty;
            int result = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Employees]([Email] ,[FullName] ,[Login],passwords,LastName,IDAccess) VALUES (@Email,@FullName,@Login,@passwords,@LastName,@IDAccess)", con);
            cmd.Parameters.AddWithValue("@Email", emp.Email);
            cmd.Parameters.AddWithValue("@FullName", emp.FullName);
            cmd.Parameters.AddWithValue("@Login", emp.Login);
            cmd.Parameters.AddWithValue("@passwords", emp.passwords);
            cmd.Parameters.AddWithValue("@LastName", emp.LastName);
            cmd.Parameters.AddWithValue("@IDAccess", emp.IDAccess);


            //result = cmd.ExecuteNonQuery();
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
            finally
            {
                con.Close();
                Message = string.Empty;
            }

        
            return Message;
        }
        public FrameWork.Employees[] Retrieve()
        {
            string query = "SELECT [ID] ,[Email],[FullName],[LastName],[Login]  FROM [dbo].[Employees]";
            DataTable table = new DataTable();

            table = DataAccess.DBAdapter.GetRecordSet(query);
            FrameWork.Employees[] dec = new FrameWork.Employees[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                dec[i] = new FrameWork.Employees(table.Rows[i]);
            }

            return dec;
        }

        public DataTable allUser()
        {
            //FrameWork.Login log = new FrameWork.Login();
            //DataTable logDt = new DataTable("Hello");
            //logDt = log.UserTable;

            DataTable dt = new DataTable("Patients");
            dt.Clear();

            string query = "Select  [ID] ,[Email],[FullName],[LastName],[Login]  FROM [dbo].[Employees]";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            return dt;
        }

        public Employees isUserExisting(string userid)
        {
            DataTable dt = new DataTable("Customer");
            dt.Clear();
            string query = "SELECT * FROM Employees where Login='" + userid + "'";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            Employees log = null;
            if (dt.Rows.Count > 0)
            {
                log = new Employees(dt.Rows[0]);
            }
            return log;
        }

        public FrameWork.Employees Retrieve1(string user, string pass)
        {
            string query = "SELECT [ID] ,[Email],[FullName],[Login]  FROM [dbo].[Employees] where login = '"+ user +"' and passwords ='"+ pass +"'";
            DataTable table = new DataTable();

            table = DataAccess.DBAdapter.GetRecordSet(query);
            FrameWork.Employees dec =null;

            if (table.Rows.Count > 0)
            {
                dec = new FrameWork.Employees(table.Rows[0]);
            }

            return dec;
        }
    }
}
