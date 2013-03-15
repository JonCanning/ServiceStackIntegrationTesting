using FluentAssertions;
using NUnit.Framework;
using ServiceStack.Text;
using ServiceStackApp.Dtos;
using System.Net;

namespace IntegrationTests
{
    [TestFixture]
    class When_using_a_nullable_int_and_valid_json
    {
        [Test]
        public void Then_number_in_response_should_be_set()
        {
            var client = new WebClient { BaseAddress = SetUpFixture.BasePath };
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            var json = JsonSerializer.SerializeToString(new Hello { Name = "Demis", Number = 1 });
            var response = client.UploadString("hello?format=json", json);
            response.Should().Contain(@"""Number"":1");
        }
    }
}