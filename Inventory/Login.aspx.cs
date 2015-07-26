using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inventory
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userid = txtUserID.Text;
            string pass = txtPassword.Text;
            BusinessRule.busEmployees lst = new BusinessRule.busEmployees();
            FrameWork.Employees frmEmp = new FrameWork.Employees();
            frmEmp = lst.Retrieve1(userid, pass);
            if (frmEmp != null)
            {
                Session["id"] = frmEmp.ID;
                Session["user"] = frmEmp.Login;
                //   Session["position"] = frmLogin.position;
                //Server.Transfer("adduser.aspx");
                Response.Redirect("adduser.aspx");
            }

        }
    }
}