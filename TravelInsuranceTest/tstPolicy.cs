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
        private readonly string StartDate = DateTime.Now.Date.ToString();

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

        //StaffId Validation
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

        [TestMethod]
        public void StaffIdNotInt()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string StaffId = "!3"; //this should be fail
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        //StartDate Validation
        [TestMethod]
        public void StartDateExtremeMin()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create variable to store the test date data and set it to today
            var testDate = DateTime.Now.Date;
            //change the date to -100 years
            testDate = testDate.AddYears(-100);
            //convert to string
            string StartDate = testDate.ToString();
            //invoke the method
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StartDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsPolicy aPolicy = new clsPolicy();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMin()
        {
            //create an instance of the class we want to create
            clsPolicy aPolicy = new clsPolicy();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StartDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPolicy aPolicy = new clsPolicy();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StartDateMax()
        {
            //create an instance of the class we want to create
            clsPolicy aPolicy = new clsPolicy();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddYears(2);
            //convert the date variable to a string variable
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StartDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsPolicy aPolicy = new clsPolicy();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(10);
            //convert the date variable to a string variable
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //CustomerId Validation
        [TestMethod]
        public void CustomerIdNoMinLessOne()
        {
            var aPolicy = new clsPolicy();
            const string CustomerId = "";
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void CustomerIdMin()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string CustomerId = "1"; //this should be ok
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void CustomerIdMinPlusOne()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string CustomerId = "11"; //this should be ok
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void CustomerIdMaxLessOne()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string CustomerId = "2147483646"; //this should be ok
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void CustomerIdMax()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string CustomerId = "2147483647"; //this should be ok
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void CustomerIdMid()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string CustomerId = "333"; //this should be ok
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void CustomerIdMaxPlusOne()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string CustomerId = "2147483648"; //this should be fail
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void CustomerIdNotInt()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string CustomerId = "!3"; //this should be fail
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        //Price Validation
        [TestMethod]
        public void PriceNoMinLessOne()
        {
            var aPolicy = new clsPolicy();
            const string Price = "";
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string Price = "0.01"; //this should be ok
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string Price = "1.01"; //this should be ok
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string Price = "999999.98"; //this should be ok
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string Price = "999999.99"; //this should be ok
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string Price = "333.33"; //this should be ok
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string Price = "1000000.00"; //this should be fail
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PriceNotInt()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string Price = "!a"; //this should be fail
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void PriceMoreThan2Decimals()
        {
            //create an instance of the class we want to create
            var aPolicy = new clsPolicy();
            //create some test data to pass to the method
            const string Price = "1.001"; //this should be fail
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        //PolicyDetails Validation
        [TestMethod]
        public void PolicyDetailsMax()
        {
            var aPolicy = new clsPolicy();
            string PolicyDetails = "";
            PolicyDetails = PolicyDetails.PadRight(65535, 'a');
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void PolicyDetailsMaxMinusOne()
        {
            var aPolicy = new clsPolicy();
            string PolicyDetails = "";
            PolicyDetails = PolicyDetails.PadRight(65534, 'a');
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void PolicyDetailsMaxPlusOne()
        {
            var aPolicy = new clsPolicy();
            string PolicyDetails = "";
            PolicyDetails = PolicyDetails.PadRight(65536, 'a');
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PolicyDetailsExtremeMax()
        {
            var aPolicy = new clsPolicy();
            string PolicyDetails = "";
            PolicyDetails = PolicyDetails.PadRight(1000000, 'a');
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void PolicyDetailsMin()
        {
            var aPolicy = new clsPolicy();
            const string PolicyDetails = "";
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void PolicyDetailsMinPlusOne()
        {
            var aPolicy = new clsPolicy();
            const string PolicyDetails = "a";
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void PolicyDetailsMid()
        {
            var aPolicy = new clsPolicy();
            string PolicyDetails = "";
            PolicyDetails = PolicyDetails.PadRight(5000, 'a');
            var error = aPolicy.Valid(StaffId, CustomerId, PolicyDetails, StartDate, Price);
            Assert.AreEqual(error, "");
        }
    }
}