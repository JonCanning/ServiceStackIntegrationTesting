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
        readonly JsvServiceClient jsvServiceClient = new JsvServiceClient(BasePath);

        [Test]
        public void Then_hello_Demis_should_be_returned()
        {
            jsvServiceClient.Get<HelloResponse>(BasePath + "hello/Demis").Result.Should().Be("Hello, Demis");
        }
    }
}