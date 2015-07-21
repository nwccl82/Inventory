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
    public partial class SuppliersProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!Page.IsPostBack)
            {
                BindCountry();
            }
            if (!IsPostBack)
            {
                busSupplier bussup = new busSupplier();

                DataTable dt = new DataTable("User");
                dt = bussup.allSupplier();
                GridView1.DataSource = dt;
                GridView1.DataBind();


            }
        }
        private void BindCountry()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("xml\\countries.xml"));

            foreach (XmlNode node in doc.SelectNodes("//country"))
            {
                ddlCountry.Items.Add(new ListItem(node.InnerText, node.Attributes["code"].InnerText));
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ////Hashtable htParameters = new Hashtable();

            ////htParameters.Add("Mode", 0);
            ////htParameters.Add("Company",txtCompanyName.Text);
            ////htParameters.Add("LastName",txtLastName.Text);
            ////htParameters.Add("FirstName",txtFirstName.Text);
            ////htParameters.Add("EmailAddress",txtEmail.Text);
            ////htParameters.Add("JobTitle",ddlDesignation.Text); 
            ////htParameters.Add("BusinessPhone",txtTelephone.Text);

            //////htParameters.Add("HomePhone",DBNull.Value);
            ////    //,MobilePhone
            ////htParameters.Add("FaxNumber",txtFax.Text);
            ////htParameters.Add("Address",txtNo.Text + " " + txtStreet.Text + " " + ddlCountry.SelectedValue + " " + txtZipCode.Text);
            ////htParameters.Add("ZipPostal", txtZipCode.Text);
            ////htParameters.Add("WebPage", txtWebsite.Text);

            FrameWork.Suppliers supp = new FrameWork.Suppliers();
            supp.Company = txtCompanyName.Text;
            supp.Address = txtNo.Text + " " + txtStreet.Text + " " + ddlCountry.SelectedValue + " " + txtZipCode.Text;
            supp.TIN = txtTIN.Text;
            supp.LastName = txtLastName.Text;
            supp.FirstName = txtFirstName.Text;
            supp.EmailAddress = txtEmail.Text;
            supp.JobTitle = ddlDesignation.Text;
            supp.BusinessPhone = txtTelephone.Text;
            supp.FaxNumber = txtFax.Text;
            supp.ZipPostal = txtZipCode.Text;
            supp.WebPage = txtWebsite.Text;

            BusinessRule.busSupplier supps = new BusinessRule.busSupplier();
            supps.insertSupplier(supp);

            busSupplier bussup = new busSupplier();

            DataTable dt = new DataTable("User");
            dt = bussup.allSupplier();
            GridView1.DataSource = dt;
            GridView1.DataBind();

            //MainClass.Library.Command.Execute(htParameters, "SupplierMod");


                //,City 
                //,StateProvince 
                //,ZipPostal
                //,CountryRegion
                //,WebPage
                //,Notes 
                //,Attachments
                //,SupplierName 
                //,FileAs
            

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
    }
}