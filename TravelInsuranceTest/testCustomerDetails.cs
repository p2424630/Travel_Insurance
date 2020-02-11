using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
