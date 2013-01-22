using FluentAssertions;
using NUnit.Framework;
using ServiceStack.ServiceClient.Web;
using ServiceStack.Text;
using ServiceStackApp;
using System.Net;

namespace IntegrationTests
{
    [TestFixture]
    class When_requesting_a_hello_for_Demis
    {
        readonly JsonServiceClient jsonServiceClient = new JsonServiceClient(SetUpFixture.BasePath);
        HelloResponse response;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            response = jsonServiceClient.Get<HelloResponse>("hello/Demis");
        }

        [Test]
        public void Then_result_should_be_Hello_Demis()
        {
            response.Result.Should().Be("Hello, Demis");
        }

        [Test]
        public void Then_status_should_be_waving()
        {
            response.Status.Should().Be(Status.Waving);
        }

        [Test]
        public void Then_json_should_contain_Hello_Demis()
        {
            var json = new WebClient().UploadString(SetUpFixture.BasePath + "hello/Demis?format=json", new Hello { Name = "Demis" }.ToJson());
            json.Should().Contain(@"{""Result"":""Hello, Demis""}");
        }
    }
}