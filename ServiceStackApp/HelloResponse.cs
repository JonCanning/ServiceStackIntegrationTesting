using ServiceStack.ServiceInterface.ServiceModel;

namespace ServiceStackApp
{
    public class HelloResponse : ResponseStatus
    {
        public string Result { get; set; }

        public int? Number { get; set; }
    }
}