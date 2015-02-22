using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp00
{
    [TestClass]
    public class HelloTest
    {
        [TestMethod]
        public void SayHallo()
        {
            Assert.AreEqual("Hello, World!", new Hello().SayHello());
        }

        [TestMethod]
        public void SayHalloTo()
        {
            Assert.AreEqual("Hello, Pietro!", new Hello().SayHelloTo("Pietro"));
        }

        [TestMethod]
        public void SayHalloToWithCustomGreeting()
        {
            Assert.AreEqual("Hi, Pietro!", new Hello("Hi").SayHelloTo("Pietro"));
        }
    }
}
