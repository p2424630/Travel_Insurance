﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelInsuranceClasses;

namespace TravelInsuranceTest
{
    [TestClass]
    public class tstClaim
    {
        private readonly string ClaimAmnt = "295255.18";
        private readonly string ClaimDate = DateTime.Now.Date.ToString();
        private readonly string ClaimReason = "sem";
        private string ClaimStatus = true.ToString();
        private readonly string CustomerID = "8194";
        private readonly string StaffID = "16";


        [TestMethod]
        public void InstanceOK()
        {
            var AClaim = new clsClaim();
            Assert.IsNotNull(AClaim);
        }

        [TestMethod]
        public void ClaimReasonPropertyOK()
        {
            var AClaim = new clsClaim();
            var TestData = "sem";
            AClaim.ClaimReason = TestData;
            Assert.AreEqual(AClaim.ClaimReason, TestData);
        }

        [TestMethod]
        public void ClaimDatePropertyOK()
        {
            var AClaim = new clsClaim();
            var TestData = DateTime.Now.Date;
            AClaim.ClaimDate = TestData;
            Assert.AreEqual(AClaim.ClaimDate, TestData);
        }

        [TestMethod]
        public void ClaimAmntPropertyOK()
        {
            var AClaim = new clsClaim();
            var TestData = 295255.18M;
            AClaim.ClaimAmnt = TestData;
            Assert.AreEqual(AClaim.ClaimAmnt, TestData);
        }

