using FluentAssertions;
using NUnit.Framework;
using ServiceStack.ServiceClient.Web;
using ServiceStackApp.Dtos;
using System.Linq;

namespace IntegrationTests
{
    [TestFixture]
    class When_sending_an_invalid_hello
    {
        readonly JsonServiceClient jsonServiceClient = new JsonServiceClient(SetUpFixture.BasePath);

        [Test]
        public void Then_web_service_exception_should_be_thrown()
        {
            jsonServiceClient.Invoking(x => x.Get<HelloResponse>("hello")).ShouldThrow<WebServiceException>("Bad Request");
        }

        [Test]
        public void Then_error_message_should_be_returned()
        {
            try
            {
                jsonServiceClient.Get<HelloResponse>("hello");
            }
            catch (WebServiceException exception)
            {
                exception.ResponseDto.As<HelloResponse>().ResponseStatus.Errors.First().Message.Should().Be("Please provide a name");
            }
        }
    }
}