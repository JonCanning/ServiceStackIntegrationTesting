using System;

namespace ServiceStackApp.Host
{
    public class Global : System.Web.HttpApplication
    {
        //Initialize your application singleton
        protected void Application_Start(object sender, EventArgs e)
        {
            new AppHost().Init();
        }
    }
}