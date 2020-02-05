using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelInsuranceClasses;

namespace TravelInsuranceTest
{
    [TestClass]
    public class tstReview
    {
        [TestMethod]
        public void InstanceOk()
        {
        clsReview aReview = new clsReview();
        Assert.IsNotNull(aReview);
        }
    }
}
