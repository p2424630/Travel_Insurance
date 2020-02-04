using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelInsuranceClasses;

namespace TravelInsuranceTest
{
    [TestClass]
    public class tstPolicy
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Instantiate The class
            clsPolicy APolicy = new clsPolicy();
            //test if exists
            Assert.IsNotNull(APolicy);
        }
    }
}
