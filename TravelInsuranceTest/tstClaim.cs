using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelInsuranceClasses;

namespace TravelInsuranceTest
{
    [TestClass]
    public class tstClaim
    {
        string StaffID = "32";
        string CustomerID = "41";
        string ClaimDate = DateTime.Now.Date.ToString();
        string ClaimAmnt = "77017.16";
        string ClaimStatus = true.ToString();
        string ClaimReason = "Lorem";


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
            String TestData = "Lorem";
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
            Decimal TestData = 77017.16M;
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
            Int32 TestData = 41;
            AClaim.CustomerID = TestData;
            Assert.AreEqual(AClaim.CustomerID, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsClaim AClaim = new clsClaim();
            Int32 TestData = 32;
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
            Int32 ClaimID = 1;
            Found = AClaim.Find(ClaimID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestClaimIDNoFound()
        {
            clsClaim AClaim = new clsClaim();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ClaimID = 1;
            Found = AClaim.Find(ClaimID);
            if (AClaim.ClaimID != 1)
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
            Int32 ClaimID = 1;
            Found = AClaim.Find(ClaimID);
            if (AClaim.StaffID != 32)
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
            Int32 ClaimID = 1;
            Found = AClaim.Find(ClaimID);
            if (AClaim.CustomerID != 41)
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
            Int32 ClaimID = 1;
            Found = AClaim.Find(ClaimID);
            if (AClaim.ClaimDate != Convert.ToDateTime("17/04/2020"))
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
            Int32 ClaimID = 1;
            Found = AClaim.Find(ClaimID);
            if (AClaim.ClaimAmnt != 77017.16M)
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
            Int32 ClaimID = 1;
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
            if (AClaim.ClaimReason != "Lorem")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");

        }

        //StaffID Tests

        [TestMethod]
        public void StaffIDNull()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string StaffID = "";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffIDMinLessOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string StaffID = "0";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffIDMin()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string StaffID = "1";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMinPlusOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string StaffID = "2";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxLessOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string StaffID = "2147483646";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMax()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string StaffID = "2147483647";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMid()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string StaffID = "250";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxPlusOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string StaffID = "2147483648";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDNotNumber()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string StaffID = "a";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreNotEqual(Error, "");
        }


        //CustomerID Tests
        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string CustomerID = "0";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMin()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string CustomerID = "1";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string CustomerID = "2";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string CustomerID = "2147483646";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMax()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string CustomerID = "2147483647";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string CustomerID = "250";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string CustomerID = "2147483648";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDNotNumber()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string CustomerID = "a";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreNotEqual(Error, "");
        }


        //ClaimDate Tests
        [TestMethod]
        public void ClaimDateMinLessOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            DateTime ClaimDateTemp = DateTime.Now.Date.AddMonths(-2).AddSeconds(-1);
            string ClaimDate = ClaimDateTemp.ToString();
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ClaimDateMin()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            DateTime ClaimDateTemp = DateTime.Now.Date.AddMonths(-2);
            string ClaimDate = ClaimDateTemp.ToString();
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimDateMinPlusOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            DateTime ClaimDateTemp = DateTime.Now.Date.AddMonths(-2).AddSeconds(1);
            string ClaimDate = ClaimDateTemp.ToString();
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimDateMaxLessOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            DateTime ClaimDateTemp = DateTime.Now.Date.AddSeconds(-1);
            string ClaimDate = ClaimDateTemp.ToString();
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimDateMax()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            DateTime ClaimDateTemp = DateTime.Now.Date;
            string ClaimDate = ClaimDateTemp.ToString();
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimDateMaxPlusOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            DateTime ClaimDateTemp = DateTime.Now.Date.AddSeconds(1);
            string ClaimDate = ClaimDateTemp.ToString();
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClaimDateMid()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            DateTime ClaimDateTemp = DateTime.Now.Date.AddMonths(-1);
            string ClaimDate = ClaimDateTemp.ToString();
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimDateNotDate()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string CustomerID = "a";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreNotEqual(Error, "");
        }


        //ClaimAmnt Tests
        [TestMethod]
        public void ClaimAmntNull()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string ClaimAmnt = "";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ClaimAmntMinLessOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string ClaimAmnt = "-0.01";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ClaimAmntMin()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string ClaimAmnt = "0.00";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimAmntMinPlusOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string ClaimAmnt = "0.01";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimAmntMaxLessOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string ClaimAmnt = "999999.98";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimAmntMax()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string ClaimAmnt = "999999.99";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimAmntMaxPlusOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string ClaimAmnt = "1000000.00";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClaimAmntMid()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string ClaimAmnt = "74020.73";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimAmntNotDecimal()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string ClaimAmnt = "a";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreNotEqual(Error, "");
        }


        //ClaimReason Tests
        [TestMethod]
        public void ClaimReasonMinLessOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string ClaimReason = "";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ClaimReasonMin()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string ClaimReason = "a";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimReasonMinPlusOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string ClaimReason = "aa";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimReasonMaxLessOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string ClaimReason = new string('Z', 65534);
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimReasonMax()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string ClaimReason = new string('Z', 65535);
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimReasonMaxPlusOne()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string ClaimReason = new string('Z', 65536);
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClaimReasoMid()
        {
            clsClaim AClaim = new clsClaim();
            string Error = "";
            string ClaimReason = new string('f', 36552);
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);
            Assert.AreEqual(Error, "");
        }
    }
}
