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
    public partial class DRSIForm : System.Web.UI.Page
    {
        DataTable dtgridList = new DataTable();
        DataTable dtAircraft = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                busCustomer buscust = new busCustomer();

                DataTable dt = new DataTable("User");
                dt = buscust.allCustomer();
                ViewState["Customer"] = dt;
                this.drpCustomer.Items.Clear();
                this.drpCustomer.Items.Add(new ListItem("select one", "0"));
                foreach (DataRow dr in dt.Rows)
                {
                    this.drpCustomer.Items.Add(new ListItem(dr["Company"].ToString(), dr["ID"].ToString()));
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
                    tempw =double.Parse (dtgridList.Rows[nIndex]["Weight"].ToString());
                    dtgridList.Rows.RemoveAt(nIndex);
                    dtgridList.AcceptChanges();
                    grdList.DataSource = dtgridList;
                    grdList.DataBind();
                }
                this.lblPcs.Text = grdList.Rows.Count.ToString();
                if (lblWeight.Text.Trim() == String.Empty)
                {
                    temp = 0;
                }
                else
                {
                    temp = double.Parse(lblWeight.Text);
                    this.lblWeight.Text = (temp - tempw).ToString(); 
                }
                if (txtCost.Text.Trim() != String.Empty)
                {
                    this.lblTCost.Text = (double.Parse(lblWeight.Text) * double.Parse(txtCost.Text)).ToString();
                }

            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCost.Text.Trim() == string.Empty)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please enter unit cost')", true);
            }
            else
            {
                BindStudent();
            }
        }
        private void BindStudent()
        {
            DataRow dr;

            if (ViewState["dtgridList"] == null)
            {
                AddColumn("BatchNo", "BatchNo", grdList);
                AddColumn("ModuleNo", "ModuleNo", grdList);
                AddColumn("CageNo", "CageNo", grdList);
                AddColumn("Weight", "Weight", grdList);
                AddColumn("UnitOfMeasure", "UnitOfMeasure", grdList);
                AddColumnButtonField("cmdDelete", " ", "Delete", grdList);


                dtgridList.Columns.Add("BatchNo");
                dtgridList.Columns.Add("ModuleNo");
                dtgridList.Columns.Add("CageNo");
                dtgridList.Columns.Add("Weight");
                dtgridList.Columns.Add("UnitOfMeasure");

                dtgridList.Columns.Add("cmdDelete");
            }
            else
            {
                dtgridList = (DataTable)ViewState["dtgridList"];
            }


            dr = dtgridList.NewRow();
            dr["BatchNo"] = this.txtBatchNo.Text;
            dr["ModuleNo"] = this.txtModule.Text;
            dr["CageNo"] = this.txtCage.Text;
            dr["Weight"] = this.txtWeight.Text;
            dr["UnitOfMeasure"] = this.txtUnitMeasure.Text;

            dr["CmdDelete"] = "Delete";
            dtgridList.Rows.Add(dr);

            ViewState["dtgridList"] = dtgridList;
            grdList.DataSource = dtgridList;
            //grdList.Columns[1].Visible = false;
            //grdList.Columns[3].Visible = false;
            grdList.DataBind();
            this.lblPcs.Text = grdList.Rows.Count.ToString();
            this.lblUOM.Text = this.txtUnitMeasure.Text;
            double temp = 0;
            if (lblWeight.Text.Trim() == String.Empty)
            {
                temp = 0;
            }
            else
            {
                temp = double.Parse(lblWeight.Text);
            }
            this.lblWeight.Text = (double.Parse(this.txtWeight.Text) + temp).ToString();
            if (txtCost.Text.Trim() != String.Empty)
            {
                this.lblTCost.Text = (double.Parse(lblWeight.Text) * double.Parse(txtCost.Text)).ToString();
            }
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

        protected void btnSave_Click(object sender, EventArgs e)
        {
            dtgridList = (DataTable)ViewState["dtgridList"];
            string users = Session["id"].ToString();
            FrameWork.DRSIForm drsi = new FrameWork.DRSIForm();
            FrameWork.DRSISub drsisub = new DRSISub();
            busDISRForm busDISR = new busDISRForm();
            drsi.CustomerFKID = int.Parse(this.drpCustomer.SelectedValue);
            drsi.ProductFKID = int.Parse(this.drpProduct.SelectedValue);
            drsi.TotalPcs = lblPcs.Text;
            drsi.TotalUOM = lblUOM.Text;
            drsi.TotalWeight = lblWeight.Text;
            drsi.TotalUnitCost = txtCost.Text;
            drsi.TotalCost = lblTCost.Text;
            drsi.OrderBy = users;
            string x = busDISR.insertDRSI(drsi);
            foreach (DataRow dr in dtgridList.Rows)
            {
                drsisub.DRSiformID = int.Parse(x);
                drsisub.BatchNo = dr["BatchNo"].ToString();
                drsisub.ModuleNo = dr["ModuleNo"].ToString();
                drsisub.CageNo = dr["CageNo"].ToString();
                drsisub.Weight = dr["Weight"].ToString();
                drsisub.UnitOfMeasure = dr["UnitOfMeasure"].ToString();
                busDISR.insertDRSIsub(drsisub);
            }
        }

        protected void drpCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
           DataTable dt= (DataTable)ViewState["Customer"];
           DataRow[] foundRows;
           string selectValue ="ID = "+  this.drpCustomer.SelectedValue;
           string sortOrder = "ID ASC";
           foundRows = dt.Select(selectValue, sortOrder);
           for (int i = 0; i < foundRows.Length; i++)
               Console.WriteLine(foundRows[i][2]);
           if (foundRows != null)
            {
                this.lblAddress.Text = foundRows[0]["Address"].ToString();
                this.lblTin.Text = foundRows[0]["TIN"].ToString();
                this.lblEmail.Text = foundRows[0]["EmailAddress"].ToString();
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
    }
}