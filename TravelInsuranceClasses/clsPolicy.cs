using System;

namespace TravelInsuranceClasses
{
    public class clsPolicy
    {
        //Policy Class private members variables
        private int mPolicyID;
        private DateTime mStartDate;
        private int mStaffID;
        private int mCustomerID;
        private string mPolicyDetails;
        private decimal mPrice;
        private bool mAccepted;

        public bool Accepted
        {
            get
            {
                //sends data out of preporty
                return mAccepted;
            }
            set
            {
                //allows data into the property
                mAccepted = value;
            }
        }
        public DateTime StartDate
        {
            get
            {
                //sends data out of preporty
                return mStartDate;
            }
            set
            {
                //allows data into the property
                mStartDate = value;
            }
        }
        //PolicyID public property
        public int PolicyID
        {
            get
            {
                //sends data out of preporty
                return mPolicyID;
            }
            set
            {
                //allows data into the property
                mPolicyID = value;
            }
        }
        public int StaffID
        {
            get
            {
                //sends data out of preporty
                return mStaffID;
            }
            set
            {
                //allows data into the property
                mStaffID = value;
            }
        }
        public int CustomerID
        {
            get
            {
                //sends data out of preporty
                return mCustomerID;
            }
            set
            {
                //allows data into the property
                mCustomerID = value;
            }
        }
        public string PolicyDetails
        {
            get
            {
                //sends data out of preporty
                return mPolicyDetails;
            }
            set
            {
                //allows data into the property
                mPolicyDetails = value;
            }
        }
        public decimal Price
        {
            get
            {
                //sends data out of preporty
                return mPrice;
            }
            set
            {
                //allows data into the property
                mPrice = value;
            }
        }

        public bool Find(int PolicyID)
        {
            //create instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the PolicyID to search for
            DB.AddParameter("@PolicyID", PolicyID);
            //execute the stored procedure
            DB.Execute("sproc_tblPolicy_FilterByPolicyID");
            //if one record is found (there should be either one or zero!)
            if(DB.Count == 1)
            {
                //copy the data fro mthe database to the private data fields
                mAccepted = Convert.ToBoolean(DB.DataTable.Rows[0]["Accepted"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mPolicyID = Convert.ToInt32(DB.DataTable.Rows[0]["PolicyID"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                mPolicyDetails = Convert.ToString(DB.DataTable.Rows[0]["PolicyDetails"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                //return that everything is OK
                return true;
            }
            else
            {
                //problem
                return false;
            }
        }
    }
}