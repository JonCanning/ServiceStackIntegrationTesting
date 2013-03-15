using ServiceStack.ServiceInterface;
using ServiceStackApp.Dtos;

namespace ServiceStackApp.Services
{
    public class HelloService : Service
    {
        public object Post(Hello request)
        {
            return Execute(request);
        }

        public object Get(Hello request)
        {
            return Execute(request);
        }

        static object Execute(Hello request)
        {
            return new HelloResponse { Result = "Hello, " + request.Name, Number = request.Number, Status = request.Status };
        }
    }
}