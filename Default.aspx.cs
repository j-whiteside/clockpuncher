﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace landlorder2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
                PrivateMessage.Visible = false;
                PublicMessage.Visible = true;
            }
            else
            {
                PrivateMessage.Visible = true;
                PublicMessage.Visible = false;
            }
        }
    }
}