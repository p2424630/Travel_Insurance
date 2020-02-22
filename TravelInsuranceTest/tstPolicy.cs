using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TravelInsuranceClasses;

namespace TravelInsuranceTest
{
    [TestClass]
    public class TstPolicy
    {
        //Test Data
        private readonly string CustomerId = "42";
        private readonly string PolicyDetails = "Lorem ipsum dolor";
        private readonly string Price = "71.36";
        private readonly string StaffId = "3";
        private readonly string StartDate = "14/11/2020";

        [TestMethod]
        public void InstanceOk()
        {
            //Instantiate The class
            var aPolicy = new clsPolicy();
            //test if exists
            Assert.IsNotNull(aPolicy);
        }

        [TestMethod]
        public void AcceptedPropertyOk()
        {
            //Instantiate The class
            var aPolicy = new clsPolicy();
            //test data
            const bool testData = true;
            //assign the data to property
            aPolicy.Accepted = testData;
            //test equality
            Assert.AreEqual(aPolicy.Accepted, testData);
        }

        [TestMethod]
        public void StartDatePropertyOk()
        {
            //Instantiate The class
            var aPolicy = new clsPolicy();
            //test data
            var testData = DateTime.Now.Date;
            //assign to the property
            aPolicy.StartDate = testData;
            //test for equality
            Assert.AreEqual(aPolicy.StartDate, testData);
        }

        [TestMethod]
        public void PolicyIdPropertyOk()
        {
            //Instantiate The class
            var aPolicy = new clsPolicy();
            //test data
            const int testData = 1;
            //assign to the property
            aPolicy.PolicyID = testData;
            //test for equality
            Assert.AreEqual(aPolicy.PolicyID, testData);
        }

        [TestMethod]
        public void StaffIdPropertyOk()
        {
            //Instantiate The class
            var aPolicy = new clsPolicy();
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
            var aPolicy = new clsPolicy();
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
            var aPolicy = new clsPolicy();
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
            var aPolicy = new clsPolicy();
            //test data
            const decimal testData = 1.11M;
            //assign to the property
            aPolicy.Price = testData;
            //test for equality
            Assert.AreEqual(aPolicy.Price, testData);
        }

        //Find Method Section

        [TestMethod]
        public void FindMethodOK()
        {
            //Instantiate The class
            var aPolicy = new clsPolicy();
            //test data
            const int PolicyID = 7;
            //boolean var to store the result of the validation
            //invoke the method
            var Found = aPolicy.Find(PolicyID);
            //test for equality
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPolicyIDFound()
        {
            //Instantiate The class
            var aPolicy = new clsPolicy();
            //boolean var to record if data is OK (assume it is)
            var OK = true;
            //test data
            const int PolicyID = 7;
            //boolean car to store the result of search
            //invoke method
            _ = aPolicy.Find(PolicyID);
            //check the policy id
            if (aPolicy.PolicyID != 7) OK = false;

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStartDateFound()
        {
            //Instantiate The class
            var aPolicy = new clsPolicy();
            //boolean var to record if data is OK (assume it is)
            var OK = true;
            //test data
            const int PolicyID = 7;
            //boolean car to store the result of search
            //invoke method
            _ = aPolicy.Find(PolicyID);
            //check the policy id
            if (aPolicy.StartDate != Convert.ToDateTime("11/01/2021")) OK = false;

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //Instantiate The class
            var aPolicy = new clsPolicy();
            //boolean var to record if data is OK (assume it is)
            var OK = true;
            //test data
            const int PolicyID = 7;
            //boolean car to store the result of search
            //invoke method
            _ = aPolicy.Find(PolicyID);
            //check the policy id
            if (aPolicy.StaffID != 24) OK = false;

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //Instantiate The class
            var aPolicy = new clsPolicy();
            //boolean var to record if data is OK (assume it is)
            var OK = true;
            //test data
            const int PolicyID = 7;
            //boolean car to store the result of search
            //invoke method
            _ = aPolicy.Find(PolicyID);
            //check the policy id
            if (aPolicy.CustomerID != 59) OK = false;

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAcceptedFound()
        {
            //Instantiate The class
            var aPolicy = new clsPolicy();
            //boolean var to record if data is OK (assume it is)
            var OK = true;
            //test data
            const int PolicyID = 7;
            //boolean car to store the result of search
            //invoke method
            _ = aPolicy.Find(PolicyID);
            //check the policy id
            if (!aPolicy.Accepted) OK = false;

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPolicyDetailsFound()
        {
            //Instantiate The class
            var aPolicy = new clsPolicy();
            //boolean var to record if data is OK (assume it is)
            var OK = true;
            //test data
            const int PolicyID = 7;
            //boolean car to store the result of search
            //invoke method
            _ = aPolicy.Find(PolicyID);
            //check the policy id
            if (aPolicy.PolicyDetails != "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.") OK = false;

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //Instantiate The class
            var aPolicy = new clsPolicy();
            //boolean var to record if data is OK (assume it is)
            var OK = true;
            //test data
            const int policyId = 7;
            //boolean car to store the result of search
            //invoke method
            _ = aPolicy.Find(policyId);
            //check the policy id
            if (aPolicy.Price != 99.64M) OK = false;

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        //Validation Section

        [TestMethod]
        public void ValidMethodOk()
        {
            var aPolicy = new clsPolicy();
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffIdNoMinLessOne()
        {
            var aPolicy = new clsPolicy();
            const string StaffId = "";
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffIdMin()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string StaffId = "1"; //this should be ok
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffIdMinPlusOne()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string StaffId = "11"; //this should be ok
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffIdMaxLessOne()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string StaffId = "2147483646"; //this should be ok
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffIdMax()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string StaffId = "2147483647"; //this should be ok
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffIdMid()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string StaffId = "333"; //this should be ok
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffIdMaxPlusOne()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string StaffId = "2147483648"; //this should be fail
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
    }
}