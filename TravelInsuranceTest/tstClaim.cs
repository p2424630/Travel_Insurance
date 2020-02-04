using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TravelInsuranceTest
{
    [TestClass]
    public class tstClaim
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsClaim AClaim = new clsClaim();
            Assert.IsNotNull(AClaim);
        }
    }
}
