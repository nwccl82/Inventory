using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inventory
{
    public partial class PageError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string errmg1 = (string)Session["errmg"];
            if (errmg1 != string.Empty || errmg1 != null || errmg1 != "Object reference not set to an instance of an object")
            {
                string errmg = Request.QueryString["Error"].ToString();
                if (errmg != null || errmg != string.Empty || errmg != "")
                {
                    Response.Write("Error: " + errmg + "");
                }
                else
                {
                    Response.Write("Error encountered please contact programmer");
                }
                //Server.ClearError();
            }
        }
    }
}