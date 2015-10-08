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
    public partial class Color : System.Web.UI.Page
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
                busColors buscat = new busColors();
                DataTable dt = new DataTable("User");
                dt = buscat.allCategories();
                GridView1.DataSource = dt;
                GridView1.DataBind();


            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            busColors buscat = new busColors();
            FrameWork.Color frmcat = new FrameWork.Color();
            frmcat.Colors = this.txtCategory.Text;


            isExisting = isUserExisting();
            if (isExisting.Equals(true))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Color existing')", true);
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
            busColors buscat = new busColors();
            FrameWork.Color frmcat = new FrameWork.Color();
            frmcat = buscat.isUserExisting(userid);
            //FrameWork.Employees log = busemp.isUserExisting(userid);
            if (frmcat == null)
            {
                return false;
            }
            else if (userid.Equals(frmcat.Colors))
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