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
            clsPolicy APolicy = new clsPolicy();
            //test if exists
            Assert.IsNotNull(APolicy);
        }

        [TestMethod]
        public void AcceptedPropertyOK()
        {
            //Instantiate The class
            clsPolicy APolicy = new clsPolicy();
            //test data
            Boolean TestData = true;
            //assign the data to propery
            APolicy.Accepted = TestData;
            //test equality
            Assert.AreEqual(APolicy.Accepted, TestData);

        }

        [TestMethod]
        public void StartDatePropertyOK()
        {
            //Instantiate The class
            clsPolicy APolicy = new clsPolicy();
            //test data
            DateTime TestData = DateTime.Now.Date;
            //assign to the property
            APolicy.StartDate = TestData;
            //test for equality
            Assert.AreEqual(APolicy.StartDate, TestData);
        }
        [TestMethod]
        public void PolicyIDPropertyOK()
        {
            //Instantiate The class
            clsPolicy APolicy = new clsPolicy();
            //test data
            Int32 TestData = 1;
            //assign to the property
            APolicy.PolicyID = TestData;
            //test for equality
            Assert.AreEqual(APolicy.PolicyID, TestData);
        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //Instantiate The class
            clsPolicy APolicy = new clsPolicy();
            //test data
            Int32 TestData = 1;
            //assign to the property
            APolicy.StaffID = TestData;
            //test for equality
            Assert.AreEqual(APolicy.StaffID, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //Instantiate The class
            clsPolicy APolicy = new clsPolicy();
            //test data
            Int32 TestData = 1;
            //assign to the property
            APolicy.CustomerID = TestData;
            //test for equality
            Assert.AreEqual(APolicy.CustomerID, TestData);
        }

        [TestMethod]
        public void PolicyDetailsPropertyOK()
        {
            //Instantiate The class
            clsPolicy APolicy = new clsPolicy();
            //test data
            string TestData = "Some details";
            //assign to the property
            APolicy.PolicyDetails = TestData;
            //test for equality
            Assert.AreEqual(APolicy.PolicyDetails, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            //Instantiate The class
            clsPolicy APolicy = new clsPolicy();
            //test data
            decimal TestData = 1.11M;
            //assign to the property
            APolicy.Price = TestData;
            //test for equality
            Assert.AreEqual(APolicy.Price, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //Instantiate The class
            clsPolicy APolicy = new clsPolicy();
            //boolean var to store the result of the validation
            Boolean Found = false;
            //test data
            Int32 PolicyID = 7;
            //invoke the method
            Found = APolicy.Find(PolicyID);
            //test for equality
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestPolicyIDFound()
        {
            //Instantiate The class
            clsPolicy APolicy = new clsPolicy();
            //boolean car to store the result of search
            Boolean Found = false;
            //boolean var to record if data is OK (assume itis)
            Boolean OK = true;
            //test data
            Int32 PolicyID = 7;
            //invoke method
            Found = APolicy.Find(PolicyID);
            //check the policy id
            if (APolicy.PolicyID != 7)
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
            clsPolicy APolicy = new clsPolicy();
            //boolean car to store the result of search
            Boolean Found = false;
            //boolean var to record if data is OK (assume itis)
            Boolean OK = true;
            //test data
            Int32 PolicyID = 7;
            //invoke method
            Found = APolicy.Find(PolicyID);
            //check the policy id
            if (APolicy.StartDate != Convert.ToDateTime("18/02/2020"))
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
            clsPolicy APolicy = new clsPolicy();
            //boolean car to store the result of search
            Boolean Found = false;
            //boolean var to record if data is OK (assume itis)
            Boolean OK = true;
            //test data
            Int32 PolicyID = 7;
            //invoke method
            Found = APolicy.Find(PolicyID);
            //check the policy id
            if (APolicy.StaffID != 2)
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
            clsPolicy APolicy = new clsPolicy();
            //boolean car to store the result of search
            Boolean Found = false;
            //boolean var to record if data is OK (assume itis)
            Boolean OK = true;
            //test data
            Int32 PolicyID = 7;
            //invoke method
            Found = APolicy.Find(PolicyID);
            //check the policy id
            if (APolicy.CustomerID != 3)
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
            clsPolicy APolicy = new clsPolicy();
            //boolean car to store the result of search
            Boolean Found = false;
            //boolean var to record if data is OK (assume itis)
            Boolean OK = true;
            //test data
            Int32 PolicyID = 7;
            //invoke method
            Found = APolicy.Find(PolicyID);
            //check the policy id
            if (!APolicy.Accepted)
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
            clsPolicy APolicy = new clsPolicy();
            //boolean car to store the result of search
            Boolean Found = false;
            //boolean var to record if data is OK (assume itis)
            Boolean OK = true;
            //test data
            Int32 PolicyID = 7;
            //invoke method
            Found = APolicy.Find(PolicyID);
            //check the policy id
            if (APolicy.PolicyDetails != "This is a test Policy")
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
            clsPolicy APolicy = new clsPolicy();
            //boolean car to store the result of search
            Boolean Found = false;
            //boolean var to record if data is OK (assume itis)
            Boolean OK = true;
            //test data
            Int32 PolicyID = 7;
            //invoke method
            Found = APolicy.Find(PolicyID);
            //check the policy id
            if (APolicy.Price != 42.42M)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
    }
}
