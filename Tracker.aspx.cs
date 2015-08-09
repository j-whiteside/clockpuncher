using landlorder2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using System.Data.Entity.Migrations;

namespace landlorder2
{
    public partial class Tracker : System.Web.UI.Page
    {
        DateTime clockInDateTime;
        DateTime clockOutDateTime;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            clockInDateTime = DateTime.Now;
            Label1.Text = "Time started: " + clockInDateTime.ToLongTimeString();
            ClockOutButton.Visible = true;
            ClockInButton.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            clockOutDateTime = DateTime.Now;
            Label2.Text = "Time ended: " + clockOutDateTime.ToLongTimeString();
            SubmitButton.Visible = true;
            ClockOutButton.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            string userId = User.Identity.GetUserId();
            using (DefaultConnectionEF conn = new DefaultConnectionEF())
            {
                WorkHour clock = new WorkHour();

                clock.ClockIn = clockInDateTime;
                clock.ClockOut = clockOutDateTime;
                clock.TimeWorked = Convert.ToInt32((clockOutDateTime - clockInDateTime).TotalMinutes);
                clock.Employee = userId;
                


                
                conn.WorkHours.AddOrUpdate(clock);
                conn.SaveChanges();

                Response.Redirect("Employees.aspx");
            }


            Label3.Text = "Your hours have been submitted";
        }
    }
}