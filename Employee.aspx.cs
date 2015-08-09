using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using landlorder2.Models;

namespace landlorder2
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Keys.Count > 0)
            {
                getEmployee();
            }
        }

        protected void getEmployee()
        {
            using (DefaultConnectionEF conn = new DefaultConnectionEF())
            {
                var employeeId = Request.QueryString["Id"];
       
                var e = (from Employee in conn.AspNetUsers
                         where Employee.Id == employeeId
                         select Employee).FirstOrDefault();
                UserName.Text = e.UserName;
                EmailAddress.Text = e.Email;
                HourlyWage.Text = e.hourlyWage.ToString();

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            using (DefaultConnectionEF conn = new DefaultConnectionEF())
            {
                AspNetUser user = new AspNetUser();

                
                user.UserName = UserName.Text.ToString();
                user.Email = EmailAddress.Text.ToString();
                user.hourlyWage = Convert.ToInt32(HourlyWage.Text.ToString());
          

                conn.SaveChanges();

                Response.Redirect("Employees.aspx");
            }
        }
    }
}