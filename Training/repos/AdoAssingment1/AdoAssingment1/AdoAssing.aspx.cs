using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace AdoAssingment1
{
    public partial class AdoAssing : System.Web.UI.Page
    {
        private object dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source = YH1008688DT\\SQLEXPRESS2014; Initial Catalog = Training; Integrated Security = True");
                SqlCommand cmd = new SqlCommand("select * from Employee1", con);
                con.Open();



                SqlDataReader rdr = cmd.ExecuteReader();
                GridView1.DataSource = rdr;
                GridView1.DataBind();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source = YH1008688DT\\SQLEXPRESS2014; Initial Catalog = Training; Integrated Security = True");
                SqlCommand cmd = new SqlCommand("select * from Employee1", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Employee ID");
                dt.Columns.Add("Employee Name");
                dt.Columns.Add("Employee salary");
                dt.Columns.Add("Salary after Hike");
                while (rdr.Read())
                {
                    dt.Rows.Add(rdr["Emp_ID"], rdr["Emp_name"], rdr["Emp_Sal"], 15 * (int)rdr["Emp_Sal"]);
                }

                GridView2.DataSource = dt;
                GridView2.DataBind();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        private void Close()
        {
            throw new NotImplementedException();
        }
    }
}