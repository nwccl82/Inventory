using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class ReportAspx : System.Web.UI.Page
    {
        private static DateTime dateToday;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            ConnectionInfo connRPT = new ConnectionInfo();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

            connRPT.DatabaseName = System.Configuration.ConfigurationManager.ConnectionStrings["databasename"].ConnectionString;
            connRPT.UserID =System.Configuration.ConfigurationManager.ConnectionStrings["userID"].ConnectionString;
            connRPT.Password = System.Configuration.ConfigurationManager.ConnectionStrings["userPassword"].ConnectionString;
            connRPT.ServerName = System.Configuration.ConfigurationManager.ConnectionStrings["serverName"].ConnectionString;
         
            this.CrystalReportViewer1.ReportSource = Server.MapPath("Cr1.rpt");
            crtableLogoninfos = this.CrystalReportViewer1.LogOnInfo;
            foreach (TableLogOnInfo crtableLogoninfo in crtableLogoninfos)
            {
                //( myTableLogOnInfo As TableLogOnInfo In myTableLogOnInfos)
                crtableLogoninfo.ConnectionInfo = connRPT;
            }
            //CrystalReportViewer1.SelectionFormula = "{DOCTOR_REQ.routine_type} = 'CHEMISTRY' and {DOCTOR_REQ.admission_no} = " + admissionNo +
            //        " and {DOCTOR_REQ.date_req} =" + sqlQ(formatMonth(dateToday.Month) + "/" + formatMonth(dateToday.Day) + "/" + dateToday.Year);
            //CrystalReportViewer1.ParameterFieldInfo["REPORTTITLE"].ReportName = "LABORATORY";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dateToday = new DateTime();
            dateToday = DateTime.Parse("2015-02-01");
            CrystalReportViewer1.SelectionFormula = "Date({test.dateenter}) >= # " + formatMonth(dateToday.Month) + "/" + formatMonth(dateToday.Day) + "/" + dateToday.Year + " # and Date({test.dateenter}) <= # " + formatMonth(dateToday.Month) + "/" + formatMonth(dateToday.Day) + "/" + dateToday.Year + " #";
        }
            private string sqlQ(string str)
        {
            string str_2;
            str_2 = "'" + str.Replace("'", "''") + "'";
            return str_2.ToUpper();
        }
        private string formatMonth(int month)
        {
            string str_month = "";
            if (month < 10)
            {
                str_month = "0" + month;
            }
            else
            {
                str_month = "" + month;
            }
            return str_month;
        }
    }
}