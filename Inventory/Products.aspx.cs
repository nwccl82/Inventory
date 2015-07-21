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
    public partial class Products : System.Web.UI.Page
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
                busUnitOfMeasure busuom = new busUnitOfMeasure();
                DataTable dt = new DataTable("User");
                dt = busuom.allUOM();
                this.drpUOM.Items.Clear();
                this.drpUOM.Items.Add(new ListItem("select one", "0"));
                foreach (DataRow dr in dt.Rows)
                {
                    this.drpUOM.Items.Add(new ListItem(dr["UnitOfMeasure"].ToString(), dr["ID"].ToString()));
                }
                busSizes bussize = new busSizes();
                
                dt = bussize.allSize();
                this.drpSize.Items.Clear();
                this.drpSize.Items.Add(new ListItem("select one", "0"));
                foreach (DataRow dr in dt.Rows)
                {
                    this.drpSize.Items.Add(new ListItem(dr["ProductSize"].ToString(), dr["ID"].ToString()));
                }
                busCategories buscat = new busCategories();
                
                dt = buscat.allCategories();
                this.drpCategory.Items.Clear();
                this.drpCategory.Items.Add(new ListItem("select one", "0"));
                foreach (DataRow dr in dt.Rows)
                {
                    this.drpCategory.Items.Add(new ListItem(dr["Category"].ToString(), dr["ID"].ToString()));
                }
                busProducts busProd = new busProducts();
                dt = new DataTable("User");
                dt = busProd.allProducts();
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            busProducts busProd = new busProducts();
            FrameWork.Products frmProd = new  FrameWork.Products();
            frmProd.ProductName = this.txtProdName.Text;
            frmProd.ProductCode = this.txtCode.Text;
            frmProd.Description = this.txtProdDescription.Text;
            frmProd.CategoryID = int.Parse(this.drpCategory.SelectedValue);
            frmProd.ProductSizeID = int.Parse(this.drpSize.SelectedValue);
            frmProd.UnitOfMeasureID = int.Parse(this.drpUOM.SelectedValue);
            isExisting = isUserExisting();
            if (isExisting.Equals(true))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Product already Exists')", true);
            }
            else
            {
                busProd.insertProducts(frmProd);
            }
            DataTable dt = new DataTable("User");
            dt = busProd.allProducts();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        private bool isUserExisting()
        {
            string userid = this.txtProdName.Text;
            busProducts busprod = new busProducts();
            FrameWork.Products frmprod = new FrameWork.Products();
            frmprod = busprod.isUserExisting(userid);
            //FrameWork.Employees log = busemp.isUserExisting(userid);
            if (frmprod == null)
            {
                return false;
            }
            else if (userid.Equals(frmprod.ProductName))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
         
            DataTable dt = new DataTable("User");
            busProducts busProd = new busProducts();
            this.GridView1.PageIndex = e.NewPageIndex;
            dt = new DataTable("User");
            dt = busProd.allProducts();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}