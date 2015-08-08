using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using landlorder2.Models;

namespace landlorder2
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getEmployeeList();
        }
        protected void getEmployeeList()
        {
            using (DefaultConnectionEF conn = new DefaultConnectionEF())
            {
                var employees = from e in conn.AspNetUsers
                                select e;

                GrdEmployee.DataSource = employees.ToList();
                GrdEmployee.DataBind();
            }
        }
        protected void GrdEmployee_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GrdEmployee_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
    }
}