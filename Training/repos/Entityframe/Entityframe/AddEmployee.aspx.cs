using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Entityframe
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        private EmployeeModelContainer enitities = new EmployeeModelContainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillData();
            }


        }
        private void FillData()
        {
            GridView1.DataSource = enitities.Employees.Select
                (emp => new
                {
                    id = emp.Id,
                    Name = emp.Name,
                    Salary = emp.Salary
                }

                ).ToList();
            GridView1.DataBind();
        }

        protected void btnAddEmployee_Click(object sender, EventArgs e)
        {
            
            try
            {
                Employee emp = new Employee();
                emp.Name = txtName.Text;
  
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                enitities.Employees.Add(emp);
                enitities.SaveChanges();
                FillData();

            }
            catch (Exception)
            {
                lblResult.Text = "Can't add a new employee";
            }
            

        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            HiddenField hd = (HiddenField)lb.FindControl("hdfId");
            int ab = Convert.ToInt32(hd.Value);
            Employee emp = enitities.Employees.Single(em => em.Id.Equals(ab));
            enitities.Employees.Remove(emp);
            enitities.SaveChanges();
            FillData();
        }

        protected void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            Response.Redirect("Update.aspx");
        }
    }
}