using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Tests.MyWebServiceReference;

namespace WebApplication1.Tests
{
    [TestClass]
    public class TestMyWebService
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyWebServiceReference.MyWebServiceSoap service = new MyWebServiceSoapClient();

            var response = service.HelloWorld(new HelloWorldRequest());
            Assert.AreEqual("Hello World", response.Body.HelloWorldResult);
        }
    }
}
