using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FrameWork;
using BusinessRule;
using System.Data;
namespace Inventory
{
    public partial class ViewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                busEmployees busemp = new busEmployees();
                //FrameWork.Login[] log;
                //log = buslogin.getAllUser();
                //UserGridView.DataSource = log;
                //UserGridView.DataBind();

                DataTable dt = new DataTable("User");
                dt = busemp.allUser();
                ViewState["User"] = dt;
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userid = "";
            string fName = "";
            string lName = "";
            string fullName = "";
            string address = "";
            string phoneNo = "";
            string cellphoneNo = "";
            string email = "";
            string position = "";
            string hello = "";

            hello = GridView1.SelectedDataKey["id"].ToString();
            ViewState["id"] = hello;

            GridView dummyUsergrv = new GridView();
            dummyUsergrv = (GridView)sender;
            userid = dummyUsergrv.SelectedRow.Cells[1].Text;
            fName = dummyUsergrv.SelectedRow.Cells[2].Text;
            lName = dummyUsergrv.SelectedRow.Cells[3].Text;
            // fullName = dummyUsergrv.SelectedRow.Cells[5].Text;
            // address = dummyUsergrv.SelectedRow.Cells[6].Text;
            // phoneNo = dummyUsergrv.SelectedRow.Cells[7].Text;
            // cellphoneNo = dummyUsergrv.SelectedRow.Cells[8].Text;
            email = dummyUsergrv.SelectedRow.Cells[4].Text;
            // position = dummyUsergrv.SelectedRow.Cells[10].Text;

            //if (userid.Equals("&nbsp;"))
            //{
            //    this.txtLogin.Text = "";
            //}
            //else
            //{
            //    this.txtLogin.Text = userid;
            //}

            //if (fName.Equals("&nbsp;"))
            //{
            //    this.txtFullname.Text = "";
            //}
            //else
            //{
            //    this.txtFullname.Text = fName;
            //}

            //if (lName.Equals("&nbsp;"))
            //{
            //    this.txtLastName.Text = "";
            //}
            //else
            //{
            //    this.txtLastName.Text = lName;
            //}

            ////if (fullName.Equals("&nbsp;"))
            ////{
            ////    this.txtFullname.Text = "";
            ////}
            ////else
            ////{
            ////    this.txtFullname.Text = fullName;
            ////}

            ////if (address.Equals("&nbsp;"))
            ////{
            ////    this.txtBoxAddress.Text = "";
            ////}
            ////else
            ////{
            ////    this.txtBoxAddress.Text = address;
            ////}

            ////if (phoneNo.Equals("&nbsp;"))
            ////{
            ////    this.txtBoxPhoneNo.Text = "";
            ////}
            ////else
            ////{
            ////    this.txtBoxPhoneNo.Text = phoneNo;
            ////}

            ////if (cellphoneNo.Equals("&nbsp;"))
            ////{
            ////    this.txtBoxCellphoneNo.Text = "";
            ////}
            ////else
            ////{
            ////    this.txtBoxCellphoneNo.Text = cellphoneNo;
            ////}

            //if (email.Equals("&nbsp;"))
            //{
            //    this.txtEmail.Text = "";
            //}
            //else
            //{
            //    this.txtEmail.Text = email;
            //}

            ////if (position.Equals("&nbsp;"))
            ////{
            ////    this.txtBoxPosition.Text = "";
            ////}
            ////else
            ////{
            ////    this.txtBoxPosition.Text = position;
            ////}
        }


        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("del"))
            {
                LinkButton lnkBtn = (LinkButton)e.CommandSource;    // the button
                GridViewRow myRow = (GridViewRow)lnkBtn.Parent.Parent;  // the row
                GridView myGrid = (GridView)sender; // the gridview
                string ID = myGrid.DataKeys[myRow.RowIndex].Value.ToString();
                //hello = myGrid.SelectedRow.Cells[1].Text;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["User"];
            DataRow[] foundRows;
            string selectValue = "LastName like '%" + this.txtLastName.Text.Trim() +"%'";
            string sortOrder = "LastName ASC";
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