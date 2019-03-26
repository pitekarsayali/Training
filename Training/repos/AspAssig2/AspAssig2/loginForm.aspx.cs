using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AspAssig2
{
    public partial class loginForm : System.Web.UI.Page
    {
        public object Msg { get; private set; }
        public object GridView1 { get; private set; }
        public object LstEmpData { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
          

            if (!this.IsPostBack)
            {
                

                if (this.Page.User.Identity.IsAuthenticated)
                {
                    FormsAuthentication.SignOut();
                    Response.Redirect("~/loginForm.aspx");

                }
               
            }

        }
        protected void Button1_Click1(object sender, EventArgs e)
        {

            if (Request.QueryString["empname"] != null)
            {

                // List<EmpInfo> LstEmpData = new List<EmpInfo>();
                List<EmpInfo> LstEmpData = Session["User"] != null ? (List<EmpInfo>)Session["User"] : new List<EmpInfo>();
                EmpInfo emp = LstEmpData.Find(x => x.userName == Request.QueryString["empname"]);
                if (emp!=null)
                {
                    //label1.Text = "User Is already Registered!";
                    txtUserName.Text = emp.userName;
                    txtUserPassword.Text = emp.userName;

                     
                }
                 
                gd.DataSource = LstEmpData;
                gd.DataBind();
            }


            //if (FormsAuthentication.Authenticate(txtUserName.Text, txtUserPassword.Text))
            //{
            //    FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, true);
            //}
            //else
            //{
            //    errLabel.Text = "Invalid User Name AND/OR Password";
            //}
            //GridView2.DataSource = LstEmpData;
            //GridView2.DataBind();
        }

        
    }
}