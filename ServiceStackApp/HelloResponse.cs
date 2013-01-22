using ServiceStack.ServiceInterface.ServiceModel;

namespace ServiceStackApp
{
    public class HelloResponse : IHasResponseStatus
    {
        public string Result { get; set; }

        public int? Number { get; set; }

        public ResponseStatus ResponseStatus { get; set; }

        public Status Status {get; set;}
    }

    public enum Status
    {
        Waving,
        HandShake
    }
}