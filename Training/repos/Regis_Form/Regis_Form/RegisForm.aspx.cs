using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Regis_Form
{
    public partial class RegisForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["name"] = txtEmpName.Text;
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

        protected void Button1_Click(object sender, EventArgs e)
        {


        }

        protected void dropdwn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void state_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<int, string> ka = new Dictionary<int, string>();
            ka.Add(1, "Mumbai");
            ka.Add(2, "Nashik");
            ka.Add(3, "Shirdi");
            ka.Add(4, "Nagpur");
            ka.Add(5, "Pune");

            Dictionary<int, string> tl = new Dictionary<int, string>();
            tl.Add(1, "Kochi");
            tl.Add(2, "Kollam");

            Dictionary<int, string> mh = new Dictionary<int, string>();
            mh.Add(1, "Medak");
            mh.Add(2, "Madhapur");
            mh.Add(3, "Hitech City");
            mh.Add(4, "JNTU");
            if (state.SelectedIndex == 0)
            {
                dropdwn.DataSource = ka;
                dropdwn.DataTextField = "Value";
                dropdwn.DataValueField = "Key";
                dropdwn.DataBind();

            }
            if (state.SelectedIndex == 1)
            {
                dropdwn.DataSource = tl;
                dropdwn.DataTextField = "Value";
                dropdwn.DataValueField = "Key";
                dropdwn.DataBind();
            }
            if (state.SelectedIndex == 2)
            {
                dropdwn.DataSource = mh;
                dropdwn.DataTextField = "Value";
                dropdwn.DataValueField = "Key";
                dropdwn.DataBind();
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("WelcomeForm.aspx");
        }
    }
}