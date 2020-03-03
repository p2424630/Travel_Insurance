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
    

        [TestMethod]
        public void ReviewIdOk()
        {
            clsReview aReview = new clsReview();
            int testData = 1;
            aReview.ReviewId = testData;
            Assert.AreEqual(aReview.ReviewId, testData);
  
        }

        [TestMethod]
        public void CustomerIdOk()
        {
            clsReview aReview = new clsReview();
            Int32 testData = 1;
            aReview.CustomerId = testData;
            Assert.AreEqual(aReview.CustomerId, testData);

        }

        [TestMethod]
        public void ReviewTextOk()
        {
            clsReview aReview = new clsReview();
            string testData = "test data";
            aReview.ReviewText = testData;
            Assert.AreEqual(aReview.ReviewText, testData);

        }

        [TestMethod]
        public void ReviewTitleOk()
        {
            clsReview aReview = new clsReview();
            string testData = "test data";
            aReview.reviewTitle = testData;
            Assert.AreEqual(aReview.reviewTitle, testData);

        }

        [TestMethod]
        public void DatePublishedOk()
        {
            clsReview aReview = new clsReview();
            DateTime testData = DateTime.Now.Date;
            aReview.datePublished = testData;
            AssertEquals(aReview.datePublished, testData);
        }

        private void AssertEquals(DateTime datePublished, DateTime testData)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void IsComplaintRecorded()
        {
            clsReview aReview = new clsReview();
            const bool testData = true;
            aReview.IsComplaintRecorded = testData;
            AssertEquals(aReview.IsComplaintRecorded, testData);
        }

        private void AssertEquals(bool isComplaintRecorded, bool testData)
        {
            throw new NotImplementedException();
        }
    }
}
