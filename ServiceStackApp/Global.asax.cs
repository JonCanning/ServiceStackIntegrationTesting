using System;

namespace ServiceStackApp
{
    public class Global : System.Web.HttpApplication
    {
        //Initialize your application singleton
        protected void Application_Start(object sender, EventArgs e)
        {
            new HelloAppHost().Init();
        }
    }
}