using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;


namespace DoctorChatv5
{
    public class Global : System.Web.HttpApplication
    {
        string CAD = "";
       
        protected void Application_Start(object sender, EventArgs e)
        {
            
        }

        void Session_Start(object sender, EventArgs e)
        {
            Session["cadena"] = CAD;
        }
    }
}