using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp00
{
    [TestClass]
    public class UsingDelegateTest
    {
        private double Double(double input)
        {
            return 2 * input;
        }

        [TestMethod]
        public void callDelegateByReference()
        {
            MathAction action = Double;
            Assert.AreEqual(10, action(5));
        }

        [TestMethod]
        public void passingDelegateAsParameter()
        {
            UsingDelegate ud = new UsingDelegate(Double);
            Assert.AreEqual(10, ud.doMath(5));
        }
    }
}
