﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using System.Web.Routing;

namespace SudokuWeb
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "ViewBusiness/api/{controller}/{id}",
            defaults: new { id = System.Web.Http.RouteParameter.Optional });
        }
    }
}