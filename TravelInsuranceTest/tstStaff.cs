using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelInsuranceClasses;

namespace TravelInsuranceTest
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }
        [TestMethod]
        public void NameOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "";
            AStaff.Name = TestData;
            Assert.AreEqual(AStaff.Name, TestData);
        }
        [TestMethod]
        public void AddressOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "";
            AStaff.Address = TestData;
            Assert.AreEqual(AStaff.Address, TestData);
        }
        [TestMethod]

        public void SalaryOK()
        {
            clsStaff AStaff = new clsStaff();
            Int32 TestData = 1;
            AStaff.Salary = TestData;
            Assert.AreEqual(AStaff.Salary, TestData);
        }
        [TestMethod]

        public void PhoneNoOK()
        {
            clsStaff AStaff = new clsStaff();
            Int32 TestData = 1;
            AStaff.PhoneNo = TestData;
            Assert.AreEqual(AStaff.PhoneNo, TestData);
        }
        [TestMethod]

        public void StartOK()
        {
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AStaff.Start = TestData;
            Assert.AreEqual(AStaff.Start, TestData);
        }
        [TestMethod]

        public void IsValidOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean TestData = true;
            AStaff.IsValid = TestData;
            Assert.AreEqual(AStaff.IsValid, TestData);
        }
    }
}
