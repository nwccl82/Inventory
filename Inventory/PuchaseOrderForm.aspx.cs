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
    public partial class PuchaseOrderForm : System.Web.UI.Page
    {
        DataTable dtgridList = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                busSupplier busSup = new busSupplier();

                DataTable dt = new DataTable("User");
                dt = busSup.allSupplier();
                ViewState["Supplier"] = dt;
                this.drpSupplier.Items.Clear();
                this.drpSupplier.Items.Add(new ListItem("select one", "0"));
                foreach (DataRow dr in dt.Rows)
                {
                    this.drpSupplier.Items.Add(new ListItem(dr["Company"].ToString(), dr["ID"].ToString()));
                }
                busProducts busProd = new busProducts();
                dt = new DataTable("User");
                dt = busProd.allProducts();
                ViewState["Products"] = dt;
                this.drpProduct.Items.Clear();
                this.drpProduct.Items.Add(new ListItem("select one", "0"));
                foreach (DataRow dr in dt.Rows)
                {
                    this.drpProduct.Items.Add(new ListItem(dr["ProductName"].ToString(), dr["ID"].ToString()));
                }
            }
        }

        protected void drpSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["Supplier"];
            DataRow[] foundRows;
            string selectValue = "ID = " + this.drpSupplier.SelectedValue;
            string sortOrder = "ID ASC";
            foundRows = dt.Select(selectValue, sortOrder);
            for (int i = 0; i < foundRows.Length; i++)
                Console.WriteLine(foundRows[i][2]);
            if (foundRows != null)
            {
                this.lblAddress.Text = foundRows[0]["Address"].ToString();
                this.lblTin.Text = foundRows[0]["TIN"].ToString();
                //this.lblEmail.Text = foundRows[0]["EmailAddress"].ToString();
                this.lbltel.Text = foundRows[0]["BusinessPhone"].ToString();
            }
        }

        protected void drpProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["Products"];
            DataRow[] foundRows;
            string selectValue = "ID = " + this.drpProduct.SelectedValue;
            string sortOrder = "ID ASC";
            foundRows = dt.Select(selectValue, sortOrder);
            for (int i = 0; i < foundRows.Length; i++)
                Console.WriteLine(foundRows[i][2]);
            if (foundRows != null)
            {
                this.lblDescription.Text = foundRows[0]["Description"].ToString();

            }
        }

        private void BindStudent()
        {
            DataRow dr;

            if (ViewState["dtgridList"] == null)
            {
                AddColumn("Quantity", "Quantity", grdList);
                AddColumn("UnitOfMeasure", "UnitOfMeasure", grdList);
                AddColumn("ProductID", "ProductID", grdList);
                AddColumn("ItemDescription", "ItemDescription", grdList);
                AddColumn("UnitPrice", "UnitPrice", grdList);
                AddColumn("Amount", "Amount", grdList);
                AddColumnButtonField("cmdDelete", " ", "Delete", grdList);


                dtgridList.Columns.Add("Quantity");
                dtgridList.Columns.Add("UnitOfMeasure");
                dtgridList.Columns.Add("ProductID");
                dtgridList.Columns.Add("ItemDescription");
                dtgridList.Columns.Add("UnitPrice");
                dtgridList.Columns.Add("Amount");

                dtgridList.Columns.Add("cmdDelete");
            }
            else
            {
                dtgridList = (DataTable)ViewState["dtgridList"];
            }
            double unitprices = 0;
            double quantity = 0;
            double total = 0;

            unitprices = double.Parse(this.txtUnitPrice.Text);
            quantity = double.Parse(this.txtQuantity.Text);
            total = unitprices * quantity;

            dr = dtgridList.NewRow();
            dr["Quantity"] = this.txtQuantity.Text;
            dr["UnitOfMeasure"] = this.txtUOM.Text;
            dr["ProductID"] = this.drpProduct.SelectedValue;
            dr["ItemDescription"] = this.lblDescription.Text;
            dr["UnitPrice"] = this.txtUnitPrice.Text;
            dr["Amount"] = total;
            dr["CmdDelete"] = "Delete";
            dtgridList.Rows.Add(dr);

            ViewState["dtgridList"] = dtgridList;
            grdList.DataSource = dtgridList;
            //grdList.Columns[1].Visible = false;
            //grdList.Columns[3].Visible = false;
            grdList.DataBind();

        }
        public void AddColumn(string DataField, string Header, GridView gv)
        {
            BoundField Field = new BoundField();
            Field.DataField = DataField;
            Field.HeaderText = Header;
            DataControlField Col = Field;
            gv.Columns.Add(Col);
        }
        public void AddColumnButtonField(string DataField, string Header, string CommandName, GridView gv)
        {
            ButtonField Field = new ButtonField();
            Field.DataTextField = DataField;
            Field.CommandName = CommandName;
            Field.HeaderText = Header;
            DataControlField Col = Field;
            gv.Columns.Add(Col);
        }

        protected void grdList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void grdList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int nIndex = Convert.ToInt32(e.CommandArgument);
            double temp = 0;
            double tempw = 0;
            if (e.CommandName == "Delete")
            {
                if (grdList.Rows.Count > 0)
                {
                    dtgridList = (DataTable)ViewState["dtgridList"];

                    dtgridList.Rows.RemoveAt(nIndex);
                    dtgridList.AcceptChanges();
                    grdList.DataSource = dtgridList;
                    grdList.DataBind();
                }

            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtUnitPrice.Text.Trim() == string.Empty && this.txtQuantity.Text.Trim() == string.Empty)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please enter unit price or quantity price')", true);
            }
            else
            {
                BindStudent();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            dtgridList = (DataTable)ViewState["dtgridList"];
            string users = Session["id"].ToString();
            decimal totalamt = 0;
            try
            {
                foreach (DataRow dr in dtgridList.Rows)
                {
                    totalamt = totalamt + decimal.Parse(dr["Amount"].ToString());
                }
                FrameWork.PurchaseOrders PRO = new FrameWork.PurchaseOrders();
                FrameWork.PurchaseOrderDetails PROsub = new PurchaseOrderDetails();
                busPurchaseOrder busPRO = new busPurchaseOrder();
                PRO.SupplierID = int.Parse(this.drpSupplier.SelectedValue);
                PRO.CreatedById = int.Parse(users);
                PRO.ExpectedDate = DateTime.Parse(this.txtDateNeeded.Text);
                PRO.PaymentAmount = totalamt;

                string x = busPRO.insertPO(PRO);
                foreach (DataRow dr in dtgridList.Rows)
                {
                    PROsub.PurchaseOrderID = int.Parse(x);
                    PROsub.Quantity = Single.Parse(dr["Quantity"].ToString());
                    PROsub.UnitCost = decimal.Parse(dr["UnitPrice"].ToString());
                    PROsub.ProductID = int.Parse(dr["ProductID"].ToString());

                    busPRO.insertPurchaseOrderDetails(PROsub);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                this.txtQuantity.Text = string.Empty;
                this.txtUOM.Text = string.Empty;
                this.drpProduct.SelectedValue = "0";
                this.lblDescription.Text = string.Empty;
                this.txtUnitPrice.Text = string.Empty;
                this.drpSupplier.SelectedValue = "0";
                this.txtTerms.Text = string.Empty;
                ViewState["dtgridList"] = string.Empty;

                grdList.DataSourceID = null;
                
                grdList.DataBind();
            }

        }
    }
}