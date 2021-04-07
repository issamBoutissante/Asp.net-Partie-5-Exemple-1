﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Partie_5_Exemple_1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["visites"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application["visites"] = (int)Application["Visites"] + 1;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["visites"]=(int)Application["visites"]-1;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}