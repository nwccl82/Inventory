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
    public partial class AddUser : System.Web.UI.Page
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

                DataTable dt = new DataTable("User");
                busAccessLevels busacc = new busAccessLevels();
                dt = busacc.allAccessLevel();
                this.ddpAccess.Items.Clear();
                this.ddpAccess.Items.Add(new ListItem("select one", "0"));
                foreach (DataRow dr in dt.Rows)
                {
                    this.ddpAccess.Items.Add(new ListItem(dr["AccessName"].ToString(), dr["IDAccess"].ToString()));
                }

                /*trial code*/
                //FrameWork.Login a = new FrameWork.Login();
                //BusLogin buslogin = new BusLogin();
                //DataTable userDt = new DataTable();
                //DataTable dt = new DataTable();
                ////dt = buslogin.allUser();
                //a.UserTable = buslogin.allUser();
                //dt = a.UserTable;
                //UserGridView.DataSource = dt;
                //UserGridView.DataBind();
                /*trial code*/
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            HiddenField1_ModalPopupExtender.Show();       
        }
        private bool isUserExisting()
        {
            string userid = this.txtLogin.Text;
            busEmployees busemp = new busEmployees();
            FrameWork.Employees log = busemp.isUserExisting(userid);
            if (log == null)
            {
                return false;
            }
            else if (userid.Equals(log.Login))
            {
                return true;
            }
            else
            {
                return false;
            }
 
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            busEmployees busemp = new busEmployees();
            Employees frmEmp = new Employees();
            frmEmp.FullName = this.txtFullname.Text;
            frmEmp.Email = this.txtEmail.Text;
            frmEmp.Login = this.txtLogin.Text;
            frmEmp.LastName = this.txtLastName.Text;
            frmEmp.passwords = this.txtPassword.Text;
            frmEmp.IDAccess = int.Parse(this.ddpAccess.SelectedValue);

            isExisting = isUserExisting();
            if (isExisting.Equals(true))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('User existing')", true);
            }
            else
            {
                string x = busemp.insertEmployee(frmEmp);

                if (x.Trim() == string.Empty)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Successfully added new User')", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Failed to added new User')", true);
                }
            }
            //DataTable dt = new DataTable("User");
            //dt = busemp.allUser();
            //GridView1.DataSource = dt;
            //GridView1.DataBind();

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }

     
    }
}