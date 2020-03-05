using System;

namespace TravelInsuranceClasses
{
    public class clsClaim
    {
        private Int32 mClaimID;
        private Int32 mStaffID;
        private Int32 mCustomerID;
        private DateTime mClaimDate;
        private decimal mClaimAmnt;
        private bool mClaimStatus;
        private string mClaimReason;

        public Int32 ClaimID
        {
            get
            {
                return mClaimID;
            }
            set
            {
                mClaimID = value;
            }
        }

        public Int32 StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }

        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        public DateTime ClaimDate
        {
            get
            {
                return mClaimDate;
            }
            set
            {
                mClaimDate = value;
            }
        }

        public decimal ClaimAmnt
        {
            get
            {
                return mClaimAmnt;
            }
            set
            {
                mClaimAmnt = value;
            }
        }

        public bool ClaimStatus
        {
            get
            {
                return mClaimStatus;
            }
            set
            {
                mClaimStatus = value;
            }
        }

        public string ClaimReason
        {
            get
            {
                return mClaimReason;
            }
            set
            {
                mClaimReason = value;
            }
        }

        public bool Find(int ClaimID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ClaimID", ClaimID);
            DB.Execute("sproc_tblClaim_FilterByClaimID");
            if (DB.Count == 1)
            {
                mClaimID = Convert.ToInt32(DB.DataTable.Rows[0]["ClaimID"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mClaimDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ClaimDate"]);
                mClaimAmnt = Convert.ToDecimal(DB.DataTable.Rows[0]["ClaimAmnt"]);
                mClaimStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["ClaimStatus"]);
                mClaimReason = Convert.ToString(DB.DataTable.Rows[0]["ClaimReason"]);
                return true;
            }
            else
                return false;
        }

        public string Valid(string staffID,
                            string customerID,
                            string claimDate,
                            string claimAmnt,
                            string claimStatus,
                            string claimReason)
        {
            String Error = "";

            if (staffID.Length == 0)
            {
                Error += "The StaffID may not be blank : ";
            }
            return Error;
        }
            

    }
}