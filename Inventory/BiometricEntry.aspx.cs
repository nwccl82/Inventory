using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using FrameWork;
using BusinessRule;

namespace Inventory
{
    public partial class BiometricEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable("Products");
                busProducts busProd = new busProducts();
                dt = new DataTable("Products");
                dt = busProd.allProducts();
                ViewState["Products"] = dt;
                this.ddpProduct.Items.Clear();
                this.ddpProduct.Items.Add(new ListItem("select one", "0"));
                foreach (DataRow dr in dt.Rows)
                {
                    this.ddpProduct.Items.Add(new ListItem(dr["ProductName"].ToString(), dr["ID"].ToString()));
                }
                //this.drpFeeds.Items.Clear();
                //this.drpFeeds.Items.Add(new ListItem("select one", "0"));
                //foreach (DataRow dr in dt.Rows)
                //{
                //    this.drpFeeds.Items.Add(new ListItem(dr["ProductName"].ToString(), dr["ID"].ToString()));
                //}

            }
        }

        protected void drpProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}