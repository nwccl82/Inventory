using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Xml.Linq;
using System.IO;
using System.Net;
using System.Net.Mail;
using Microsoft.VisualBasic;

namespace Inventory
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup

        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs
            Exception err = (Exception)Server.GetLastError().InnerException;
            if (err != null)
            {
                //Create a text file containing error details
                string strFileName = "Err_dt_" + DateTime.Now.Month + "_" + DateTime.Now.Day
                + "_" + DateTime.Now.Year + "_Time_" + DateTime.Now.Hour + "_" +
                DateTime.Now.Minute + "_" + DateTime.Now.Second + "_"
                + DateTime.Now.Millisecond + ".txt";

                strFileName = Server.MapPath("~") + "\\\\MyError\\\\" + strFileName;
                FileStream fsOut = File.Create(strFileName);
                StreamWriter sw = new StreamWriter(fsOut);

                //Log the error details
                //TODO: INSTANT C# TODO TASK: Calls to the VB 'Err' object are not converted by Instant C#:
                string errorText = "Error Message: " + err.Message + sw.NewLine;
                //TODO: INSTANT C# TODO TASK: Calls to the VB 'Err' object are not converted by Instant C#:
                string userid = (string)Session["UserID"];
                if (userid != null || userid != string.Empty || userid != "")
                {
                    errorText = errorText + "Stack Trace: " + err.StackTrace + sw.NewLine + userid;
                }
                else
                {
                    errorText = errorText + "Stack Trace: " + err.StackTrace + sw.NewLine;
                }
                sw.WriteLine(errorText);
                sw.Flush();
                sw.Close();
                fsOut.Close();

                string errmsg = err.Message;
                Session["errmg"] = errmsg;
                errmsg.Replace(".\r\n", "r n");
                Response.Redirect("PageError.aspx?Error=" + errmsg + "");

                //MailMessage msg = new MailMessage();
                //MailAddress addr = null;
                //string senderemail = ConfigurationManager.AppSettings.Get("Semailadd");
                //addr = new MailAddress(senderemail);//("nlapitan@equicom.com"); //("nlapitan@ecs.equicom.com")
                //MailAddress addrto = null;
                ////addrto = new MailAddress(ConfigurationManager.AppSettings.Get("emailadd"));
                //msg.From = addr;
                ////msg.To.Add("kebool@equicom.com");
                //string str = ConfigurationManager.AppSettings.Get("emailadd");
                //string[] recarr = str.Split('|');
                //for (int i = 0; i < recarr.Length; i++)
                //{
                //    msg.To.Add(recarr[i]);
                //}
                ////msg.To.Add("hwoo@equicom.com");
                ////msg.To.Add("nlapitan@equicom.com");
                ////msg.To.Add("hko@equicom.com");
                ////msg.To.Add("pstaana@equicom.com");
                //msg.Subject = ("Exception:" + err.Message); // "Test may mail"
                //msg.Body = errorText;//this.RtxtBox.Text; //"http://192.168.211.92/billing/default.aspx?x= " & vbCrLf & "http:"
                //SmtpClient smtp = new SmtpClient();
                ////smtp.UseDefaultCredentials = true;

                //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                //smtp.Host = ConfigurationManager.AppSettings.Get("mailserver"); // "192.168.210.15"
                //smtp.Port = Convert.ToInt32(ConfigurationManager.AppSettings.Get("mailport")); // "192.168.210.15"
                //smtp.Send(msg);
                //Response.Write("Error: " + err.Message + "");
                Server.ClearError();
            }

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

    }
}
