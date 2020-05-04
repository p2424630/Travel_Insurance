using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelInsuranceClasses;

namespace TravelInsuranceTest
{
    [TestClass]
    public class TstPolicyCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class to test
            var allPolicies = new clsPolicyCollection();
            //test to see if exists
            Assert.IsNotNull(allPolicies);
        }

        [TestMethod]
        public void PolicyListOk()
        {
            //instance of class
            var allPolicies = new clsPolicyCollection();
            //create test data to assign to property as list of objects
            var testList = new List<clsPolicy>();
            //add item to list and create the item of the test data
            var testItem = new clsPolicy();
            //set properties of test item
            testItem.Accepted = true;
            testItem.CustomerId = 11;
            testItem.PolicyDetails = "Lorem ipsum dolor sit amet,";
            testItem.PolicyId = 2;
            testItem.Price = 64.00M;
            testItem.StaffId = 68;
            testItem.StartDate = DateTime.Now.Date;
            //add the test item to list
            testList.Add(testItem);
            //assign the data to property
            allPolicies.PolicyList = testList;
            //test to see if the values are the same
            Assert.AreEqual(allPolicies.PolicyList, testList);
        }

        [TestMethod]
        public void ThisPolicyPropertyOk()
        {
            //instance of class
            var allPolicies = new clsPolicyCollection();
            //test data
            var testPolicy = new clsPolicy();
            //set properties of test item
            testPolicy.Accepted = true;
            testPolicy.CustomerId = 11;
            testPolicy.PolicyDetails = "Lorem ipsum dolor sit amet,";
            testPolicy.PolicyId = 2;
            testPolicy.Price = 64.00M;
            testPolicy.StaffId = 68;
            testPolicy.StartDate = DateTime.Now.Date;
            //assign data to property
            allPolicies.ThisPolicy = testPolicy;
            //check if same
            Assert.AreEqual(allPolicies.ThisPolicy, testPolicy);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            //instance of class
            var allPolicies = new clsPolicyCollection();
            //create test data to assign to property as list of objects
            var testList = new List<clsPolicy>();
            //add item to list and create the item of the test data
            var testItem = new clsPolicy();
            //set properties of test item
            testItem.Accepted = true;
            testItem.CustomerId = 11;
            testItem.PolicyDetails = "Lorem ipsum dolor sit amet,";
            testItem.PolicyId = 2;
            testItem.Price = 64.00M;
            testItem.StaffId = 68;
            testItem.StartDate = DateTime.Now.Date;
            //add the test item to list
            testList.Add(testItem);
            //assign the data to property
            allPolicies.PolicyList = testList;
            //test to see if the values are the same
            Assert.AreEqual(allPolicies.Count, testList.Count);
        }

        //Add Method
        [TestMethod]
        public void AddMethodOk()
        {
            //instance of class
            var allPolicies = new clsPolicyCollection();
            //create an item of test data
            var testItem = new clsPolicy();
            //store the PK
            var primaryKey = 0;
            //set the properties
            testItem.Accepted = true;
            testItem.CustomerId = 111;
            testItem.PolicyDetails = "Lorem ipsum dolor sit amet,";
            testItem.PolicyId = 112;
            testItem.Price = 64.00M;
            testItem.StaffId = 68;
            testItem.StartDate = DateTime.Now.Date;
            //set the ThisPolicy to test data
            allPolicies.ThisPolicy = testItem;
            //add record
            primaryKey = allPolicies.Add();
            //set the PK of the test data
            testItem.PolicyId = primaryKey;
            //find the record
            allPolicies.ThisPolicy.Find(primaryKey);
            //test to see if the 2 values are the same
            Assert.AreEqual(allPolicies.ThisPolicy, testItem);
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            //instance of class
            var allPolicies = new clsPolicyCollection();
            //create an item of test data
            var testItem = new clsPolicy();
            //store the PK
            var primaryKey = 0;
            //set the properties
            testItem.Accepted = true;
            testItem.CustomerId = 111;
            testItem.PolicyDetails = "Lorem ipsum dolor sit amet,";
            testItem.PolicyId = 112;
            testItem.Price = 64.00M;
            testItem.StaffId = 68;
            testItem.StartDate = DateTime.Now.Date;
            //set the ThisPolicy to test data
            allPolicies.ThisPolicy = testItem;
            //add record
            primaryKey = allPolicies.Add();
            //set the PK of the test data
            testItem.PolicyId = primaryKey;
            //find the record
            allPolicies.ThisPolicy.Find(primaryKey);
            //delete the record
            allPolicies.Delete();
            var found = allPolicies.ThisPolicy.Find(primaryKey);
            //test to see that the record was not found
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            //instance of class
            var allPolicies = new clsPolicyCollection();
            //create an item of test data
            var testItem = new clsPolicy();
            //store the PK
            var primaryKey = 0;
            //set the properties
            testItem.Accepted = true;
            testItem.CustomerId = 111;
            testItem.PolicyDetails = "Lorem ipsum dolor sit amet,";
            testItem.PolicyId = 112;
            testItem.Price = 64.00M;
            testItem.StaffId = 68;
            testItem.StartDate = DateTime.Now.Date;
            //set the ThisPolicy to test data
            allPolicies.ThisPolicy = testItem;
            //add record
            primaryKey = allPolicies.Add();
            //set the PK of the test data
            testItem.PolicyId = primaryKey;
            //modify test data
            testItem.Accepted = false;
            testItem.CustomerId = 112;
            testItem.PolicyDetails = "Lorem ipsum";
            testItem.PolicyId = 110;
            testItem.Price = 65.00M;
            testItem.StaffId = 69;
            testItem.StartDate = DateTime.Now.Date;
            //set the record based on the new test data
            allPolicies.ThisPolicy = testItem;
            //update the record
            allPolicies.Update();
            //find the record
            allPolicies.ThisPolicy.Find(primaryKey);
            var found = allPolicies.ThisPolicy.Find(primaryKey);
            //test to see that the record was not found
            Assert.AreEqual(allPolicies.ThisPolicy, testItem);
        }
        [TestMethod]
        public void ReportByCustomerIdOk()
        {
            //instance of class
            var allPolicies = new clsPolicyCollection();
            //filtered data instance
            var filteredPolicies = new clsPolicyCollection();
            //apply blank string (all records)
            filteredPolicies.ReportByCustomerId("");
            //test if same
            Assert.AreEqual(allPolicies.Count, filteredPolicies.Count);
        }
        public void ReportByCustomerIdNoneFound()
        {
            //filtered data instance
            var filteredPolicies = new clsPolicyCollection();
            //apply blank string (all records)
            filteredPolicies.ReportByCustomerId("000");
            //test to see that there are no record
            Assert.AreEqual(0, filteredPolicies.Count);
        }
    }
}