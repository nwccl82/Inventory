using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessRule;
using FrameWork;
using System.Data;
using System.Data.SqlClient;
namespace Inventory
{
    public partial class Width : System.Web.UI.Page
    {
        Boolean isExisting = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                busWidth buscat = new busWidth();
                DataTable dt = new DataTable("User");
                dt = buscat.allCategories();
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            busWidth buscat = new busWidth();
            FrameWork.Width frmcat = new FrameWork.Width();
            frmcat.Widths = this.txtCategory.Text;


            isExisting = isUserExisting();
            if (isExisting.Equals(true))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Width existing')", true);
            }
            else
            {
                buscat.insertCategory(frmcat);
            }
            DataTable dt = new DataTable("User");
            dt = buscat.allCategories();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        private bool isUserExisting()
        {
            string userid = this.txtCategory.Text;
            busWidth buscat = new busWidth();
            FrameWork.Width frmcat = new FrameWork.Width();
            frmcat = buscat.isUserExisting(userid);
            //FrameWork.Employees log = busemp.isUserExisting(userid);
            if (frmcat == null)
            {
                return false;
            }
            else if (userid.Equals(frmcat.Widths))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}