using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            clsPolicy aPolicy = new clsPolicy();
            //test if exists
            Assert.IsNotNull(aPolicy);
        }

        [TestMethod]
        public void AcceptedPropertyOK()
        {
            //Instantiate The class
            clsPolicy aPolicy = new clsPolicy();
            //test data
            const bool testData = true;
            //assign the data to propery
            aPolicy.Accepted = testData;
            //test equality
            Assert.AreEqual(aPolicy.Accepted, testData);
        }

        [TestMethod]
        public void StartDatePropertyOK()
        {
            //Instantiate The class
            clsPolicy aPolicy = new clsPolicy();
            //test data
            DateTime testData = DateTime.Now.Date;
            //assign to the property
            aPolicy.StartDate = testData;
            //test for equality
            Assert.AreEqual(aPolicy.StartDate, testData);
        }

        [TestMethod]
        public void PolicyIDPropertyOK()
        {
            //Instantiate The class
            clsPolicy aPolicy = new clsPolicy();
            //test data
            const int testData = 1;
            //assign to the property
            aPolicy.PolicyID = testData;
            //test for equality
            Assert.AreEqual(aPolicy.PolicyID, testData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //Instantiate The class
            clsPolicy aPolicy = new clsPolicy();
            //test data
            const int testData = 1;
            //assign to the property
            aPolicy.StaffID = testData;
            //test for equality
            Assert.AreEqual(aPolicy.StaffID, testData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //Instantiate The class
            clsPolicy aPolicy = new clsPolicy();
            //test data
            const int testData = 1;
            //assign to the property
            aPolicy.CustomerID = testData;
            //test for equality
            Assert.AreEqual(aPolicy.CustomerID, testData);
        }

        [TestMethod]
        public void PolicyDetailsPropertyOK()
        {
            //Instantiate The class
            clsPolicy aPolicy = new clsPolicy();
            //test data
            const string testData = "Some details";
            //assign to the property
            aPolicy.PolicyDetails = testData;
            //test for equality
            Assert.AreEqual(aPolicy.PolicyDetails, testData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //Instantiate The class
            clsPolicy aPolicy = new clsPolicy();
            //test data
            const decimal testData = 1.11M;
            //assign to the property
            aPolicy.Price = testData;
            //test for equality
            Assert.AreEqual(aPolicy.Price, testData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Instantiate The class
            clsPolicy aPolicy = new clsPolicy();
            //boolean var to store the result of the validation
            bool Found = false;
            //test data
            const int PolicyID = 7;
            //invoke the method
            Found = aPolicy.Find(PolicyID);
            //test for equality
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPolicyIDFound()
        {
            //Instantiate The class
            clsPolicy aPolicy = new clsPolicy();
            //boolean car to store the result of search
            bool Found = false;
            //boolean var to record if data is OK (assume it is)
            bool OK = true;
            //test data
            const int PolicyID = 7;
            //invoke method
            Found = aPolicy.Find(PolicyID);
            //check the policy id
            if (aPolicy.PolicyID != 7)
            {
                OK = false;
            }

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStartDateFound()
        {
            //Instantiate The class
            clsPolicy aPolicy = new clsPolicy();
            //boolean car to store the result of search
            bool Found = false;
            //boolean var to record if data is OK (assume it is)
            bool OK = true;
            //test data
            const int PolicyID = 7;
            //invoke method
            Found = aPolicy.Find(PolicyID);
            //check the policy id
            if (aPolicy.StartDate != Convert.ToDateTime("11/01/2021"))
            {
                OK = false;
            }

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //Instantiate The class
            clsPolicy aPolicy = new clsPolicy();
            //boolean car to store the result of search
            bool Found = false;
            //boolean var to record if data is OK (assume it is)
            bool OK = true;
            //test data
            const int PolicyID = 7;
            //invoke method
            Found = aPolicy.Find(PolicyID);
            //check the policy id
            if (aPolicy.StaffID != 24)
            {
                OK = false;
            }

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //Instantiate The class
            clsPolicy aPolicy = new clsPolicy();
            //boolean car to store the result of search
            bool Found = false;
            //boolean var to record if data is OK (assume it is)
            bool OK = true;
            //test data
            const int PolicyID = 7;
            //invoke method
            Found = aPolicy.Find(PolicyID);
            //check the policy id
            if (aPolicy.CustomerID != 59)
            {
                OK = false;
            }

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAcceptedFound()
        {
            //Instantiate The class
            clsPolicy aPolicy = new clsPolicy();
            //boolean car to store the result of search
            bool Found = false;
            //boolean var to record if data is OK (assume it is)
            bool OK = true;
            //test data
            const int PolicyID = 7;
            //invoke method
            Found = aPolicy.Find(PolicyID);
            //check the policy id
            if (!aPolicy.Accepted)
            {
                OK = false;
            }

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPolicyDetailsFound()
        {
            //Instantiate The class
            clsPolicy aPolicy = new clsPolicy();
            //boolean car to store the result of search
            bool Found = false;
            //boolean var to record if data is OK (assume it is)
            bool OK = true;
            //test data
            const int PolicyID = 7;
            //invoke method
            Found = aPolicy.Find(PolicyID);
            //check the policy id
            if (aPolicy.PolicyDetails != "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.")
            {
                OK = false;
            }

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //Instantiate The class
            clsPolicy aPolicy = new clsPolicy();
            //boolean car to store the result of search
            bool Found = false;
            //boolean var to record if data is OK (assume it is)
            bool OK = true;
            //test data
            const int policyId = 7;
            //invoke method
            Found = aPolicy.Find(policyId);
            //check the policy id
            if (aPolicy.Price != 99.64M)
            {
                OK = false;
            }

            //test to see the result is correct
            Assert.IsTrue(OK);
        }
    }
}