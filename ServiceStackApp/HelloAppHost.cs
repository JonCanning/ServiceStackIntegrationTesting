using Funq;
using ServiceStack.WebHost.Endpoints;

namespace ServiceStackApp
{
    public class HelloAppHost : AppHostBase
    {
        //Tell Service Stack the name of your application and where to find your web services
        public HelloAppHost() : base("Hello Web Services", typeof(HelloService).Assembly) { }

        public override void Configure(Container container)
        {
            //register user-defined REST-ful urls
            Routes
                .Add<Hello>("/hello")
                .Add<Hello>("/hello/{Name}");
        }
    }
}