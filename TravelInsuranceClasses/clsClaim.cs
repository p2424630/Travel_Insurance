using System;

namespace TravelInsuranceClasses
{
    public class clsClaim
    {
        private int _mClaimID;
        private int _mStaffID;
        private int _mCustomerID;
        private DateTime _mClaimDate;
        private decimal _mClaimAmnt;
        private bool _mClaimStatus;
        private string _mClaimReason;

        public int ClaimID
        {
            get => _mClaimID;
            set => _mClaimID = value;
        }

        public int StaffID
        {
            get => _mStaffID;
            set => _mStaffID = value;
        }

        public int CustomerID
        {
            get => _mCustomerID;
            set => _mCustomerID = value;
        }

        public DateTime ClaimDate
        {
            get => _mClaimDate;
            set => _mClaimDate = value;
        }

        public decimal ClaimAmnt
        {
            get => _mClaimAmnt;
            set => _mClaimAmnt = value;
        }

        public bool ClaimStatus
        {
            get => _mClaimStatus;
            set => _mClaimStatus = value;
        }

        public string ClaimReason
        {
            get => _mClaimReason;
            set => _mClaimReason = value;
        }

        public bool Find(int ClaimID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ClaimID", ClaimID);
            DB.Execute("sproc_tblClaim_FilterByClaimID");
            if (DB.Count == 1)
            {
                _mClaimID = Convert.ToInt32(DB.DataTable.Rows[0]["ClaimID"]);
                _mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                _mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                _mClaimDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ClaimDate"]);
                _mClaimAmnt = Convert.ToDecimal(DB.DataTable.Rows[0]["ClaimAmnt"]);
                _mClaimStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["ClaimStatus"]);
                _mClaimReason = Convert.ToString(DB.DataTable.Rows[0]["ClaimReason"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string staffID, string customerID, string claimDate, string claimAmnt, string claimReason)
        {
            var error = "";

            //StaffID
            if (staffID.Length > 0)
                try
                {
                    var staffIDTemp = Convert.ToInt32(staffID); //Null staffID returns 0
                    if (staffIDTemp <= 0) error += "<br />The StaffID must be above 0";
                }
                catch (Exception e1)
                {
                    error += "<br />The StaffID wasn't in the correct format or exceeded 2147483648<br />Error: " + e1.Message + "<br />";
                }

            //CustomerID
            try
            {
                var customerIDTemp = Convert.ToInt32(customerID); //Null customerID returns 0
                if (customerIDTemp <= 0) error += "<br />The CustomerID must be above 0";
            }
            catch (Exception e1)
            {
                error += "<br />The CustomerID wasn't in the correct format or exceeded 2147483648<br />Error: " + e1.Message + "<br />";
            }

            //ClaimDate
            try
            {
                var claimDateTemp = Convert.ToDateTime(claimDate); //Null claimDate returns System.DateTime.MinValue 
                if (claimDateTemp > DateTime.Now.Date)
                    error += "<br />The ClaimDate may not be in the future";
                else if (claimDateTemp < DateTime.Now.Date.AddMonths(-2))
                    error += "<br />The ClaimDate must be at most 2 Months ago";
            }
            catch (Exception e1)
            {
                error += "<br />The ClaimDate was not valid<br />Error: " + e1.Message + "<br />";
            }


            //ClaimAmnt
            if (claimAmnt.Length > 0)
                try
                {
                    var claimAmntTemp = Convert.ToDecimal(claimAmnt);
                    if (claimAmntTemp < 0)
                        error += "<br />The ClaimAmnt must not be less than 0";
                    else if (claimAmntTemp >= 1000000.00M)
                        error += "<br />The ClaimAmnt may not be equal or larger from 1000000.00";
                }
                catch (Exception e1)
                {
                    error += "<br />The ClaimAmnt was not in the correct format<br />Error: " + e1.Message + "<br />";
                }

            //ClaimReason
            if (claimReason.Length <= 0)
                error += "<br />The ClaimReason must not be Blank";
            else if (claimReason.Length > 65535) error += "<br />The ClaimReason may not be above 65535 characters";


            return error;
        }
    }
}
