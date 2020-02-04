using System;

namespace TravelInsuranceClasses
{
    public class clsPolicy
    {
        public bool Accepted { get; set; }
        public DateTime PolicyBuyDate { get; set; }
        public int PolicyID { get; set; }
        public int QuoteID { get; set; }
        public int CustomerID { get; set; }
        public string PolicyDetails { get; set; }
    }
}