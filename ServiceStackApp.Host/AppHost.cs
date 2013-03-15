using Funq;
using ServiceStack.ServiceInterface.Validation;
using ServiceStack.WebHost.Endpoints;
using ServiceStackApp.Services;
using ServiceStackApp.Validators;

namespace ServiceStackApp.Host
{
    public class AppHost : AppHostBase
    {
        //Tell Service Stack the name of your application and where to find your web services
        public AppHost() : base("Hello Web Services", typeof(HelloService).Assembly) { }

        public override void Configure(Container container)
        {
            Plugins.Add(new ValidationFeature());
            container.RegisterValidator(typeof(HelloValidator));
        }
    }
}