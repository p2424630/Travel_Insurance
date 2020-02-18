using System;
using System.Collections.Generic;

namespace TravelInsuranceClasses
{
    public class clsCustomerDetails
    {
        public int setCustomerID { get; set; }
        public string setCustomerName { get; set; }
        public DateTime setDoB { get; set; }
        public List<string> setAddress { get; set; }
        public string setEmail { get; set; }
        public bool setMarketingPreferences { get; set; }
        public string setContactNum { get; set; }
    }
}