using System;
using System.Collections.Generic;

namespace TravelInsuranceClasses
{
    public class clsPolicyCollection
    {
        //private data member for the list
        List<clsPolicy> _mPolicyList = new List<clsPolicy>();

        public clsPolicyCollection()
        {
            //index 
            int Index = 0;
            //var to store record count
            int RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();

        }

        public List<clsPolicy> PolicyList {
            get => _mPolicyList;
            set => _mPolicyList = value;
        }

        public int Count {
            get => _mPolicyList.Count;
            set { }
        }
        public clsPolicy ThisPolicy { get; set; }
    }
}