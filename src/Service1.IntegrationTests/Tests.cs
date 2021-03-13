using NUnit.Framework;
using System;
using System.Net;

namespace Service1.IntegrationTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            WebRequest myWebRequest = WebRequest.Create("http://service1:5000/weatherforecast");

            WebResponse myWebResponse = myWebRequest.GetResponse();
            Assert.IsNotNull(myWebResponse);
        }
    }
}