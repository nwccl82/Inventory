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
    public class busReceivedOrderFingerLings
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public string insertRR(ReceiveOrdersFinger drsi)
        {
            string Message = string.Empty;
            int result = 0;
            SqlTransaction transaction;

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].ReceiveOrdersFingerlings ([SupplierID],[CreatedById],[CreationDate],[IsCompleted],[IsSubmitted],[IsNew],[PurchaseOrderID],DateofShipment ,DateofArrival ,DateReceive ,TimeofShipment ,TimeofArrival ,TimeReceive ,ReoxygenationStart ,ReoxygenationEnd ,SalinityInsideTheBag ,TemperatureInsideTheBag ,TimeAfterReceiptFromAirport ,Mortality ,TimeofArrival1 ,TimeofStocking ,Mortality1 ,Deformed ,Injured ,Missing ) VALUES (@SupplierID,@CreatedById,getdate(),@IsCompleted,@IsSubmitted,@IsNew,@PurchaseOrderID,@DateofShipment ,@DateofArrival ,@DateReceive ,@TimeofShipment ,@TimeofArrival ,@TimeReceive ,@ReoxygenationStart ,@ReoxygenationEnd ,@SalinityInsideTheBag ,@TemperatureInsideTheBag ,@TimeAfterReceiptFromAirport ,@Mortality ,@TimeofArrival1 ,@TimeofStocking ,@Mortality1 ,@Deformed ,@Injured ,@Missing )", con);
            //cmd.CommandText = "InsertRR";
            cmd.Parameters.AddWithValue("@SupplierID", drsi.SupplierID);
            cmd.Parameters.AddWithValue("@CreatedById", drsi.CreatedById);
            //cmd.Parameters.AddWithValue("@ExpectedDate", drsi.ExpectedDate);
            //cmd.Parameters.AddWithValue("@PaymentAmount", drsi.PaymentAmount);
            cmd.Parameters.AddWithValue("@IsCompleted", 1);
            cmd.Parameters.AddWithValue("@IsSubmitted", 1);
            cmd.Parameters.AddWithValue("@IsNew", 1);
            cmd.Parameters.AddWithValue("@PurchaseOrderID", drsi.PurchaseOrderID);

            cmd.Parameters.AddWithValue("@DateofShipment", drsi.DateofShipment);
            cmd.Parameters.AddWithValue("@DateofArrival", drsi.DateofArrival);
            cmd.Parameters.AddWithValue("@DateReceive", drsi.DateReceive);
            cmd.Parameters.AddWithValue("@TimeofShipment ", drsi.TimeofShipment);
            cmd.Parameters.AddWithValue("@TimeofArrival", drsi.TimeofArrival);
            cmd.Parameters.AddWithValue("@TimeReceive", drsi.TimeReceive);
            cmd.Parameters.AddWithValue("@ReoxygenationStart", drsi.ReoxygenationStart);
            cmd.Parameters.AddWithValue("@ReoxygenationEnd", drsi.ReoxygenationEnd);
            cmd.Parameters.AddWithValue("@SalinityInsideTheBag", drsi.SalinityInsideTheBag);
            cmd.Parameters.AddWithValue("@TemperatureInsideTheBag", drsi.TemperatureInsideTheBag);
            cmd.Parameters.AddWithValue("@TimeAfterReceiptFromAirport", drsi.TimeAfterReceiptFromAirport);
            cmd.Parameters.AddWithValue("@Mortality", drsi.Mortality);
            cmd.Parameters.AddWithValue("@TimeofArrival1", drsi.TimeofArrival1);
            cmd.Parameters.AddWithValue("@TimeofStocking", drsi.TimeofStocking);
            cmd.Parameters.AddWithValue("@Mortality1", drsi.Mortality1);
            cmd.Parameters.AddWithValue("@Deformed", drsi.Deformed);
            cmd.Parameters.AddWithValue("@Injured", drsi.Injured);
            cmd.Parameters.AddWithValue("@Missing", drsi.Missing);

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

            string query = "select top 1 ID from [ReceiveOrdersFingerlings] order by id desc";
            DataTable dt = new DataTable("Customer");
            dt.Clear();
            dt = DataAccess.DBAdapter.GetRecordSet(query);

            if (dt.Rows.Count > 0)
            {
                Message = dt.Rows[0]["ID"].ToString();
            }
            con.Close();
            return Message;
        }

        public string insertReceiveOrderDetails(ReceiveOrdersFingerDetails drsi)
        {
            string Message = string.Empty;
            int result = 0;
            con.Open();
            SqlTransaction transaction;
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].ReceiveOrdersFingerlingsDetails ([Quantity],[ReceiveOrderID],[ProductID],[IsSubmitted],[PostedToInventory]) VALUES (@Quantity,@ReceiveOrderID,@ProductID,@IsSubmitted,@PostedToInventory)", con);
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

        public string insertReceiveOrderDetails2(ReceiveOrdersFingerDetails2 drsi)
        {
            string Message = string.Empty;
            int result = 0;
            con.Open();
            SqlTransaction transaction;
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].ReceiveOrdersFingerlingsDetails2 ([ModuleNum],[ReceiveOrderID],[CageNum],[Salinity],[Temp],[IsSubmitted],[PostedToInventory]) VALUES (@ModuleNum,@ReceiveOrderID,@CageNum,@Salinity,@Temp,@IsSubmitted,@PostedToInventory)", con);
            cmd.Parameters.AddWithValue("@ModuleNum", drsi.ModuleNum);
            //cmd.Parameters.AddWithValue("@UnitCost", drsi.UnitCost);
            cmd.Parameters.AddWithValue("@ReceiveOrderID", drsi.ReceiveOrderID);
            cmd.Parameters.AddWithValue("@CageNum", drsi.CageNum);
            cmd.Parameters.AddWithValue("@Salinity", drsi.Salinity);
            cmd.Parameters.AddWithValue("@Temp", drsi.Temp);

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
        public FrameWork.ReceiveOrders[] allPO()
        {
            string query = "SELECT a.[ID] ,b.[Company],b.[Address],[CreationDate],SupplierID, [ExpectedDate],[PaymentAmount],b.[TIN],b.[EmailAddress],a.[CreatedById],a.[ClosedById],b.[BusinessPhone]  FROM [dbo].ReceiveOrders a inner join [dbo].[Suppliers] b on a.SupplierID = b.ID order by a.id asc";
            DataTable table = new DataTable();

            table = DataAccess.DBAdapter.GetRecordSet(query);
            FrameWork.ReceiveOrders[] dec = new FrameWork.ReceiveOrders[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                dec[i] = new FrameWork.ReceiveOrders(table.Rows[i]);
            }

            return dec;

        }
        public FrameWork.ReceiveOrderDetails[] allPurchaseOrderDetails(string ID)
        {
            string query = "SELECT a.[ID] ,[Quantity],[UnitCost],[ProductID],[ProductName]  FROM [dbo].[ReceiveOrderDetails] a inner join [dbo].Products b on a.ProductID = b.ID  where ReceiveOrderID='" + ID + "' order by a.[ID] asc";
            DataTable table = new DataTable();

            table = DataAccess.DBAdapter.GetRecordSet(query);
            FrameWork.ReceiveOrderDetails[] dec = new FrameWork.ReceiveOrderDetails[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                dec[i] = new FrameWork.ReceiveOrderDetails(table.Rows[i]);
            }

            return dec;

        }

    }
}
