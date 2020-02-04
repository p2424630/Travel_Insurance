using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void PolicyBuyDatePropertyOK()
        {
            //Instantiate The class
            clsPolicy APolicy = new clsPolicy();
            //test data
            DateTime TestData = DateTime.Now.Date;
            //assign to the property
            APolicy.PolicyBuyDate = TestData;
            //test for equality
            Assert.AreEqual(APolicy.PolicyBuyDate, TestData);
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
        public void QuoteIDPropertyOK()
        {
            //Instantiate The class
            clsPolicy APolicy = new clsPolicy();
            //test data
            Int32 TestData = 1;
            //assign to the property
            APolicy.QuoteID = TestData;
            //test for equality
            Assert.AreEqual(APolicy.QuoteID, TestData);
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

    }
}
