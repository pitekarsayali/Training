using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Crud_Operation
{
    public partial class CrudOp2 : System.Web.UI.Page
    {
        string conStr = ConfigurationManager.ConnectionStrings["Training"].ConnectionString;
       SqlConnection con=null;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Getdata();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(conStr);
                using (SqlCommand cmd = new SqlCommand("usp_insert ", con))
                {
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@name", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@salary", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@hike", TextBox4.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();

                   

                }
                Label1.Text = "Data inserted successfully....";

            }
            catch (Exception)
            {
            }
            

        }
        protected void Show_Click(object sender, EventArgs e)
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

        protected void Update_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(conStr);
                using (SqlCommand cmd = new SqlCommand("usp_update", con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@name", TextBox2.Text);
                    
                    con.Open();
                    cmd.ExecuteNonQuery();



                }
                Label1.Text = "Data updated successfully....";
            }
            catch (Exception)
            {
            }

        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(conStr);
                using (SqlCommand cmd = new SqlCommand("usp_delete", con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", TextBox1.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();



                }
                Label1.Text = "Data deleted successfully....";
            }
            catch (Exception)
            {
            }

        }
        public void Getdata()
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

        
    }
}