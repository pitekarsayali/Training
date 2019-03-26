using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Crud_Operation
{
    public partial class CrudOP : System.Web.UI.Page
    {
        string conStr = ConfigurationManager.ConnectionStrings["training"].ConnectionString;
        SqlConnection con = null;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conStr);

            cmd = new SqlCommand("select * from Employee1", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conStr);
            cmd = new SqlCommand("insert into Employee1 values(11,'mahi',9000,8777)", con);
            con.Open();
            cmd.ExecuteNonQuery();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conStr);
            cmd = new SqlCommand("update Employee1 set Emp_name='krishna' where Emp_ID=5", con);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conStr);
            cmd = new SqlCommand("DELETE Employee1 where Emp_ID=5", con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}