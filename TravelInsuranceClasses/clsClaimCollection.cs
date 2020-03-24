using System;
using System.Collections.Generic;

namespace TravelInsuranceClasses
{
    public class clsClaimCollection
    {
        private List<clsClaim> _mClaimList = new List<clsClaim>();
        private clsClaim _mThisClaim = new clsClaim();

        public clsClaimCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblClaim_SelectAll");
            PopulateArray(DB);
        }

        public List<clsClaim> ClaimList
        {
            get => _mClaimList;
            set => _mClaimList = value;
        }

        public clsClaim ThisClaim
        {
            get => _mThisClaim;
            set => _mThisClaim = value;
        }

        public int Count
        {
            get => _mClaimList.Count;
            set { }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", _mThisClaim.CustomerID);
            DB.AddParameter("@StaffID", _mThisClaim.StaffID);
            DB.AddParameter("@ClaimReason", _mThisClaim.ClaimReason);
            DB.AddParameter("@ClaimDate", _mThisClaim.ClaimDate);
            DB.AddParameter("@ClaimAmnt", _mThisClaim.@ClaimAmnt);
            DB.AddParameter("@ClaimStatus", _mThisClaim.ClaimStatus);

            return DB.Execute("sproc_tblClaim_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ClaimID", _mThisClaim.ClaimID);
            DB.Execute("sproc_tblClaim_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ClaimID", _mThisClaim.ClaimID);
            DB.AddParameter("@CustomerID", _mThisClaim.CustomerID);
            DB.AddParameter("@StaffID", _mThisClaim.StaffID);
            DB.AddParameter("@ClaimReason", _mThisClaim.ClaimReason);
            DB.AddParameter("@ClaimDate", _mThisClaim.ClaimDate);
            DB.AddParameter("@ClaimAmnt", _mThisClaim.@ClaimAmnt);
            DB.AddParameter("@ClaimStatus", _mThisClaim.ClaimStatus);

            DB.Execute("sproc_tblClaim_Update");
        }

        public void ReportByClaimReason(string ClaimReason)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ClaimReason", ClaimReason);
            DB.Execute("sproc_tblClaim_FilterByClaimReason");
            PopulateArray(DB);
        }

        public void PopulateArray(clsDataConnection DB)
        {
            var index = 0;
            var recordCount = DB.Count;
            _mClaimList = new List<clsClaim>();
            while (index < recordCount)
            {
                var AClaim = new clsClaim();
                AClaim.ClaimID = Convert.ToInt32(DB.DataTable.Rows[index]["ClaimID"]);
                AClaim.CustomerID = Convert.ToInt32(DB.DataTable.Rows[index]["CustomerID"]);
                AClaim.ClaimDate = Convert.ToDateTime(DB.DataTable.Rows[index]["ClaimDate"]);
                AClaim.ClaimReason = Convert.ToString(DB.DataTable.Rows[index]["ClaimReason"]);
                if (Convert.ToString(DB.DataTable.Rows[index]["ClaimAmnt"]).Length > 0)
                    AClaim.ClaimAmnt = Convert.ToDecimal(DB.DataTable.Rows[index]["ClaimAmnt"]);
                if (Convert.ToString(DB.DataTable.Rows[index]["ClaimStatus"]).Length > 0)
                    AClaim.ClaimStatus = Convert.ToBoolean(DB.DataTable.Rows[index]["ClaimStatus"]);
                if (Convert.ToString(DB.DataTable.Rows[index]["StaffID"]).Length > 0)
                    AClaim.StaffID = Convert.ToInt32(DB.DataTable.Rows[index]["StaffID"]);
                _mClaimList.Add(AClaim);
                index++;
            }
        }
    }
}