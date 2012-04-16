using FluentAssertions;
using NUnit.Framework;
using ServiceStack.ServiceClient.Web;
using ServiceStackApp;

namespace IntegrationTests
{
    [TestFixture]
    class When_requesting_a_hello_for_Demis
    {
        const string BasePath = "http://localhost:8888/";
        readonly JsonServiceClient jsonServiceClient = new JsonServiceClient(BasePath);

        [Test]
        public void Then_result_should_be_Hello_Demis()
        {
            jsonServiceClient.Get<HelloResponse>(BasePath + "hello/Demis").Result.Should().Be("Hello, Demis");
        }

        [Test]
        public void Then_json_should_contain_Hello_Demis()
        {
            jsonServiceClient.Send<object>(new Hello { Name = "Demis" }).ToString().Should().Contain("{{\"Result\":\"Hello, Demis\"}}");
        }
    }
}