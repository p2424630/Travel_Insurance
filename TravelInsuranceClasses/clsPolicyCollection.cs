using System;
using System.Collections.Generic;

namespace TravelInsuranceClasses
{
    public class clsPolicyCollection
    {
        //private data member for the list
        private List<clsPolicy> _mPolicyList = new List<clsPolicy>();
        //private data member for ThisPolicy
        private clsPolicy _mThisPolicy = new clsPolicy();

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
                aPolicy.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                aPolicy.PolicyId = Convert.ToInt32(DB.DataTable.Rows[Index]["PolicyId"]);
                aPolicy.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
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

        public clsPolicy ThisPolicy
        {
            get => _mThisPolicy;
            set => _mThisPolicy = value;
        }

        public int Add()
        {
            //adds new record to DB based on the values of _mThisPolicy
            //connect to DB
            var DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffId", _mThisPolicy.StaffId);
            DB.AddParameter("@CustomerId", _mThisPolicy.CustomerId);
            DB.AddParameter("@StartDate", _mThisPolicy.StartDate);
            DB.AddParameter("@PolicyDetails", _mThisPolicy.PolicyDetails);
            DB.AddParameter("@Accepted", _mThisPolicy.Accepted);
            DB.AddParameter("@Price", _mThisPolicy.Price);

            //execute the query and return the PK value
            return DB.Execute("sproc_tblPolicy_Insert");
        }

        public void Delete()
        {
            //deletes a single record from DB pointed by thisPolicy
            var DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@PolicyId", _mThisPolicy.PolicyId);
            //execute the stored procedure
            DB.Execute("sproc_tblPolicy_Delete");
        }
        public void Update()
        {
            var DB = new clsDataConnection();
            DB.AddParameter("@PolicyId", _mThisPolicy.PolicyId);
            DB.AddParameter("@StaffId", _mThisPolicy.StaffId);
            DB.AddParameter("@CustomerId", _mThisPolicy.CustomerId);
            DB.AddParameter("@StartDate", _mThisPolicy.StartDate);
            DB.AddParameter("@PolicyDetails", _mThisPolicy.PolicyDetails);
            DB.AddParameter("@Accepted", _mThisPolicy.Accepted);
            DB.AddParameter("@Price", _mThisPolicy.Price);

            DB.Execute("sproc_tblPolicy_Update");
        }

        public void ReportByCustomerId(string customerId)
        {
            int CustomerId;
            var DB = new clsDataConnection();
            CustomerId = Convert.ToInt32(customerId);
            DB.AddParameter("@CustomerId", CustomerId);
            DB.Execute("sproc_tblPolicy_FilterByCustomerId");
            PopulateArray(DB);
        }

        public void PopulateArray(clsDataConnection DB)
        {
            var Index = 0;
            var RecordCount = DB.Count;
            _mPolicyList = new List<clsPolicy>();
            while (Index < RecordCount)
            {
                //create blank policy
                clsPolicy aPolicy = new clsPolicy();
                //read the fields from the current record
                aPolicy.Accepted = Convert.ToBoolean(DB.DataTable.Rows[Index]["Accepted"]);
                aPolicy.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                aPolicy.PolicyId = Convert.ToInt32(DB.DataTable.Rows[Index]["PolicyId"]);
                aPolicy.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                aPolicy.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                aPolicy.PolicyDetails = Convert.ToString(DB.DataTable.Rows[Index]["PolicyDetails"]);
                aPolicy.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);

                //add record to the private data member
                _mPolicyList.Add(aPolicy);
                //go to next record
                Index++;
            }
        }
    }
}