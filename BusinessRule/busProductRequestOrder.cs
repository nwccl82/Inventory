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
    public class busProductRequestOrder
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public string insertProductRequestOrder(ProductRequestOrder pro)
        {
            string Message = string.Empty;
            int result = 0;
            SqlTransaction transaction;

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].ProductRequestOrders ([SupplierID],[CreatedById],[CreationDate],[ExpectedDate],[PaymentAmount],[IsCompleted],[IsSubmitted],[IsNew]) VALUES (@SupplierID,@CreatedById,getdate(),@ExpectedDate,@PaymentAmount,@IsCompleted,@IsSubmitted,@IsNew)", con);

            cmd.Parameters.AddWithValue("@SupplierID", pro.SupplierID);
            cmd.Parameters.AddWithValue("@CreatedById", pro.CreatedById);
            cmd.Parameters.AddWithValue("@ExpectedDate", pro.ExpectedDate);
            cmd.Parameters.AddWithValue("@PaymentAmount", pro.PaymentAmount);
            cmd.Parameters.AddWithValue("@IsCompleted", 1);
            cmd.Parameters.AddWithValue("@IsSubmitted", 1);
            cmd.Parameters.AddWithValue("@IsNew", 1);
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
            string query = "select top 1 ID from [ProductRequestOrders] order by id desc";
            DataTable dt = new DataTable("Customer");
            dt.Clear();
            dt = DataAccess.DBAdapter.GetRecordSet(query);

            if (dt.Rows.Count > 0)
            {
                Message = dt.Rows[0]["ID"].ToString();
            }
            return Message;
        }

        public string insertProductRequestOrderDetails(ProductRequestOrderDetails prod)
        {
            string Message = string.Empty;
            int result = 0;
            SqlTransaction transaction;
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].ProductRequestOrdersDetails ([Quantity],[UnitCost],[ProductRequestOrderID],[ProductID],[IsSubmitted],[PostedToInventory]) VALUES (@Quantity,@UnitCost,@ProductRequestOrderID,@ProductID,@IsSubmitted,@PostedToInventory)", con);
            
            cmd.Parameters.AddWithValue("@Quantity", prod.Quantity);
            cmd.Parameters.AddWithValue("@UnitCost", prod.UnitCost);
            cmd.Parameters.AddWithValue("@ProductRequestOrderID", prod.ProductRequestOrderID);
            cmd.Parameters.AddWithValue("@ProductID", prod.ProductID);
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
            return Message;
        }

        public ProductRequestOrder[] retrieveProductRequestOrder()
        {
            string query = "SELECT a.[ID] ,b.[Company],b.[Address],[CreationDate],SupplierID, [ExpectedDate],[PaymentAmount],b.[TIN],b.[EmailAddress],a.[CreatedById],a.[ClosedById],b.[BusinessPhone]  FROM [dbo].ProductRequestOrders a inner join [dbo].[Suppliers] b on a.SupplierID = b.ID order by a.id asc";
            DataTable table = new DataTable();

            table = DataAccess.DBAdapter.GetRecordSet(query);
            ProductRequestOrder[] dec = new ProductRequestOrder[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                dec[i] = new ProductRequestOrder(table.Rows[i]);
            }

            return dec;
        }

        public ProductRequestOrderDetails[] retrieveProductRequestOrderDetails(string ID)
        {
            string query = "SELECT a.[ID] ,[Quantity],[UnitCost],[ProductID],[ProductName]  FROM [dbo].[ProductRequestOrdersDetails] a inner join [dbo].Products b on a.ProductID = b.ID  where ProductRequestOrderID='" + ID + "' order by a.[ID] asc";
            DataTable table = new DataTable();

            table = DataAccess.DBAdapter.GetRecordSet(query);
            ProductRequestOrderDetails[] dec = new ProductRequestOrderDetails[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                dec[i] = new ProductRequestOrderDetails(table.Rows[i]);
            }

            return dec;
        }
    }
}