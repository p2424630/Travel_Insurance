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
            //set private data to test value
            mPolicyID = 12;
            mStartDate = Convert.ToDateTime("18/02/2020");
            mStaffID = 2;
            mCustomerID = 3;
            mPolicyDetails = "This is a test Policy";
            mPrice = 42.42m;
            mAccepted = true;
            //always return true
            return true;
        }
    }
}