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
    public class busDISRForm
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public string insertDRSI(DRSIForm drsi)
        {
            string Message = string.Empty;
            int result = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [inventory].[dbo].DRSIForm ([CustomerFKID],[ProductFKID],[TotalPcs],[TotalUOM],[TotalWeight],[TotalUnitCost],[TotalCost]) VALUES (@CustomerFKID,@ProductFKID,@TotalPcs,@TotalUOM,@TotalWeight,@TotalUnitCost,@TotalCost)", con);
            cmd.Parameters.AddWithValue("@CustomerFKID", drsi.CustomerFKID);
            cmd.Parameters.AddWithValue("@ProductFKID", drsi.ProductFKID);
            cmd.Parameters.AddWithValue("@TotalPcs", drsi.TotalPcs);
            cmd.Parameters.AddWithValue("@TotalUOM", drsi.TotalUOM);
            cmd.Parameters.AddWithValue("@TotalWeight", drsi.TotalWeight);
            cmd.Parameters.AddWithValue("@TotalUnitCost", drsi.TotalUnitCost);
            cmd.Parameters.AddWithValue("@TotalCost", drsi.TotalCost);
            result = cmd.ExecuteNonQuery();
            con.Close();
            string query ="select top 1 ID from [DRSIForm] order by id desc";
            DataTable dt = new DataTable("Customer");
            dt.Clear();
            dt = DataAccess.DBAdapter.GetRecordSet(query);
            
            if (dt.Rows.Count > 0)
            {
                Message = dt.Rows[0]["ID"].ToString();
            }
            return Message;
        }

        public string insertDRSIsub(DRSISub drsi)
        {
            string Message = string.Empty;
            int result = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [inventory].[dbo].DRSISub ([DRSiformID],[BatchNo],[ModuleNo],[CageNo],[Weight],[UnitOfMeasure]) VALUES (@DRSiformID,@BatchNo,@ModuleNo,@CageNo,@Weight,@UnitOfMeasure)", con);
            cmd.Parameters.AddWithValue("@DRSiformID", drsi.DRSiformID);
            cmd.Parameters.AddWithValue("@BatchNo", drsi.BatchNo);
            cmd.Parameters.AddWithValue("@ModuleNo", drsi.ModuleNo);
            cmd.Parameters.AddWithValue("@CageNo", drsi.CageNo);
            cmd.Parameters.AddWithValue("@Weight", drsi.Weight);
            cmd.Parameters.AddWithValue("@UnitOfMeasure", drsi.UnitOfMeasure);
            //cmd.Parameters.AddWithValue("@TotalCost", drsi.TotalCost);
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

        public FrameWork.DRSIForm[] allDrSIForm()
        {
            string query = "SELECT a.[ID] ,b.[Company],c.[ProductName],[TotalPcs],[TotalUOM],[TotalWeight],[TotalUnitCost],[TotalCost]  FROM [inventory].[dbo].DRSIForm a inner join [Customers] b on a.CustomerFKID = b.ID inner join [Products] c on a.ProductFKID= c.ID";
            DataTable table = new DataTable();

            table = DataAccess.DBAdapter.GetRecordSet(query);
            FrameWork.DRSIForm[] dec = new FrameWork.DRSIForm[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                dec[i] = new FrameWork.DRSIForm(table.Rows[i]);
            }

            return dec;
             
        }
        public FrameWork.DRSISub[] allDrSIFormSub(string ID)
        {
            string query = "SELECT [ID] ,[DRSiformID],[BatchNo],[ModuleNo],[CageNo],[Weight],[UnitOfMeasure]  FROM [inventory].[dbo].[DRSISub] where DRSiformID='"+ ID +"'";
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
