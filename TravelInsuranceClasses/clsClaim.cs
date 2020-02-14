using System;

namespace TravelInsuranceClasses
{
    public class clsClaim
    {
        public DateTime ClaimDate { get; set; }
        public decimal ClaimAmnt { get; set; }
        public bool ClaimStatus { get; set; }
        public int StaffID { get; set; }
        public int CustomerID { get; set; }
        public int ClaimID { get; set; }
        public string ClaimReason { get; set; }
    }
}