using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Data;
using System.Collections;
using BusinessRule;

namespace Inventory
{
    public partial class ViewSupplier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                busSupplier bussup = new busSupplier();

                DataTable dt = new DataTable("User");
                dt = bussup.allSupplier();
                ViewState["Supplier"] = dt;
                GridView1.DataSource = dt;
                GridView1.DataBind();


            }
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            busSupplier bussup = new busSupplier();
            this.GridView1.PageIndex = e.NewPageIndex;
            DataTable dt = new DataTable("User");
            dt = bussup.allSupplier();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["Supplier"];
            DataRow[] foundRows;
            string selectValue = "Company like '" + this.txtCompany.Text + "%'";
            string sortOrder = "Company ASC";
            foundRows = dt.Select(selectValue, sortOrder);
            DataTable cloneTable;
            cloneTable = dt.Clone();
            foreach (DataRow row in dt.Select(selectValue, sortOrder))
            {
                cloneTable.ImportRow(row);
            }
            GridView1.DataSource = cloneTable;
            GridView1.DataBind();
        }
    }
}