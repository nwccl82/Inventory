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
    public partial class Sizes : System.Web.UI.Page
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
                busSizes bussize = new busSizes();
                DataTable dt = new DataTable("User");
                dt = bussize.allSize();
                GridView1.DataSource = dt;
                GridView1.DataBind();


            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            busSizes bussize = new busSizes();
            FrameWork.Sizes frmcat = new FrameWork.Sizes();
            frmcat.ProductSize = this.txtSizes.Text;


            isExisting = isUserExisting();
            if (isExisting.Equals(true))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Size existing')", true);
            }
            else
            {
                bussize.insertSizes(frmcat);
            }
            DataTable dt = new DataTable("User");
            dt = bussize.allSize ();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        private bool isUserExisting()
        {
            string userid = this.txtSizes.Text;
            busSizes bussize = new busSizes();
            FrameWork.Sizes frmcat = new FrameWork.Sizes();
            frmcat = bussize.isUserExisting(userid);
            //FrameWork.Employees log = busemp.isUserExisting(userid);
            if (frmcat == null)
            {
                return false;
            }
            else if (userid.Equals(frmcat.ProductSize))
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