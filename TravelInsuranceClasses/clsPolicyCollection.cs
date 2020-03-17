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

            //execute stored procedure
            DB.Execute("sproc_tblPolicy_SelectAll");
            //get count of records
            RecordCount = DB.Count;
            //while loop aslong as there are records to process
            while(Index < RecordCount)
            {
                //create blank policy
                clsPolicy aPolicy = new clsPolicy();
                //read the fields from the current record
                aPolicy.Accepted = Convert.ToBoolean(DB.DataTable.Rows[Index]["Accepted"]);
                aPolicy.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                aPolicy.PolicyID = Convert.ToInt32(DB.DataTable.Rows[Index]["PolicyID"]);
                aPolicy.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                aPolicy.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                aPolicy.PolicyDetails = Convert.ToString(DB.DataTable.Rows[Index]["PolicyDetails"]);
                aPolicy.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);

                //add record to the private data member
                _mPolicyList.Add(aPolicy);
                //go to next record
                Index++;
            }
        }

        public List<clsPolicy> PolicyList
        {
            get => _mPolicyList;
            set => _mPolicyList = value;
        }

        public int Count
        {
            get => _mPolicyList.Count;
            set { }
        }
        public clsPolicy ThisPolicy { get; set; }
    }
}