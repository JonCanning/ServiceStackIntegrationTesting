using System.Net;
using FluentAssertions;
using NUnit.Framework;
using ServiceStack.Text;
using ServiceStackApp;
using ServiceStackApp.Dtos;

namespace IntegrationTests
{
    [TestFixture]
    class When_using_a_nullable_int_and_bad_json
    {
        [Test]
        public void Then_number_in_response_should_not_be_set()
        {
            var client = new WebClient { BaseAddress = SetUpFixture.BasePath };
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            var json = JsonSerializer.SerializeToString(new Hello { Name = "Demis", Number = 1 });
            json = json.Replace("1", "crap");
            var response = client.UploadString("hello?format=json", json);
            response.Should().NotContain("Number");
        }
    }
}