        [TestMethod]
        public void ClaimStatusPropertyOK()
        {
            var AClaim = new clsClaim();
            var TestData = true;
            AClaim.ClaimStatus = TestData;
            Assert.AreEqual(AClaim.ClaimStatus, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            var AClaim = new clsClaim();
            var TestData = 8194;
            AClaim.CustomerID = TestData;
            Assert.AreEqual(AClaim.CustomerID, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            var AClaim = new clsClaim();
            var TestData = 16;
            AClaim.StaffID = TestData;
            Assert.AreEqual(AClaim.StaffID, TestData);
        }

        [TestMethod]
        public void ClaimIDPropertyOK()
        {
            var AClaim = new clsClaim();
            var TestData = 1;
            AClaim.ClaimID = TestData;
            Assert.AreEqual(AClaim.ClaimID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            var AClaim = new clsClaim();
            var Found = false;
            var ClaimID = 1;
            Found = AClaim.Find(ClaimID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestClaimIDNoFound()
        {
            var AClaim = new clsClaim();
            var Found = false;
            var OK = true;
            var ClaimID = 1;
            Found = AClaim.Find(ClaimID);
            if (AClaim.ClaimID != 1) OK = false;
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIDNoFound()
        {
            var AClaim = new clsClaim();
            var Found = false;
            var OK = true;
            var ClaimID = 1;
            Found = AClaim.Find(ClaimID);
            if (AClaim.StaffID != 16) OK = false;
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDNoFound()
        {
            var AClaim = new clsClaim();
            var Found = false;
            var OK = true;
            var ClaimID = 1;
            Found = AClaim.Find(ClaimID);
            if (AClaim.CustomerID != 8194) OK = false;
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestClaimDateNoFound()
        {
            var AClaim = new clsClaim();
            var Found = false;
            var OK = true;
            var ClaimID = 1;
            Found = AClaim.Find(ClaimID);
            if (AClaim.ClaimDate != Convert.ToDateTime("13/03/2020")) OK = false;
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestClaimAmntNoFound()
        {
            var AClaim = new clsClaim();
            var Found = false;
            var OK = true;
            var ClaimID = 1;
            Found = AClaim.Find(ClaimID);
            if (AClaim.ClaimAmnt != 295255.18M) OK = false;
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestClaimStatusNoFound()
        {
            var AClaim = new clsClaim();
            var Found = false;
            var OK = true;
            var ClaimID = 1;
            Found = AClaim.Find(ClaimID);
            if (!AClaim.ClaimStatus) OK = false;
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestClaimReasonNoFound()
        {
            var AClaim = new clsClaim();
            var Found = false;
            var OK = true;
            var ClaimID = 1;
            Found = AClaim.Find(ClaimID);
            if (AClaim.ClaimReason != "sem") OK = false;
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            var AClaim = new clsClaim();
            var Error = "";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        //StaffID Tests
        [TestMethod]
        public void StaffIDMinLessOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var StaffID = "0";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMin()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var StaffID = "1";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMinPlusOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var StaffID = "2";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxLessOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var StaffID = "2147483646";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMax()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var StaffID = "2147483647";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMid()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var StaffID = "250";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxPlusOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var StaffID = "2147483648";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDNotNumber()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var StaffID = "a";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreNotEqual(Error, "");
        }


        //CustomerID Tests
        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var CustomerID = "0";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMin()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var CustomerID = "1";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var CustomerID = "2";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var CustomerID = "2147483646";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMax()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var CustomerID = "2147483647";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var CustomerID = "250";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var CustomerID = "2147483648";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDNotNumber()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var CustomerID = "a";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreNotEqual(Error, "");
        }


        //ClaimDate Tests
        [TestMethod]
        public void ClaimDateMinLessOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimDateTemp = DateTime.Now.Date.AddMonths(-2).AddSeconds(-1);
            var ClaimDate = ClaimDateTemp.ToString();
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClaimDateMin()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimDateTemp = DateTime.Now.Date.AddMonths(-2);
            var ClaimDate = ClaimDateTemp.ToString();
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimDateMinPlusOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimDateTemp = DateTime.Now.Date.AddMonths(-2).AddSeconds(1);
            var ClaimDate = ClaimDateTemp.ToString();
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimDateMaxLessOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimDateTemp = DateTime.Now.Date.AddSeconds(-1);
            var ClaimDate = ClaimDateTemp.ToString();
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimDateMax()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimDateTemp = DateTime.Now.Date;
            var ClaimDate = ClaimDateTemp.ToString();
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimDateMaxPlusOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimDateTemp = DateTime.Now.Date.AddSeconds(1);
            var ClaimDate = ClaimDateTemp.ToString();
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClaimDateMid()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimDateTemp = DateTime.Now.Date.AddMonths(-1);
            var ClaimDate = ClaimDateTemp.ToString();
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimDateNotDate()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var CustomerID = "a";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreNotEqual(Error, "");
        }


        //ClaimAmnt Tests
        [TestMethod]
        public void ClaimAmntMinLessOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimAmnt = "-0.01";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClaimAmntMin()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimAmnt = "0.00";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimAmntMinPlusOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimAmnt = "0.01";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimAmntMaxLessOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimAmnt = "999999.98";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimAmntMax()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimAmnt = "999999.99";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimAmntMaxPlusOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimAmnt = "1000000.00";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClaimAmntMid()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimAmnt = "74020.73";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimAmntNotDecimal()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimAmnt = "a";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreNotEqual(Error, "");
        }


        //ClaimReason Tests
        [TestMethod]
        public void ClaimReasonMinLessOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimReason = "";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClaimReasonMin()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimReason = "a";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimReasonMinPlusOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimReason = "aa";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimReasonMaxLessOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimReason = new string('Z', 65534);
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimReasonMax()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimReason = new string('Z', 65535);
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClaimReasonMaxPlusOne()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimReason = new string('Z', 65536);
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClaimReasonMid()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimReason = new string('f', 36552);
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreEqual(Error, "");
        }

        //ClaimStatus Test
        [TestMethod]
        public void ClaimStatusNotBoolean()
        {
            var AClaim = new clsClaim();
            var Error = "";
            var ClaimStatus = "1";
            Error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);
            Assert.AreNotEqual(Error, "");
        }
    }
}