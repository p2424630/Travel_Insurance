using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TravelInsuranceClasses;

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

        [TestMethod]
        public void ClaimReasonPropertyOK()
        {
            clsClaim AClaim = new clsClaim();
            String TestData = "";
            AClaim.ClaimReason = TestData;
            Assert.AreEqual(AClaim.ClaimReason, TestData);
        }

        [TestMethod]
        public void ClaimDatePropertyOK()
        {
            clsClaim AClaim = new clsClaim();
            DateTime TestData = DateTime.Now.Date;
            AClaim.ClaimDate = TestData;
            Assert.AreEqual(AClaim.ClaimDate, TestData);
        }

        [TestMethod]
        public void ClaimAmntPropertyOK()
        {
            clsClaim AClaim = new clsClaim();
            Decimal TestData = 1.01M;
            AClaim.ClaimAmnt = TestData;
            Assert.AreEqual(AClaim.ClaimAmnt, TestData);
        }

        [TestMethod]
        public void ClaimStatusPropertyOK()
        {
            clsClaim AClaim = new clsClaim();
            Boolean TestData = true;
            AClaim.ClaimStatus = TestData;
            Assert.AreEqual(AClaim.ClaimStatus, TestData);
        }

        [TestMethod]
        public void PolicyIDPropertyOK()
        {
            clsClaim AClaim = new clsClaim();
            Int32 TestData = 12345;
            AClaim.PolicyID = TestData;
            Assert.AreEqual(AClaim.PolicyID, TestData);
        }

        [TestMethod]
        public void ClaimIDPropertyOK()
        {
            clsClaim AClaim = new clsClaim();
            Int32 TestData = 12345;
            AClaim.ClaimID = TestData;
            Assert.AreEqual(AClaim.ClaimID, TestData);
        }

    }
}
