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
    public class busCustomer
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

        public string insertCustomer(Customers custs)
        {
            string Message = string.Empty;
            int result = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Customers]([Company],[LastName],[FirstName],[EmailAddress],[JobTitle],[BusinessPhone],[HomePhone],[MobilePhone],[FaxNumber],[Address],[City],[StateProvince],[ZipPostal],[CountryRegion],[WebPage],[Notes],[Attachments],[CustomerName],[FileAs],[TIN]) VALUES (@Company,@LastName, @FirstName,@EmailAddress, @JobTitle, @BusinessPhone, @HomePhone, @MobilePhone, @FaxNumber, @Address, @City, @StateProvince, @ZipPostal, @CountryRegion, @WebPage, @Notes, @Attachments,@CustomerName,@FileAs,@TIN )", con);
            // cmd.Parameters.AddWithValue("@Suppliers", supps.Suppliers);
            cmd.Parameters.AddWithValue("@Company", custs.Company);
            cmd.Parameters.AddWithValue("@LastName", custs.LastName);
            cmd.Parameters.AddWithValue("@FirstName", custs.FirstName);
            cmd.Parameters.AddWithValue("@EmailAddress", custs.EmailAddress);
            cmd.Parameters.AddWithValue("@JobTitle", custs.JobTitle);
            cmd.Parameters.AddWithValue("@BusinessPhone", custs.BusinessPhone);
            cmd.Parameters.AddWithValue("@HomePhone", custs.HomePhone != null ? custs.HomePhone : string.Empty);
            cmd.Parameters.AddWithValue("@MobilePhone", custs.MobilePhone != null ? custs.MobilePhone : string.Empty);
            cmd.Parameters.AddWithValue("@FaxNumber", custs.FaxNumber != null ? custs.FaxNumber : string.Empty);
            cmd.Parameters.AddWithValue("@Address", custs.Address != null ? custs.Address : string.Empty);
            cmd.Parameters.AddWithValue("@City", custs.City != null ? custs.City : string.Empty);
            cmd.Parameters.AddWithValue("@StateProvince", custs.StateProvince != null ? custs.StateProvince : string.Empty);
            cmd.Parameters.AddWithValue("@ZipPostal", custs.ZipPostal != null ? custs.ZipPostal : string.Empty);
            cmd.Parameters.AddWithValue("@CountryRegion", custs.CountryRegion != null ? custs.CountryRegion : string.Empty);
            cmd.Parameters.AddWithValue("@WebPage", custs.WebPage != null ? custs.WebPage : string.Empty);
            cmd.Parameters.AddWithValue("@Notes", custs.Notes != null ? custs.Notes : string.Empty);
            cmd.Parameters.AddWithValue("@CustomerName", custs.CustomerName != null ? custs.CustomerName : string.Empty);
            cmd.Parameters.AddWithValue("@FileAs", custs.FileAs != null ? custs.FileAs : string.Empty);
            cmd.Parameters.AddWithValue("@Attachments", custs.Attachments != null ? custs.Attachments : string.Empty);
            cmd.Parameters.AddWithValue("@TIN", custs.TIN != null ? custs.TIN : string.Empty);



            result = cmd.ExecuteNonQuery();
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

        public DataTable allCustomer()
        {
            //FrameWork.Login log = new FrameWork.Login();
            //DataTable logDt = new DataTable("Hello");
            //logDt = log.UserTable;

            DataTable dt = new DataTable("Customer");
            dt.Clear();

            string query = "SELECT [ID],[Company],[LastName],[FirstName],[EmailAddress],[JobTitle],[BusinessPhone],[HomePhone],[MobilePhone],[FaxNumber],[Address],[City],[StateProvince],[ZipPostal],[CountryRegion],[WebPage],[Notes],[Attachments],[CustomerName],[FileAs],[TIN]  FROM [dbo].[Customers]";
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            return dt;
        }


    }
}
