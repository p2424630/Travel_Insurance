using System.Collections.Generic;

namespace TravelInsuranceClasses
{
    public class clsPolicyCollection
    {
        public List<clsPolicy> PolicyList { get; set; }
        public int Count { get; set; }
        public clsPolicy ThisPolicy { get; set; }
    }
}