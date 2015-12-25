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
    public partial class ViewProductRequestOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {

                busProductRequestOrder busProductReq = new busProductRequestOrder();
                FrameWork.ProductRequestOrder[] frmDRSI;

                frmDRSI = busProductReq.retrieveProductRequestOrder();
                GridView1.DataSource = frmDRSI;
                GridView1.DataBind();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = "";
            id = GridView1.SelectedDataKey["id"].ToString();
            busProductRequestOrder busProductReq = new busProductRequestOrder();
            FrameWork.ProductRequestOrderDetails[] frmDRSI;
            frmDRSI = busProductReq.retrieveProductRequestOrderDetails(id);
            GridView2.DataSource = frmDRSI;
            GridView2.DataBind();
        }
    }
}