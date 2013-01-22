using FluentAssertions;
using NUnit.Framework;
using ServiceStack.ServiceClient.Web;
using ServiceStackApp;

namespace IntegrationTests
{
    [TestFixture]
    class When_requesting_a_hello_and_handshake_for_Demis
    {
        readonly JsonServiceClient jsonServiceClient = new JsonServiceClient(SetUpFixture.BasePath);
        HelloResponse response;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            response = jsonServiceClient.Post<HelloResponse>("hello/Demis", new Hello{Status = Status.HandShake});
        }

        [Test]
        public void Then_status_should_be_handshake()
        {
            response.Status.Should().Be(Status.HandShake);
        }
    }
}