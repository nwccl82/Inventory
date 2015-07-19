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

                dtgridList.Columns.Add("cmdDelete");
            }
            else
            {
                dtgridList = (DataTable)ViewState["dtgridList"];
            }


            dr = dtgridList.NewRow();
            dr["DateofTrans"] = this.txtDOT.Text;
            dr["TimeofTrans"] = this.txtTime.Text;
            dr["ProdID"] = "1";// this.ddpProduct.Text;
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

    }
}