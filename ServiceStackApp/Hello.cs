using ServiceStack.ServiceHost;

namespace ServiceStackApp
{
    public class Hello : IReturn<HelloResponse>
    {
        public string Name { get; set; }
        public int? Number { get; set; }
        public Status Status { get; set; }
    }
}