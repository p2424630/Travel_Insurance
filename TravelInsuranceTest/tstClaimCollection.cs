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

    }
}
