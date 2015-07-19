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
    public partial class UnitOfMeasures : System.Web.UI.Page
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
                busUnitOfMeasure buscat = new busUnitOfMeasure();
                DataTable dt = new DataTable("User");
                dt = buscat.allUOM();
                GridView1.DataSource = dt;
                GridView1.DataBind();


            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            busUnitOfMeasure busuom = new busUnitOfMeasure();
            FrameWork.UnitOfMeasures frmcat = new FrameWork.UnitOfMeasures();
            frmcat.UnitOfMeasure = this.txtUOM.Text;


            isExisting = isUserExisting();
            if (isExisting.Equals(true))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Unit Of Measure existing')", true);
            }
            else
            {
                busuom.insertMeasures(frmcat);
            }
            DataTable dt = new DataTable("User");
            dt = busuom.allUOM();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        private bool isUserExisting()
        {
            string userid = this.txtUOM.Text;
            busUnitOfMeasure buscat = new busUnitOfMeasure();
            FrameWork.UnitOfMeasures frmcat = new FrameWork.UnitOfMeasures();
            frmcat = buscat.isUserExisting(userid);
            //FrameWork.Employees log = busemp.isUserExisting(userid);
            if (frmcat == null)
            {
                return false;
            }
            else if (userid.Equals(frmcat.UnitOfMeasure))
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