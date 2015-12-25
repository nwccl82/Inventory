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
    public class busDailyMonitoring
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public string insertDailyMonitoring(DailyMonitoring drsi)
        {
            string Message = string.Empty;
            int result = 0;
            SqlTransaction transaction;

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[DailyMonitoring] ([DateofTrans],[TimeofTrans],[ProdID],[ItemDescription],[BatchNo],[ModuleNo],[CageNo],[TotalCount],[Dead],[Deform],[Age],[Salinity],[Temp],[Weather],[WeightofFood],[RecordedBy],[CreationDate],[CheckBy],[RRID]) VALUES (@DateofTrans ,@TimeofTrans ,@ProdID ,@ItemDescription ,@BatchNo ,@ModuleNo ,@CageNo ,@TotalCount ,@Dead ,@Deform ,@Age ,@Salinity ,@Temp ,@Weather ,@WeightofFood ,@RecordedBy ,getdate() ,@CheckBy,@RRID )", con);
            //cmd.CommandText = "InsertRR";
            cmd.Parameters.AddWithValue("@DateofTrans", drsi.DateofTrans);
            cmd.Parameters.AddWithValue("@TimeofTrans", drsi.TimeofTrans);
            cmd.Parameters.AddWithValue("@ProdID", drsi.ProdID);
            cmd.Parameters.AddWithValue("@ItemDescription", drsi.ItemDescription);
            cmd.Parameters.AddWithValue("@BatchNo", drsi.BatchNo);
            cmd.Parameters.AddWithValue("@ModuleNo", drsi.ModuleNo);
            cmd.Parameters.AddWithValue("@CageNo", drsi.CageNo);
            cmd.Parameters.AddWithValue("@TotalCount", drsi.TotalCount);
            cmd.Parameters.AddWithValue("@Dead", drsi.Dead);
            cmd.Parameters.AddWithValue("@Deform", drsi.Deform);
            cmd.Parameters.AddWithValue("@Age", drsi.Age);
            cmd.Parameters.AddWithValue("@Salinity", drsi.Salinity);
            cmd.Parameters.AddWithValue("@Temp", drsi.Temp);
            cmd.Parameters.AddWithValue("@Weather", drsi.Weather);
            cmd.Parameters.AddWithValue("@WeightofFood", drsi.WeightofFood);
            cmd.Parameters.AddWithValue("@RecordedBy", drsi.RecordedBy);
            cmd.Parameters.AddWithValue("@CheckBy", drsi.CheckBy);
            cmd.Parameters.AddWithValue("@RRID", drsi.RRID);
            transaction = con.BeginTransaction();
            cmd.Transaction = transaction;
            //cmd.Parameters.AddWithValue("@OrderBy", drsi.OrderBy);
            //cmd.Parameters.AddWithValue("@CheckBy", drsi.CheckBy != null ? drsi.CheckBy : string.Empty);
            try
            {
                result = cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    // This catch block will handle any errors that may have occurred 
                    // on the server that would cause the rollback to fail, such as 
                    // a closed connection.
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
            }
            con.Close();
            string query = "select top 1 ID from [DailyMonitoring] order by id desc";
            DataTable dt = new DataTable("Customer");
            dt.Clear();
            dt = DataAccess.DBAdapter.GetRecordSet(query);

            if (dt.Rows.Count > 0)
            {
                Message = dt.Rows[0]["ID"].ToString();
            }
            return Message;
        }
        public string ProductsWareHouse(ProductsWareHouse drsi)
        {
            string Message = string.Empty;
            int result = 0;
            SqlTransaction transaction;

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[ProductsWareHouse] ([ProductId],[Out],[Return],[DateEntered]) VALUES (@ProductId ,@Out ,@Return ,getdate())", con);
            //cmd.CommandText = "InsertRR";
            cmd.Parameters.AddWithValue("@ProductId", drsi.ProductId);
            cmd.Parameters.AddWithValue("@Out", drsi.Out);
            cmd.Parameters.AddWithValue("@Return", drsi.Return);
            //cmd.Parameters.AddWithValue("@DateEntered", drsi.DateEntered);
            transaction = con.BeginTransaction();
            cmd.Transaction = transaction;
            //cmd.Parameters.AddWithValue("@OrderBy", drsi.OrderBy);
            //cmd.Parameters.AddWithValue("@CheckBy", drsi.CheckBy != null ? drsi.CheckBy : string.Empty);
            try
            {
                result = cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    // This catch block will handle any errors that may have occurred 
                    // on the server that would cause the rollback to fail, such as 
                    // a closed connection.
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
            }
            con.Close();
            string query = "select top 1 ID from [ProductsWareHouse] order by id desc";
            DataTable dt = new DataTable("Customer");
            dt.Clear();
            dt = DataAccess.DBAdapter.GetRecordSet(query);

            if (dt.Rows.Count > 0)
            {
                Message = dt.Rows[0]["ID"].ToString();
            }
            return Message;
        }
    }
}
