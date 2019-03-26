using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspAssig2
{
    public partial class homeForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("EMP_ID");
            dt.Columns.Add("EMP_NAME");
            dt.Columns.Add("EMP_SALARY");

            dt.Rows.Add(1, "Pooja", 35000);
            dt.Rows.Add(2, "Sayali", 15000);
            dt.Rows.Add(3, "Mayuri", 25000);
            dt.Rows.Add(4, "Dipa", 35000);
            dt.Rows.Add(5, "Saniya", 45000);
            dt.Rows.Add(6, "Sakshi", 55000);

            GridView1.DataSource = dt;

            GridView1.DataBind();
        }
    }
}