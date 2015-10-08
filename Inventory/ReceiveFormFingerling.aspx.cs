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
    public partial class ReceiveFormFingerling : System.Web.UI.Page
    {
        DataTable dtgridList = new DataTable();
        DataTable dtgridList1 = new DataTable();
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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtQuantity.Text.Trim() == string.Empty)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please enter quantity ')", true);
            }
            else
            {
                BindStudent();
            }
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

        private void BindStudent()
        {
            DataRow dr;

            if (ViewState["dtgridList"] == null)
            {
                AddColumn("Quantity", "Quantity", grdList);
                AddColumn("UnitOfMeasure", "UnitOfMeasure", grdList);
                AddColumn("Packaging", "Packaging", grdList);
                AddColumn("ProductID", "ProductID", grdList);
                AddColumn("ItemDescription", "ItemDescription", grdList);
                //AddColumn("UnitPrice", "UnitPrice", grdList);
                //AddColumn("Amount", "Amount", grdList);
                AddColumnButtonField("cmdDelete", " ", "Delete", grdList);


                dtgridList.Columns.Add("Quantity");
                dtgridList.Columns.Add("UnitOfMeasure");
                dtgridList.Columns.Add("Packaging");
                dtgridList.Columns.Add("ProductID");
                dtgridList.Columns.Add("ItemDescription");
                //dtgridList.Columns.Add("UnitPrice");
                //dtgridList.Columns.Add("Amount");

                dtgridList.Columns.Add("cmdDelete");
            }
            else
            {
                dtgridList = (DataTable)ViewState["dtgridList"];
            }
            double unitprices = 0;
            double quantity = 0;
            double total = 0;

            //unitprices = double.Parse(this.txtUnitPrice.Text);
            //quantity = double.Parse(this.txtQuantity.Text);
            //total = unitprices * quantity;

            dr = dtgridList.NewRow();
            dr["Quantity"] = this.txtQuantity.Text;
            dr["UnitOfMeasure"] = this.txtUOM.Text;
            dr["Packaging"] = this.txtUOM.Text;
            dr["ProductID"] = this.drpProduct.SelectedValue;
            dr["ItemDescription"] = this.lblDescription.Text;
            //dr["UnitPrice"] = this.txtUnitPrice.Text;
            //dr["Amount"] = total;
            dr["CmdDelete"] = "Delete";
            if (this.txtQuantity.Text != string.Empty)
            {
                dtgridList.Rows.Add(dr);
            }
            ViewState["dtgridList"] = dtgridList;
            grdList.DataSource = dtgridList;
            //grdList.Columns[1].Visible = false;
            //grdList.Columns[3].Visible = false;
            grdList.DataBind();

        }

        private void BindMods()
        {
            DataRow dr;

            if (ViewState["dtgridList1"] == null)
            {
                AddColumn("ModuleNo", "ModuleNo", grdList1);
                AddColumn("CageNo", "CageNo", grdList1);
                AddColumn("Quantity", "Quantity", grdList1);
                AddColumn("Salinity", "Salinity", grdList1);
                AddColumn("Temp", "Temp", grdList1);
                //AddColumn("UnitPrice", "UnitPrice", grdList);
                //AddColumn("Amount", "Amount", grdList);
                AddColumnButtonField("cmdDelete", " ", "Delete", grdList1);


                dtgridList.Columns.Add("ModuleNo");
                dtgridList.Columns.Add("CageNo");
                dtgridList.Columns.Add("Quantity");
                dtgridList.Columns.Add("Salinity");
                dtgridList.Columns.Add("Temp");
                //dtgridList.Columns.Add("UnitPrice");
                //dtgridList.Columns.Add("Amount");

                dtgridList.Columns.Add("cmdDelete");
            }
            else
            {
                dtgridList1 = (DataTable)ViewState["dtgridList1"];
            }
            dr = dtgridList.NewRow();
            dr["ModuleNo"] = this.txtQuantity.Text;
            dr["CageNo"] = this.txtUOM.Text;
            dr["Quantity"] = this.txtUOM.Text;
            dr["Salinity"] = this.drpProduct.SelectedValue;
            dr["Temp"] = this.lblDescription.Text;
            //dr["UnitPrice"] = this.txtUnitPrice.Text;
            //dr["Amount"] = total;
            dr["CmdDelete"] = "Delete";
            if (this.txtQuantity.Text != string.Empty)
            {
                dtgridList1.Rows.Add(dr);
            }
            ViewState["dtgridList1"] = dtgridList1;
            grdList1.DataSource = dtgridList1;
            //grdList.Columns[1].Visible = false;
            //grdList.Columns[3].Visible = false;
            grdList1.DataBind();

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

        protected void grdList1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void grdList1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

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
    }
}