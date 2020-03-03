using System;

namespace TravelInsuranceClasses
{
    public class clsReview
    {

        public int ReviewId { get; set; }
        public int CustomerId { get; set; }
        public string ReviewText { get; set; }
        public bool IsComplaintRecorded { get; set; }
        public string reviewTitle { get; set; }
        public DateTime datePublished { get; set; }
    }
}