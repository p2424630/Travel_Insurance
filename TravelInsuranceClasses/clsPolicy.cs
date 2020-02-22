using System;

namespace TravelInsuranceClasses
{
    public class clsPolicy
    {
        //Policy Class private members variables
        private DateTime _mStartDate;

        private int _mPolicyId;
        private int _mStaffId;
        private int _mCustomerId;
        private string _mPolicyDetails;
        private decimal _mPrice;
        private bool _mAccepted;

        public bool Accepted
        {
            //sends data out of property
            get => _mAccepted;

            //allows data into the property
            set => _mAccepted = value;
        }

        public DateTime StartDate
        {
            //sends data out of property
            get => _mStartDate;
            //allows data into the property
            set => _mStartDate = value;
        }

        //PolicyID public property
        public int PolicyID
        {
            //sends data out of property
            get => _mPolicyId;
            //allows data into the property
            set => _mPolicyId = value;
        }

        public int StaffID
        {
            //sends data out of property
            get => _mStaffId;
            //allows data into the property
            set => _mStaffId = value;
        }

        public int CustomerID
        {
            //sends data out of property
            get => _mCustomerId;
            //allows data into the property
            set => _mCustomerId = value;
        }

        public string PolicyDetails
        {
            //sends data out of property
            get => _mPolicyDetails;
            //allows data into the property
            set => _mPolicyDetails = value;
        }

        public decimal Price
        {
            //sends data out of property
            get => _mPrice;
            //allows data into the property
            set => _mPrice = value;
        }

        public bool Find(int PolicyId)
        {
            //create instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the PolicyID to search for
            DB.AddParameter("@PolicyId", PolicyId);
            //execute the stored procedure
            DB.Execute("sproc_tblPolicy_FilterByPolicyId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data fields
                _mAccepted = Convert.ToBoolean(DB.DataTable.Rows[0]["Accepted"]);
                _mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                _mPolicyId = Convert.ToInt32(DB.DataTable.Rows[0]["PolicyId"]);
                _mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                _mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                _mPolicyDetails = Convert.ToString(DB.DataTable.Rows[0]["PolicyDetails"]);
                _mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                //return that everything is OK
                return true;
            }
            else
            {
                //problem
                return false;
            }
        }
        public string Valid(string staffId, string customerId, string policyDetails, string startDate, string price)
        {
            string error = "";

            if (!int.TryParse(staffId, out _))
            {
                error += "The StaffId was not a valid integer value : ";
            }
            else if (staffId.Length == 0)
            {
                error += "The StaffId may not be blank : ";
            }

            return error;
        }
    }
}