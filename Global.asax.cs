using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace landlorder2
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            HttpException objError = Server.GetLastError() as HttpException;

            if (objError.GetHttpCode() == 404)
            {
                Server.Transfer("/404.aspx");
                return;
            }

            Server.ClearError();
            Server.Transfer("/error.aspx");
        }
    }
}