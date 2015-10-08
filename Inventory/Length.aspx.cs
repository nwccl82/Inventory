﻿using System;
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
    public partial class Length : System.Web.UI.Page
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
                busLength buscat = new busLength();
                DataTable dt = new DataTable("User");
                dt = buscat.allCategories();
                GridView1.DataSource = dt;
                GridView1.DataBind();
         }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            busLength buscat = new busLength();
            FrameWork.Length frmcat = new FrameWork.Length();
            frmcat.Lengths = this.txtCategory.Text;


            isExisting = isUserExisting();
            if (isExisting.Equals(true))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Length existing')", true);
            }
            else
            {
                buscat.insertCategory(frmcat);
            }
            DataTable dt = new DataTable("User");
            dt = buscat.allCategories();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        private bool isUserExisting()
        {
            string userid = this.txtCategory.Text;
            busLength buscat = new busLength();
            FrameWork.Length frmcat = new FrameWork.Length();
            frmcat = buscat.isUserExisting(userid);
            //FrameWork.Employees log = busemp.isUserExisting(userid);
            if (frmcat == null)
            {
                return false;
            }
            else if (userid.Equals(frmcat.Lengths))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}