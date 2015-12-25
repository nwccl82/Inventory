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
        protected void btnAdd0_Click(object sender, EventArgs e)
        {
            if (this.txtQuantity.Text.Trim() == string.Empty)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please enter quantity ')", true);
            }
            else
            {
                BindMods();
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
                AddColumn("ModuleNum", "ModuleNum", grdList1);
                AddColumn("CageNum", "CageNum", grdList1);
                AddColumn("Quantity", "Quantity", grdList1);
                AddColumn("Salinity", "Salinity", grdList1);
                AddColumn("Temp", "Temp", grdList1);
                //AddColumn("UnitPrice", "UnitPrice", grdList);
                //AddColumn("Amount", "Amount", grdList);
                AddColumnButtonField("cmdDelete", " ", "Delete", grdList1);


                dtgridList1.Columns.Add("ModuleNum");
                dtgridList1.Columns.Add("CageNum");
                dtgridList1.Columns.Add("Quantity");
                dtgridList1.Columns.Add("Salinity");
                dtgridList1.Columns.Add("Temp");
                //dtgridList.Columns.Add("UnitPrice");
                //dtgridList.Columns.Add("Amount");

                dtgridList1.Columns.Add("cmdDelete");
            }
            else
            {
                dtgridList1 = (DataTable)ViewState["dtgridList1"];
            }
            dr = dtgridList1.NewRow();
            dr["ModuleNum"] = this.txtModule.Text;
            dr["CageNum"] = this.txtCage.Text;
            dr["Quantity"] = this.txtQuantity1.Text;
            dr["Salinity"] = this.txtSalinity1.Text ;
            dr["Temp"] = this.txtTemperature.Text;
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
            int nIndex = Convert.ToInt32(e.CommandArgument);
            double temp = 0;
            double tempw = 0;
            if (e.CommandName == "Delete")
            {
                if (grdList1.Rows.Count > 0)
                {
                    dtgridList1 = (DataTable)ViewState["dtgridList1"];

                    dtgridList1.Rows.RemoveAt(nIndex);
                    dtgridList1.AcceptChanges();
                    grdList1.DataSource = dtgridList1;
                    grdList1.DataBind();
                }

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

        protected void drpSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSave1_Click(object sender, EventArgs e)
        {
            dtgridList = (DataTable)ViewState["dtgridList"];
            dtgridList1 = (DataTable)ViewState["dtgridList1"];
            string users = Session["id"].ToString();
            decimal totalamt = 0;
            try
            {

                FrameWork.ReceiveOrdersFinger RRO = new FrameWork.ReceiveOrdersFinger();
                FrameWork.ReceiveOrdersFingerDetails PROsub = new ReceiveOrdersFingerDetails();
                FrameWork.ReceiveOrdersFingerDetails2 PROsub2 = new ReceiveOrdersFingerDetails2();
                busReceivedOrderFingerLings busPRO = new busReceivedOrderFingerLings();
                
                RRO.SupplierID = int.Parse(this.drpSupplier.SelectedValue);
                RRO.CreatedById = int.Parse(users);
                RRO.PurchaseOrderID = int.Parse(this.txtPro.Text);
                RRO.DateofShipment =DateTime.Parse (this.txtDateShipment.Text);
                RRO.DateofArrival = DateTime.Parse(this.txtDateArrival.Text);
                RRO.DateReceive = DateTime.Parse(this.txtDateReceive.Text);
                RRO.TimeofShipment = DateTime.Parse(this.txtTimeShipment.Text).TimeOfDay;
                RRO.TimeofArrival = DateTime.Parse(this.txtTimeArrival.Text).TimeOfDay;
                RRO.TimeReceive = DateTime.Parse(this.txtTimeReceive.Text).TimeOfDay;
                RRO.ReoxygenationStart = DateTime.Parse(this.txtReoxygen.Text).TimeOfDay;
                RRO.ReoxygenationEnd = DateTime.Parse(this.txtFinish.Text).TimeOfDay;
                RRO.SalinityInsideTheBag =int.Parse(this.txtSalinity.Text);
                RRO.TemperatureInsideTheBag = int.Parse(this.txtTemp.Text);
                RRO.TimeAfterReceiptFromAirport = DateTime.Parse(this.txtTimeReceiveAirport.Text).TimeOfDay;
                RRO.Mortality = int.Parse(this.txtMortality.Text);
                RRO.TimeofArrival1 = DateTime.Parse(this.txtTimeArrival1.Text).TimeOfDay;
                RRO.TimeofStocking = DateTime.Parse(this.txtTimeStocking.Text).TimeOfDay;
                RRO.Mortality1 = int.Parse(this.txtMortality1.Text);
                RRO.Deformed = int.Parse(this.txtDeformed.Text);
                RRO.Injured = int.Parse(this.txtInjured.Text);
                RRO.Missing = int.Parse(this.txtMissing.Text);


                string x = busPRO.insertRR(RRO);
                foreach (DataRow dr in dtgridList.Rows)
                {
                    PROsub.ReceiveOrderID = int.Parse(x);
                    PROsub.Quantity = Single.Parse(dr["Quantity"].ToString());

                    PROsub.ProductID = int.Parse(dr["ProductID"].ToString());

                    busPRO.insertReceiveOrderDetails(PROsub);
                }
                foreach (DataRow dr1 in dtgridList1.Rows)
                {
                    PROsub2.ReceiveOrderID = int.Parse(x);
                    PROsub2.ModuleNum = int.Parse(dr1["ModuleNum"].ToString());
                    PROsub2.CageNum = int.Parse(dr1["CageNum"].ToString());
                    PROsub2.Salinity = int.Parse(dr1["Salinity"].ToString());
                    PROsub2.Temp = int.Parse(dr1["Temp"].ToString());
                    busPRO.insertReceiveOrderDetails2(PROsub2);
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
                //this.txtUnitPrice.Text = string.Empty;
                this.drpSupplier.SelectedValue = "0";
                // this.txtTerms.Text = string.Empty;
                DataTable ds = new DataTable();
                ds = null;
                this.grdList.DataSource = ds;
                grdList.DataBind();
            }
        }

      
    }
}