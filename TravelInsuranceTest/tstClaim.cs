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
        public void CustomerIDPropertyOK()
        {
            clsClaim AClaim = new clsClaim();
            Int32 TestData = 1;
            AClaim.CustomerID = TestData;
            Assert.AreEqual(AClaim.CustomerID, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsClaim AClaim = new clsClaim();
            Int32 TestData = 1;
            AClaim.StaffID = TestData;
            Assert.AreEqual(AClaim.StaffID, TestData);
        }

        [TestMethod]
        public void ClaimIDPropertyOK()
        {
            clsClaim AClaim = new clsClaim();
            Int32 TestData = 1;
            AClaim.ClaimID = TestData;
            Assert.AreEqual(AClaim.ClaimID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsClaim AClaim = new clsClaim();
            Boolean Found = false;
            Int32 ClaimID = 4;
            Found = AClaim.Find(ClaimID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestClaimIDNoFound()
        {
            clsClaim AClaim = new clsClaim();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ClaimID = 4;
            Found = AClaim.Find(ClaimID);
            if (AClaim.ClaimID != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffIDNoFound()
        {
            clsClaim AClaim = new clsClaim();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ClaimID = 4;
            Found = AClaim.Find(ClaimID);
            if (AClaim.StaffID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerIDNoFound()
        {
            clsClaim AClaim = new clsClaim();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ClaimID = 4;
            Found = AClaim.Find(ClaimID);
            if (AClaim.CustomerID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestClaimDateNoFound()
        {
            clsClaim AClaim = new clsClaim();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ClaimID = 4;
            Found = AClaim.Find(ClaimID);
            if (AClaim.ClaimDate != Convert.ToDateTime("01/01/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestClaimAmntNoFound()
        {
            clsClaim AClaim = new clsClaim();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ClaimID = 4;
            Found = AClaim.Find(ClaimID);
            if (AClaim.ClaimAmnt != 1.01M)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestClaimStatusNoFound()
        {
            clsClaim AClaim = new clsClaim();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ClaimID = 4;
            Found = AClaim.Find(ClaimID);
            if (!AClaim.ClaimStatus)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestClaimReasonNoFound()
        {
            clsClaim AClaim = new clsClaim();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ClaimID = 4;
            Found = AClaim.Find(ClaimID);
            if (AClaim.ClaimReason != "Medical")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }



    }
}
