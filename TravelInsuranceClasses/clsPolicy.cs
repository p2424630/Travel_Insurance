using System;

namespace TravelInsuranceClasses
{
    public class clsPolicy
    {
        public bool Accepted { get; set; }
        public DateTime StartDate { get; set; }
        public int PolicyID { get; set; }
        public int StaffID { get; set; }
        public int CustomerID { get; set; }
        public string PolicyDetails { get; set; }
        public decimal Price { get; set; }
    }
}