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
            Button2.Visible = true;
            Button1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = "Time ended: " + DateTime.Now.ToLongTimeString();
            Button1.Visible = true;
            Button2.Visible = false;
        }
    }
}