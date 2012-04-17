using System;
using CassiniDev;
using NUnit.Framework;

namespace IntegrationTests
{
    [SetUpFixture]
    public class SetUpFixture : CassiniDevServer
    {
        internal const string BasePath = "http://localhost:8888/";

        [SetUp]
        protected virtual void TestFixtureSetUp()
        {
            StartServer(Environment.CurrentDirectory + @"..\..\..\..\ServiceStackApp", 8888, "", "");
        }

        [TearDown]
        public void TestFixtureTearDown()
        {
            StopServer();
        }
    }
}
