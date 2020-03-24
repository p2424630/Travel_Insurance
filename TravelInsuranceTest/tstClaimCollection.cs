using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelInsuranceClasses;

namespace TravelInsuranceTest
{

    [TestClass]
    public class tstClaimCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsClaimCollection AllClaims = new clsClaimCollection();
            Assert.IsNotNull(AllClaims);
        }

        [TestMethod]
        public void ClaimListOK()
        {
            clsClaimCollection AllClaims = new clsClaimCollection();
            List<clsClaim> TestList = new List<clsClaim>();
            clsClaim TestItem = new clsClaim();
            TestItem.ClaimStatus = true;
            TestItem.ClaimAmnt = 77017.16M;
            TestItem.ClaimDate = DateTime.Now.Date;
            TestItem.ClaimID = 1;
            TestItem.ClaimReason = "Lorem";
            TestItem.CustomerID = 41;
            TestItem.StaffID = 32;
            TestList.Add(TestItem);
            AllClaims.ClaimList = TestList;
            Assert.AreEqual(AllClaims.ClaimList, TestList);
        }

        [TestMethod]
        public void ThisClaimPropertyOK()
        {
            clsClaimCollection AllClaims = new clsClaimCollection();
            clsClaim TestClaim = new clsClaim();
            TestClaim.ClaimAmnt = 77017.16M;
            TestClaim.ClaimDate = DateTime.Now.Date;
            TestClaim.ClaimID = 1;
            TestClaim.ClaimReason = "Lorem";
            TestClaim.CustomerID = 41;
            TestClaim.StaffID = 32;
            AllClaims.ThisClaim = TestClaim;
            Assert.AreEqual(AllClaims.ThisClaim, TestClaim);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsClaimCollection AllClaims = new clsClaimCollection();
            List<clsClaim> TestList = new List<clsClaim>();
            clsClaim TestItem = new clsClaim();
            TestItem.ClaimStatus = true;
            TestItem.ClaimAmnt = 77017.16M;
            TestItem.ClaimDate = DateTime.Now.Date;
            TestItem.ClaimID = 1;
            TestItem.ClaimReason = "Lorem";
            TestItem.CustomerID = 41;
            TestItem.StaffID = 32;
            TestList.Add(TestItem);
            AllClaims.ClaimList = TestList;
            Assert.AreEqual(AllClaims.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsClaimCollection AllClaims = new clsClaimCollection();
            clsClaim TestItem = new clsClaim();
            var PrimaryKey = 0;
            TestItem.ClaimStatus = true;
            TestItem.ClaimAmnt = 77017.16M;
            TestItem.ClaimDate = DateTime.Now.Date;
            TestItem.ClaimID = 1;
            TestItem.ClaimReason = "Lorem";
            TestItem.CustomerID = 41;
            TestItem.StaffID = 32;
            AllClaims.ThisClaim = TestItem;
            PrimaryKey = AllClaims.Add();
            TestItem.ClaimID = PrimaryKey;
            AllClaims.ThisClaim.Find(PrimaryKey);
            Assert.AreEqual(AllClaims.ThisClaim, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsClaimCollection AllClaims = new clsClaimCollection();
            clsClaim TestItem = new clsClaim();
            var PrimaryKey = 0;
            TestItem.ClaimStatus = true;
            TestItem.ClaimAmnt = 77017.16M;
            TestItem.ClaimDate = DateTime.Now.Date;
            TestItem.ClaimID = 1;
            TestItem.ClaimReason = "Lorem";
            TestItem.CustomerID = 41;
            TestItem.StaffID = 32;
            AllClaims.ThisClaim = TestItem;
            PrimaryKey = AllClaims.Add();
            TestItem.ClaimID = PrimaryKey;
            AllClaims.ThisClaim.Find(PrimaryKey);
            AllClaims.Delete();
            var found = AllClaims.ThisClaim.Find(PrimaryKey);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsClaimCollection AllClaims = new clsClaimCollection();
            clsClaim TestItem = new clsClaim();
            var PrimaryKey = 0;
            TestItem.ClaimStatus = true;
            TestItem.ClaimAmnt = 77017.16M;
            TestItem.ClaimDate = DateTime.Now.Date;
            TestItem.ClaimID = 1;
            TestItem.ClaimReason = "Lorem";
            TestItem.CustomerID = 41;
            TestItem.StaffID = 32;
            AllClaims.ThisClaim = TestItem;
            PrimaryKey = AllClaims.Add();
            TestItem.ClaimID = PrimaryKey;
            TestItem.ClaimStatus = false;
            TestItem.ClaimAmnt = 125.12M;
            TestItem.ClaimDate = DateTime.Now.Date;
            TestItem.ClaimID = 95;
            TestItem.ClaimReason = "Lorem Ipsum";
            TestItem.CustomerID = 34;
            TestItem.StaffID = 81;
            AllClaims.ThisClaim = TestItem;
            AllClaims.Update();
            AllClaims.ThisClaim.Find(PrimaryKey);
            Assert.AreEqual(AllClaims.ThisClaim, TestItem);
        }

        [TestMethod]
        public void ReportByClaimReasonMethodOK()
        {
            clsClaimCollection AllClaims = new clsClaimCollection();
            clsClaimCollection FilteredClaims = new clsClaimCollection();
            FilteredClaims.ReportByClaimReason("");
            Assert.AreEqual(AllClaims.Count, FilteredClaims.Count);
        }

        [TestMethod]
        public void ReportByClaimReasonNoneFound()
        {
            clsClaimCollection FilteredClaims = new clsClaimCollection();
            FilteredClaims.ReportByClaimReason("xxxxxxxxx");
            Assert.AreEqual(0, FilteredClaims.Count);
        }

        [TestMethod]
        public void ReportByClaimReasonDataFound()
        {
            clsClaimCollection FilteredClaims = new clsClaimCollection();
            Boolean OK = true;
            FilteredClaims.ReportByClaimReason("Aenean eget metus. In");
            if (FilteredClaims.Count == 2)
            {
                if (FilteredClaims.ClaimList[0].ClaimID != 3) OK = false;
                if (FilteredClaims.ClaimList[1].ClaimID != 36) OK = false;
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
