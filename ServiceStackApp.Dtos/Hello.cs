using ServiceStack.Common.Web;
using ServiceStack.ServiceHost;

namespace ServiceStackApp.Dtos
{
    [Route("hello/", HttpMethods.Get + "," + HttpMethods.Post)]
    [Route("hello/{Name}", HttpMethods.Get + "," + HttpMethods.Post)]
    public class Hello : IReturn<HelloResponse>
    {
        public string Name { get; set; }
        public int? Number { get; set; }
        public Status Status { get; set; }
    }
}