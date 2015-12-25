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
    public partial class CustomerProfile : System.Web.UI.Page
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
            HiddenField1_ModalPopupExtender.Show();            
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
       
         
            FrameWork.Customers cust = new FrameWork.Customers();
            cust.Company = txtCompanyName.Text;
            cust.Address = txtNo.Text + " " + txtStreet.Text + " " + ddlCountry.SelectedValue + " " + txtZipCode.Text;
            cust.TIN = txtTIN.Text;
            cust.LastName = txtLastName.Text;
            cust.FirstName = txtFirstName.Text;
            cust.EmailAddress = txtEmail.Text;
            cust.JobTitle = ddlDesignation.Text;
            cust.BusinessPhone = txtTelephone.Text;
            cust.FaxNumber = txtFax.Text;
            cust.ZipPostal = txtZipCode.Text;
            cust.WebPage = txtWebsite.Text;
            BusinessRule.busCustomer custs = new BusinessRule.busCustomer();
            string  x = custs.insertCustomer(cust);

            if (x.Trim() == string.Empty)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Successfully added new Customer')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Failed to added new Customer')", true);
            }


            busCustomer buscust = new busCustomer();
            DataTable dt = new DataTable("customer");
            dt = buscust.allCustomer();
            //GridView1.DataSource = dt;
            //GridView1.DataBind();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }

   
    }
}