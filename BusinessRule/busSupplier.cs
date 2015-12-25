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
    public class busSupplier
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
     
        public string insertSupplier(Suppliers supps)
        {
            string Message = string.Empty;
            int result = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Suppliers]([Company],[LastName],[FirstName],[EmailAddress],[JobTitle],[BusinessPhone],[HomePhone],[MobilePhone],[FaxNumber],[Address],[City],[StateProvince],[ZipPostal],[CountryRegion],[WebPage],[Notes],[Attachments],[SupplierName],[FileAs],[TIN]) VALUES (@Company,@LastName, @FirstName,@EmailAddress, @JobTitle, @BusinessPhone, @HomePhone, @MobilePhone, @FaxNumber, @Address, @City, @StateProvince, @ZipPostal, @CountryRegion, @WebPage, @Notes, @Attachments,@SupplierName,@FileAs,@TIN )", con);
           // cmd.Parameters.AddWithValue("@Suppliers", supps.Suppliers);
            cmd.Parameters.AddWithValue("@Company", supps.Company);
            cmd.Parameters.AddWithValue("@LastName", supps.LastName);
            cmd.Parameters.AddWithValue("@FirstName", supps.FirstName);
            cmd.Parameters.AddWithValue("@EmailAddress", supps.EmailAddress);
            cmd.Parameters.AddWithValue("@JobTitle", supps.JobTitle);
            cmd.Parameters.AddWithValue("@BusinessPhone", supps.BusinessPhone);
            cmd.Parameters.AddWithValue("@HomePhone", supps.HomePhone!= null ? supps.HomePhone: string.Empty);
            cmd.Parameters.AddWithValue("@MobilePhone", supps.MobilePhone != null ? supps.MobilePhone : string.Empty);
            cmd.Parameters.AddWithValue("@FaxNumber", supps.FaxNumber != null ? supps.FaxNumber : string.Empty);
            cmd.Parameters.AddWithValue("@Address", supps.Address != null ? supps.Address : string.Empty);
            cmd.Parameters.AddWithValue("@City", supps.City != null ? supps.City : string.Empty);
            cmd.Parameters.AddWithValue("@StateProvince", supps.StateProvince != null ? supps.StateProvince : string.Empty);
            cmd.Parameters.AddWithValue("@ZipPostal", supps.ZipPostal != null ? supps.ZipPostal : string.Empty);
            cmd.Parameters.AddWithValue("@CountryRegion", supps.CountryRegion != null ? supps.CountryRegion : string.Empty);
            cmd.Parameters.AddWithValue("@WebPage", supps.WebPage != null ? supps.WebPage : string.Empty);
            cmd.Parameters.AddWithValue("@Notes", supps.Notes != null ? supps.Notes : string.Empty);
            cmd.Parameters.AddWithValue("@SupplierName", supps.SupplierName != null ? supps.SupplierName : string.Empty);
            cmd.Parameters.AddWithValue("@FileAs", supps.FileAs != null ? supps.FileAs : string.Empty);
            cmd.Parameters.AddWithValue("@Attachments", supps.Attachments != null ? supps.Attachments : string.Empty);
            cmd.Parameters.AddWithValue("@TIN", supps.TIN != null ? supps.TIN : string.Empty);



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
            //string query = "select top 1 ID from [DRSIForm] order by id desc";
            //DataTable dt = new DataTable("Customer");
            //dt.Clear();
            //dt = DataAccess.DBAdapter.GetRecordSet(query);

            //if (dt.Rows.Count > 0)
            //{
            //    Message = dt.Rows[0]["ID"].ToString();
            //}
         
        }
        public DataTable allSupplier()
        {
            //FrameWork.Login log = new FrameWork.Login();
            //DataTable logDt = new DataTable("Hello");
            //logDt = log.UserTable;

            DataTable dt = new DataTable("Supplier");
            dt.Clear();

            string query = "SELECT [ID],[Company],[LastName],[FirstName],[EmailAddress],[JobTitle],[BusinessPhone],[HomePhone],[MobilePhone],[FaxNumber],[Address],[City],[StateProvince],[ZipPostal],[CountryRegion],[WebPage],[Notes],[Attachments],[SupplierName],[FileAs],[TIN]  FROM [dbo].[Suppliers]";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            return dt;
        }
    }
}
