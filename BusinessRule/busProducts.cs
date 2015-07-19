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
    public class busProducts
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public DataTable allProducts()
        {
            //FrameWork.Login log = new FrameWork.Login();
            //DataTable logDt = new DataTable("Hello");
            //logDt = log.UserTable;

            DataTable dt = new DataTable("Categories");
            dt.Clear();

            string query = "Select  [ID] ,[ProductName],[ProductCode],[Description] ,[UnitOfMeasureID] ,[CategoryID] ,[ProductSizeID]   FROM [inventory].[dbo].[Products]";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            return dt;
        }
        public FrameWork.Products isUserExisting(string ProdName)
        {
            DataTable dt = new DataTable("Category");
            dt.Clear();
            string query = "SELECT * FROM Products where ProductName='" + ProdName + "'";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            Products log = null;
            if (dt.Rows.Count > 0)
            {
                log = new Products(dt.Rows[0]);
            }
            return log;
        }
        public string insertProducts(FrameWork.Products prods)
        {
            string Message = string.Empty;
            int result = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Products]([ProductName],[ProductCode],[Description] ,[UnitOfMeasureID] ,[CategoryID] ,[ProductSizeID],[Discontinued]) VALUES (@ProductName,@ProductCode,@Description ,@UnitOfMeasureID ,@CategoryID ,@ProductSizeID,@Discontinued)", con);
            cmd.Parameters.AddWithValue("@ProductName", prods.ProductName);
            cmd.Parameters.AddWithValue("@ProductCode", prods.ProductCode);
            cmd.Parameters.AddWithValue("@Description", prods.Description);
            cmd.Parameters.AddWithValue("@UnitOfMeasureID", prods.UnitOfMeasureID);
            cmd.Parameters.AddWithValue("@CategoryID", prods.CategoryID);
            cmd.Parameters.AddWithValue("@ProductSizeID", prods.ProductSizeID);
            cmd.Parameters.AddWithValue("@Discontinued", 1);
            
            result = cmd.ExecuteNonQuery();


            con.Close();
            return Message;
        }
    }
}
