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
    public class busReceiveOrders
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public string insertRR(ReceiveOrders drsi)
        {
            string Message = string.Empty;
            int result = 0;
            SqlTransaction transaction;

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [inventory].[dbo].ReceiveOrders ([SupplierID],[CreatedById],[CreationDate],[IsCompleted],[IsSubmitted],[IsNew]) VALUES (@SupplierID,@CreatedById,getdate(),@IsCompleted,@IsSubmitted,@IsNew)", con);
            cmd.Parameters.AddWithValue("@SupplierID", drsi.SupplierID);
            cmd.Parameters.AddWithValue("@CreatedById", drsi.CreatedById);
            //cmd.Parameters.AddWithValue("@ExpectedDate", drsi.ExpectedDate);
            //cmd.Parameters.AddWithValue("@PaymentAmount", drsi.PaymentAmount);
            cmd.Parameters.AddWithValue("@IsCompleted", 1);
            cmd.Parameters.AddWithValue("@IsSubmitted", 1);
            cmd.Parameters.AddWithValue("@IsNew", 1);
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
            string query = "select top 1 ID from [ReceiveOrders] order by id desc";
            DataTable dt = new DataTable("Customer");
            dt.Clear();
            dt = DataAccess.DBAdapter.GetRecordSet(query);

            if (dt.Rows.Count > 0)
            {
                Message = dt.Rows[0]["ID"].ToString();
            }
            return Message;
        }

        public string insertReceiveOrderDetails(ReceiveOrderDetails drsi)
        {
            string Message = string.Empty;
            int result = 0;
            con.Open();
            SqlTransaction transaction;
            SqlCommand cmd = new SqlCommand("INSERT INTO [inventory].[dbo].ReceiveOrderDetails ([Quantity],[ReceiveOrderID],[ProductID],[IsSubmitted],[PostedToInventory]) VALUES (@Quantity,@ReceiveOrderID,@ProductID,@IsSubmitted,@PostedToInventory)", con);
            cmd.Parameters.AddWithValue("@Quantity", drsi.Quantity);
            //cmd.Parameters.AddWithValue("@UnitCost", drsi.UnitCost);
            cmd.Parameters.AddWithValue("@ReceiveOrderID", drsi.ReceiveOrderID);
            cmd.Parameters.AddWithValue("@ProductID", drsi.ProductID);

            cmd.Parameters.AddWithValue("@IsSubmitted", 1);

            cmd.Parameters.AddWithValue("@PostedToInventory", 1);
            transaction = con.BeginTransaction();
            cmd.Transaction = transaction;
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
            //string query = "select top 1 ID from [DRSIForm] order by id desc";
            //DataTable dt = new DataTable("Customer");
            //dt.Clear();
            //dt = DataAccess.DBAdapter.GetRecordSet(query);

            //if (dt.Rows.Count > 0)
            //{
            //    Message = dt.Rows[0]["ID"].ToString();
            //}
            return Message;
        }

        public FrameWork.DRSIForm[] allPO()
        {
            string query = "SELECT a.[ID] ,b.[Company],c.[ProductName],[TotalPcs],[TotalUOM],[TotalWeight],[TotalUnitCost],[TotalCost],[OrderDate],[OrderBy],[CheckBy]  FROM [inventory].[dbo].DRSIForm a inner join [Customers] b on a.CustomerFKID = b.ID inner join [Products] c on a.ProductFKID= c.ID";
            DataTable table = new DataTable();

            table = DataAccess.DBAdapter.GetRecordSet(query);
            FrameWork.DRSIForm[] dec = new FrameWork.DRSIForm[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                dec[i] = new FrameWork.DRSIForm(table.Rows[i]);
            }

            return dec;

        }
        public FrameWork.DRSISub[] allPurchaseOrderDetails(string ID)
        {
            string query = "SELECT [ID] ,[DRSiformID],[BatchNo],[ModuleNo],[CageNo],[Weight],[UnitOfMeasure]  FROM [inventory].[dbo].[DRSISub] where DRSiformID='" + ID + "'";
            DataTable table = new DataTable();

            table = DataAccess.DBAdapter.GetRecordSet(query);
            FrameWork.DRSISub[] dec = new FrameWork.DRSISub[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                dec[i] = new FrameWork.DRSISub(table.Rows[i]);
            }

            return dec;

        }
    }
}
