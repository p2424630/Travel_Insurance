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
            var AllClaims = new clsClaimCollection();
            Assert.IsNotNull(AllClaims);
        }

        [TestMethod]
        public void ClaimListOK()
        {
            var AllClaims = new clsClaimCollection();
            var TestList = new List<clsClaim>();
            var TestItem = new clsClaim();
            TestItem.ClaimStatus = true;
            TestItem.ClaimAmnt = 295255.18M;
            TestItem.ClaimDate = DateTime.Now.Date;
            TestItem.ClaimID = 1;
            TestItem.ClaimReason = "sem";
            TestItem.CustomerID = 8194;
            TestItem.StaffID = 32;
            TestList.Add(TestItem);
            AllClaims.ClaimList = TestList;
            Assert.AreEqual(AllClaims.ClaimList, TestList);
        }

        [TestMethod]
        public void ThisClaimPropertyOK()
        {
            var AllClaims = new clsClaimCollection();
            var TestClaim = new clsClaim();
            TestClaim.ClaimAmnt = 295255.18M;
            TestClaim.ClaimDate = DateTime.Now.Date;
            TestClaim.ClaimID = 1;
            TestClaim.ClaimReason = "sem";
            TestClaim.CustomerID = 8194;
            TestClaim.StaffID = 32;
            AllClaims.ThisClaim = TestClaim;
            Assert.AreEqual(AllClaims.ThisClaim, TestClaim);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            var AllClaims = new clsClaimCollection();
            var TestList = new List<clsClaim>();
            var TestItem = new clsClaim();
            TestItem.ClaimStatus = true;
            TestItem.ClaimAmnt = 295255.18M;
            TestItem.ClaimDate = DateTime.Now.Date;
            TestItem.ClaimID = 1;
            TestItem.ClaimReason = "sem";
            TestItem.CustomerID = 8194;
            TestItem.StaffID = 16;
            TestList.Add(TestItem);
            AllClaims.ClaimList = TestList;
            Assert.AreEqual(AllClaims.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            var AllClaims = new clsClaimCollection();
            var TestItem = new clsClaim();
            var PrimaryKey = 0;
            TestItem.ClaimStatus = true;
            TestItem.ClaimAmnt = 295255.18M;
            TestItem.ClaimDate = DateTime.Now.Date;
            TestItem.ClaimID = 1;
            TestItem.ClaimReason = "sem";
            TestItem.CustomerID = 8194;
            TestItem.StaffID = 16;
            AllClaims.ThisClaim = TestItem;
            PrimaryKey = AllClaims.Add();
            TestItem.ClaimID = PrimaryKey;
            AllClaims.ThisClaim.Find(PrimaryKey);
            Assert.AreEqual(AllClaims.ThisClaim, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            var AllClaims = new clsClaimCollection();
            var TestItem = new clsClaim();
            var PrimaryKey = 0;
            TestItem.ClaimStatus = true;
            TestItem.ClaimAmnt = 295255.18M;
            TestItem.ClaimDate = DateTime.Now.Date;
            TestItem.ClaimID = 1;
            TestItem.ClaimReason = "sem";
            TestItem.CustomerID = 8194;
            TestItem.StaffID = 16;
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
            var AllClaims = new clsClaimCollection();
            var TestItem = new clsClaim();
            var PrimaryKey = 0;
            TestItem.ClaimStatus = true;
            TestItem.ClaimAmnt = 295255.18M;
            TestItem.ClaimDate = DateTime.Now.Date;
            TestItem.ClaimID = 1;
            TestItem.ClaimReason = "sem";
            TestItem.CustomerID = 8194;
            TestItem.StaffID = 16;
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
            var AllClaims = new clsClaimCollection();
            var FilteredClaims = new clsClaimCollection();
            FilteredClaims.ReportByClaimReason("");
            Assert.AreEqual(AllClaims.Count, FilteredClaims.Count);
        }

        [TestMethod]
        public void ReportByClaimReasonNoneFound()
        {
            var FilteredClaims = new clsClaimCollection();
            FilteredClaims.ReportByClaimReason("xxxxxxxxx");
            Assert.AreEqual(0, FilteredClaims.Count);
        }

        [TestMethod]
        public void ReportByClaimReasonDataFound()
        {
            var FilteredClaims = new clsClaimCollection();
            var OK = true;
            FilteredClaims.ReportByClaimReason("sem. Pellentesque ut ipsum");
            if (FilteredClaims.Count == 2)
            {
                if (FilteredClaims.ClaimList[0].ClaimID != 2) OK = false;
                if (FilteredClaims.ClaimList[1].ClaimID != 11) OK = false;
            }
            else
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}