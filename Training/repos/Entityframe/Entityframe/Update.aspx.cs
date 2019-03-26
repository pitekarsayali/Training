using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Entityframe
{
    public partial class Update : System.Web.UI.Page
    {
        private EmployeeModelContainer entities = new EmployeeModelContainer();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                if (Request.QueryString["Id"] != null)
                {
                    int ac = Convert.ToInt32(Request.QueryString["Id"]);
                    Employee emp = entities.Employees.Single(em => em.Id.Equals(ac));
                    txtName.Text = emp.Name;
                    txtSalary.Text = emp.Salary.ToString();
                }
            }


        }

        protected void update_Click(object sender, EventArgs e)
        {

            try
            {
                if ((!String.IsNullOrEmpty(txtName.Text)) && (!String.IsNullOrEmpty(txtSalary.Text)))
                {
                    int id = int.Parse(Request.QueryString["Id"]);
                    Employee emp = entities.Employees.Single(em => em.Id.Equals(id));
                    emp.Name = txtName.Text;
                    emp.Salary = Convert.ToInt32(txtSalary.Text);
                    entities.SaveChanges();

                    

                    Response.Redirect("AddEmployee.aspx");
                }
                else
                    lblResult.Text = "All inputs fields should must have a value";
            }
            catch (Exception)
            {
                lblResult.Text = "Can't update an employee.  Please check input types";
            }
        }
    }
}