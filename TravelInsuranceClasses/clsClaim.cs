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
            {
                return false;
            }
        }

        public string Valid(string staffID, string customerID, string claimDate, string claimAmnt, string claimStatus, string claimReason)
        {
            string Error = "";

            //StaffID


            //CustomerID
            try
            {
                int.Parse(customerID);
                if (customerID.Length == 0)
                {
                    Error += "The CustomerID may not be blank : ";
                }
            }
            catch (Exception e1)
            {
                Error += "The CustomerID wasn't in the correct format or exceded 2147483648 : " + e1.Message;
            }

            //ClaimDate
            try
            {
                if (claimDate.Length <= 0)
                {
                    Error += "The ClaimDate may not be Blank : ";
                }
                else
                {
                    DateTime dateTemp = Convert.ToDateTime(claimDate);

                    if (dateTemp > DateTime.Now.Date)
                    {
                        Error += "The ClaimDate may not be in the future : ";
                    }

                    else if (dateTemp < DateTime.Now.Date.AddMonths(-2))
                    {
                        Error += "The ClaimDate must be at most 2 Months ago : ";
                    }
                }
            }
            catch
            {
                Error += "The ClaimDate was not valid : ";
            }


            //ClaimAmnt

            try
            {
                Decimal claimAmntTemp = Convert.ToDecimal(claimAmnt);
                if (claimAmntTemp < 0)
                {
                    Error += "The ClaimAmnt must not be less than 0 : ";
                }
                else if (claimAmntTemp >= 1000000.00M)
                {
                    Error += "The ClaimAmnt may not be equal or larger from 1000000.00M : ";
                }

            }
            catch (Exception e1)
            {
                Error += "The ClaimAmnt was not in the correct format : " + e1.Message;
            }



            //ClaimReason
            if (claimReason.Length <= 0)
            {
                Error += "The ClaimReason may not be Blank : ";
            }
            else if (claimReason.Length > 65535)
            {
                Error += "The ClaimReason may not be above 65535 characters : ";
            }


            return Error;
        }
            

    }
}