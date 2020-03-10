using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelInsuranceClasses;
using System.Collections.Generic;

namespace TravelInsuranceTest
{
    [TestClass]
    public class tstPolicyCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class to test
            clsPolicyCollection AllPolicies = new clsPolicyCollection();
            //test to see if exists
            Assert.IsNotNull(AllPolicies);
        }

        [TestMethod]
        public void PolicyListOk()
        {
            //instance of class
            clsPolicyCollection AllPolicies = new clsPolicyCollection();
            //create test data to assign to property as list of objects
            List<clsPolicy> TestList = new List<clsPolicy>();
            //add item to list and create the item of the test data
            clsPolicy TestItem = new clsPolicy();
            //set properties of test item
            TestItem.Accepted = true;
            TestItem.CustomerID = 11;
            TestItem.PolicyDetails = "Lorem ipsum dolor sit amet,";
            TestItem.PolicyID = 2;
            TestItem.Price = 64.00M;
            TestItem.StaffID = 68;
            TestItem.StartDate = DateTime.Now.Date;
            //add the test item to list
            TestList.Add(TestItem);
            //assign the data to property
            AllPolicies.PolicyList = TestList;
            //test to see if the values are the same
            Assert.AreEqual(AllPolicies.PolicyList, TestList);
        }

        [TestMethod]
        public void CountPolicyOk()
        {
            //instance of class
            clsPolicyCollection AllPolicies = new clsPolicyCollection();
            //test data
            int SomeCount = 0;
            //assign the data to property
            AllPolicies.Count = SomeCount;
            Assert.AreEqual(AllPolicies.Count, SomeCount);
        }

        [TestMethod]
        public void ThisPolicyPropertyOk()
        {
            //instance of class
            clsPolicyCollection AllPolicies = new clsPolicyCollection();
            //test data
            clsPolicy TestPolicy = new clsPolicy();
            //set properties of test item
            TestPolicy.Accepted = true;
            TestPolicy.CustomerID = 11;
            TestPolicy.PolicyDetails = "Lorem ipsum dolor sit amet,";
            TestPolicy.PolicyID = 2;
            TestPolicy.Price = 64.00M;
            TestPolicy.StaffID = 68;
            TestPolicy.StartDate = DateTime.Now.Date;
            //assign data to property
            AllPolicies.ThisPolicy = TestPolicy;
            //check if same
            Assert.AreEqual(AllPolicies.ThisPolicy, TestPolicy);
        }
    }
}
