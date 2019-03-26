using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Entityframe
{
    public partial class DisplayGrid : System.Web.UI.Page
    {
        private EmployeeModelContainer entities = new EmployeeModelContainer();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillData();
            }



        }
        private void FillData()
        {
            GridView1.DataSource = entities.Employees.Select
                (emp => new
                {
                    Name = emp.Name,
                   Salary = emp.Salary
                }

                ).ToList();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}