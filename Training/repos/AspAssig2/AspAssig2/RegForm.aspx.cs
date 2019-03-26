using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspAssig2
{
    public partial class RegForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Dictionary<int, string> st = new Dictionary<int, string>();
                st.Add(1, "Maharashtra");
                st.Add(2, "Kerala");
                st.Add(3, "Telangana");

                state.DataSource = st;
                state.DataTextField = "Value";
                state.DataValueField = "Key";
                state.DataBind();


            }

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //List<UserData> LstUserData = new List<UserData>();//it overwrite data
            List<EmpInfo> LstEmpData = Session["User"] != null ? (List<EmpInfo>)Session["User"] : new List<EmpInfo>();
            EmpInfo emp = LstEmpData.Find(x => x.userName == txtEmpName.Text);
            if (emp == null)
            {

                emp = new EmpInfo();
                emp.userName = txtEmpName.Text;
                emp.mailid = txtemail.Text;
                emp.phone = txtboxPhone.Text;
                //emp.state = state.Text;
                //emp.city = dropdwn.Text;

                emp.userName = txtEmpName.Text;
                emp.password = txtpass.Text;

                LstEmpData.Add(emp);
                Session["User"] = LstEmpData;
                Label3.Text = "User Registered Successfully";
                
                //GridView1.DataSource = LstEmpData;
                //GridView1.DataBind();
                Response.Redirect("~/loginForm.aspx?empname="+txtEmpName.Text);

            }
            else if (emp != null)
            {

                //Labelmsg.Text = "User Is already Registered!";
                Response.Redirect("~/loginForm.aspx");
            }













        }

        protected void state_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<int, string> mh = new Dictionary<int, string>();
            mh.Add(1, "Mumbai");
            mh.Add(2, "Pune");
            mh.Add(3, "Kolhapur");
            mh.Add(4, "Solhapur");


            Dictionary<int, string> ker = new Dictionary<int, string>();
            ker.Add(1, "Kochi");
            ker.Add(2, "Kattam");

            Dictionary<int, string> tel = new Dictionary<int, string>();
            tel.Add(1, "Medak");
            tel.Add(2, "Madhapur");
            tel.Add(3, "Hitchcity");
            tel.Add(4, "JNTU");
            if (state.SelectedIndex == 0)
            {
                dropdwn.DataSource = mh;
                dropdwn.DataTextField = "Value";
                dropdwn.DataValueField = "Key";
                dropdwn.DataBind();

            }
            if (state.SelectedIndex == 1)
            {
                dropdwn.DataSource = ker;
                dropdwn.DataTextField = "Value";
                dropdwn.DataValueField = "Key";
                dropdwn.DataBind();
            }
            if (state.SelectedIndex == 2)
            {
                dropdwn.DataSource = tel;
                dropdwn.DataTextField = "Value";
                dropdwn.DataValueField = "Key";
                dropdwn.DataBind();
            }
        }
        protected void dropdwn_SelectedIndexChanged(object sender, EventArgs e) { }
        

    }
}

