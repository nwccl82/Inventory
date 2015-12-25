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
    public partial class DailyMonitoring : System.Web.UI.Page
    {
        DataTable dtgridList = new DataTable();
        DataTable dtAircraft = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            } if (!IsPostBack)
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
                this.drpFeeds.Items.Clear();
                this.drpFeeds.Items.Add(new ListItem("select one", "0"));
                 foreach (DataRow dr in dt.Rows)
                {
                    this.drpFeeds.Items.Add(new ListItem(dr["ProductName"].ToString(), dr["ID"].ToString()));
                }
                
            }
        }
       protected void btnAdd_Click(object sender, EventArgs e)
        {
            BindStudent();
        }

        private void BindStudent()
        {
            DataRow dr;

            if (ViewState["dtgridList"] == null)
            {
                AddColumn("DateofTrans", "DateofTrans", GridView1);
                AddColumn("TimeofTrans", "TimeofTrans", GridView1);
                AddColumn("ProdID", "ProdID", GridView1);
                AddColumn("ItemDescription", "ItemDescription", GridView1);
                AddColumn("BatchNo", "BatchNo", GridView1);
                AddColumn("ModuleNo", "ModuleNo", GridView1);
                AddColumn("CageNo", "CageNo", GridView1);
                AddColumn("TotalCount", "TotalCount", GridView1);
                AddColumn("Dead", "Dead", GridView1);
                AddColumn("Deform", "Deform", GridView1);
                AddColumn("Age", "Age", GridView1);
                AddColumn("Salinity", "Salinity", GridView1);
                AddColumn("Temp", "Temp", GridView1);
                AddColumn("Weather", "Weather", GridView1);
                AddColumn("WeightofFood", "WeightofFood", GridView1);
                AddColumn("RecordedBy", "RecordedBy", GridView1);
                AddColumn("CheckBy", "CheckBy", GridView1);
                AddColumn("RRID", "RRID", GridView1);


                AddColumnButtonField("cmdDelete", " ", "Delete", GridView1);


                dtgridList.Columns.Add("DateofTrans");
                dtgridList.Columns.Add("TimeofTrans");
                dtgridList.Columns.Add("ProdID");
                dtgridList.Columns.Add("ItemDescription");
                dtgridList.Columns.Add("BatchNo");
                dtgridList.Columns.Add("ModuleNo");
                dtgridList.Columns.Add("CageNo");
                dtgridList.Columns.Add("TotalCount");
                dtgridList.Columns.Add("Dead");
                dtgridList.Columns.Add("Deform");
                dtgridList.Columns.Add("Age");
                dtgridList.Columns.Add("Salinity");
                dtgridList.Columns.Add("Temp");
                dtgridList.Columns.Add("Weather");
                dtgridList.Columns.Add("WeightofFood");
                dtgridList.Columns.Add("RecordedBy");
                dtgridList.Columns.Add("CheckBy");
                dtgridList.Columns.Add("RRID");
                dtgridList.Columns.Add("cmdDelete");
            }
            else
            {
                dtgridList = (DataTable)ViewState["dtgridList"];
            }


            dr = dtgridList.NewRow();
            dr["DateofTrans"] = this.txtDOT.Text;
            dr["TimeofTrans"] = this.txtTime.Text;
            dr["ProdID"] =  this.ddpProduct.SelectedValue;
            dr["ItemDescription"] = this.txtProductDesc.Text;
            dr["BatchNo"] = this.txtBatch.Text;
            dr["ModuleNo"] = this.txtModule.Text;
            dr["CageNo"] = this.txtCage.Text;
            dr["TotalCount"] = this.txtCount.Text;
            dr["Dead"] = this.txtDead.Text;
            dr["Deform"] = this.txtDeform.Text;
            dr["Age"] = this.txtAge.Text;
            dr["Salinity"] = this.txtSalinity.Text;
            dr["Temp"] = this.txtTemp.Text;
            dr["Weather"] = this.txtweather.Text;
            dr["WeightofFood"] = this.txtWeightofFood.Text;
            dr["RecordedBy"] = this.txtRecordedBy.Text;
            dr["CheckBy"] = this.txtCheckBy.Text;
            dr["RRID"] = Session["RRID"].ToString();
            dr["CmdDelete"] = "Delete";
            dtgridList.Rows.Add(dr);

            ViewState["dtgridList"] = dtgridList;
            GridView1.DataSource = dtgridList;
            GridView1.DataBind();
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

        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            int nIndex = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Delete")
            {
                if (GridView1.Rows.Count > 0)
                {
                    dtgridList = (DataTable)ViewState["dtgridList"];
                    dtgridList.Rows.RemoveAt(nIndex);
                    dtgridList.AcceptChanges();
                    GridView1.DataSource = dtgridList;
                    GridView1.DataBind();
                }
            }
        }

        protected void ddpProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["Products"];
            DataRow[] foundRows;
            string selectValue = "ID = " + this.ddpProduct.SelectedValue;
            string sortOrder = "ID ASC";
            foundRows = dt.Select(selectValue, sortOrder);
            for (int i = 0; i < foundRows.Length; i++)
                Console.WriteLine(foundRows[i][2]);
            if (foundRows != null)
            {
                this.txtProductDesc.Text = foundRows[0]["Description"].ToString();

            }
        }
            
        protected void BtnOk_Click(object sender, EventArgs e)
        {
            FrameWork.ProductsWareHouse prods = new FrameWork.ProductsWareHouse();
            prods.ProductId = int.Parse(this.drpFeeds.SelectedValue);
            prods.Out = decimal.Parse(this.txtOut.Text);
            prods.Return = decimal.Parse(this.txtReturn.Text);

            BusinessRule.busDailyMonitoring busprods = new BusinessRule.busDailyMonitoring();
            string x = busprods.ProductsWareHouse(prods);
            Session["RRID"] = x;
            txtWeightofFood.Text = this.txtOut.Text;

            //busCustomer buscust = new busCustomer();

            //DataTable dt = new DataTable("customer");
            //dt = buscust.allCustomer();
            //GridView1.DataSource = dt;
            //GridView1.DataBind();
        }

        protected void btnAddFood_Click(object sender, EventArgs e)
        {
            HiddenField1_ModalPopupExtender.Show();
        }

        protected void drpFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["Products"];
            DataRow[] foundRows;
            string selectValue = "ID = " + this.drpFeeds.SelectedValue;
            string sortOrder = "ID ASC";
            foundRows = dt.Select(selectValue, sortOrder);
            for (int i = 0; i < foundRows.Length; i++)
                Console.WriteLine(foundRows[i][2]);
            if (foundRows != null)
            {
                this.lblRemainingBal.Text = foundRows[0]["OnHand"].ToString();

            }
            HiddenField1_ModalPopupExtender.Show();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            HiddenField1_ModalPopupExtender.Hide();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            FrameWork.DailyMonitoring prods = new FrameWork.DailyMonitoring();
            prods.ProdID = this.ddpProduct.SelectedValue;
            prods.ItemDescription = txtProductDesc.Text;
            prods.BatchNo =int.Parse(this.txtBatch.Text);

            prods.ModuleNo = int.Parse(this.txtModule.Text);
            prods.CageNo = int.Parse(this.txtCage.Text);
            prods.TotalCount = int.Parse(this.txtCount.Text);
            prods.Dead = int.Parse(this.txtDead.Text);
            prods.Deform = int.Parse(this.txtDeform.Text);
            prods.Age = int.Parse(this.txtAge.Text);
            prods.Salinity = int.Parse(this.txtSalinity.Text);
            prods.Temp = int.Parse(this.txtTemp.Text);
            prods.Weather = this.txtweather.Text;
            prods.WeightofFood = int.Parse(this.txtWeightofFood.Text);
            prods.RecordedBy = this.txtRecordedBy.Text;
            prods.CheckBy = this.txtCheckBy.Text;
            prods.RRID = int.Parse(Session["RRID"].ToString());
            prods.DateofTrans =DateTime.Parse (this.txtDOT.Text);
            prods.TimeofTrans =this.txtTime.Text;


            BusinessRule.busDailyMonitoring busprods = new BusinessRule.busDailyMonitoring();
            string x = busprods.insertDailyMonitoring(prods);
            
          
        }

    }
}