using Funq;
using ServiceStack.FluentValidation;
using ServiceStack.ServiceInterface.Validation;
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
            Plugins.Add(new ValidationFeature());
            container.RegisterValidator(typeof(HelloValidator));
        }
    }

    public class HelloValidator : AbstractValidator<Hello>
    {
        public HelloValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please provide a name");
        }
    }
}