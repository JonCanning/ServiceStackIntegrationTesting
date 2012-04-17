using ServiceStack.ServiceHost;

namespace ServiceStackApp
{
    public class HelloService : IService<Hello>
    {
        public object Execute(Hello request)
        {
            return new HelloResponse {Result = "Hello, " + request.Name, Number = request.Number};
        }
    }
}