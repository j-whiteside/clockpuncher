﻿using landlorder2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace landlorder2
{
    public partial class Tracker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Time started: " + DateTime.Now.ToLongTimeString();
            ClockOutButton.Visible = true;
            ClockInButton.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = "Time ended: " + DateTime.Now.ToLongTimeString();
            SubmitButton.Visible = true;
            ClockOutButton.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (DefaultConnectionEF conn = new DefaultConnectionEF())
            {
                WorkHours user = new WorkHours();

                if (Request.QueryString.Keys.Count > 0)
                {
                    var employeeId = Request.QueryString["Id"];

                    user = (from Emp in conn.AspNetUsers
                            where Emp.Id == employeeId
                            select Emp).FirstOrDefault();
                }
                user.UserName = UserName.Text.ToString();
                user.Email = EmailAddress.Text.ToString();
                user.hourlyWage = Convert.ToInt32(HourlyWage.Text.ToString());


                conn.SaveChanges();

                Response.Redirect("Employees.aspx");
            }


            Label3.Text = "Your hours have been submitted";
        }
    }
}