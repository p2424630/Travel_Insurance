using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelInsuranceClasses;

namespace TravelInsuranceTest
{
    [TestClass]
    public class testCustomerDetails
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsCustomerDetails customerdetails = new clsCustomerDetails();
            Assert.IsNotNull(customerdetails);

        }

        // Testing Methods...
        // CustomerID: 				Integer             :)
        // Name: 					String              :)
        // Date of Birth: 			Date                :)
        // Address: 				List<String>        :)
        // E-mail: 					String              :)
        //Contact Number: 			String              :)
        //Marketing Preferences:	Boolean             :)


        [TestMethod]
        public void CustomerIDisOk()
        {
            clsCustomerDetails customerdetails = new clsCustomerDetails();
            int TestData = 0;
            customerdetails.setCustomerID = TestData;
            Assert.AreEqual(customerdetails.setCustomerID, TestData);
        }

        [TestMethod]
        public void CustomerNameisOk()
        {
            clsCustomerDetails customerdetails = new clsCustomerDetails();
            String TestData = "John Doe";
            customerdetails.setCustomerName = TestData;
            Assert.AreEqual(customerdetails.setCustomerName, TestData);
        }


        [TestMethod]
        public void DoBisOk()
        {
            clsCustomerDetails customerdetails = new clsCustomerDetails();
            DateTime TestData = DateTime.Now.Date;
            customerdetails.setDoB = TestData;
            Assert.AreEqual(customerdetails.setDoB, TestData);
        }

        [TestMethod]
        public void AddressisOk()
        {
            clsCustomerDetails customerdetails = new clsCustomerDetails();
            List<String> TestData = new List<string>();
            TestData.Add("221b");
            TestData.Add("Baker Street");
            TestData.Add("London");
            TestData.Add("England");

            customerdetails.setAddress = TestData;
            Assert.AreEqual(customerdetails.setAddress, TestData);
        }

        [TestMethod]
        public void EmailOk()
        {
            clsCustomerDetails customerdetails = new clsCustomerDetails();
            String TestData = "john_smith@gmail.com";
            customerdetails.setEmail = TestData;
            Assert.AreEqual(customerdetails.setEmail, TestData);
        }

        [TestMethod]
        public void ContactNumOk()
        {
            clsCustomerDetails customerdetails = new clsCustomerDetails();
            String TestData = "0800 118 118";
            customerdetails.setContactNum = TestData;
            Assert.AreEqual(customerdetails.setContactNum, TestData);
        }


        [TestMethod]
        public void MarketingPreferncesOk()
        {
            clsCustomerDetails customerdetails = new clsCustomerDetails();
            Boolean TestData = true;
            customerdetails.setMarketingPreferences = TestData;
            Assert.AreEqual(customerdetails.setMarketingPreferences, TestData);
        }


    }
}
