﻿using System;

namespace TravelInsuranceClasses
{
    public class clsPolicy
    {
        //Policy Class private members variables
        private DateTime _mStartDate;

        private int _mPolicyID;
        private int _mStaffID;
        private int _mCustomerID;
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
            get => _mPolicyID;
            //allows data into the property
            set => _mPolicyID = value;
        }

        public int StaffID
        {
            //sends data out of property
            get => _mStaffID;
            //allows data into the property
            set => _mStaffID = value;
        }

        public int CustomerID
        {
            //sends data out of property
            get => _mCustomerID;
            //allows data into the property
            set => _mCustomerID = value;
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

        public bool Find(int PolicyID)
        {
            //create instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the PolicyID to search for
            DB.AddParameter("@PolicyID", PolicyID);
            //execute the stored procedure
            DB.Execute("sproc_tblPolicy_FilterByPolicyID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data fields
                _mAccepted = Convert.ToBoolean(DB.DataTable.Rows[0]["Accepted"]);
                _mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                _mPolicyID = Convert.ToInt32(DB.DataTable.Rows[0]["PolicyID"]);
                _mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
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
    }
}