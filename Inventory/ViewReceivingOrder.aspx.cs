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
    public partial class ViewReceivingOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {

                busReceiveOrders busReceive = new busReceiveOrders();
                FrameWork.ReceiveOrders[] frmDRSI;

                frmDRSI = busReceive.allPO();
                GridView1.DataSource = frmDRSI;
                GridView1.DataBind();

            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hello = "";
            hello = GridView1.SelectedDataKey["id"].ToString();
            busReceiveOrders ReceiveOrder = new busReceiveOrders();
            FrameWork.ReceiveOrderDetails[] frmDRSI;
            frmDRSI = ReceiveOrder.allPurchaseOrderDetails(hello);
            GridView2.DataSource = frmDRSI;
            GridView2.DataBind();
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}