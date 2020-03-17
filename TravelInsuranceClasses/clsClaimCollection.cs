using System;
using System.Collections.Generic;

namespace TravelInsuranceClasses
{
    public class clsClaimCollection
    {
        private List<clsClaim> _mClaimList = new List<clsClaim>();


        public clsClaimCollection()
        {
            int index = 0;
            int recordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblClaim_SelectAll");
            recordCount = DB.Count;
        
            while (index < recordCount)
            {
                clsClaim AClaim = new clsClaim();
                AClaim.ClaimID = Convert.ToInt32(DB.DataTable.Rows[index]["ClaimID"]);
                AClaim.CustomerID = Convert.ToInt32(DB.DataTable.Rows[index]["CustomerID"]);
                AClaim.ClaimDate = Convert.ToDateTime(DB.DataTable.Rows[index]["ClaimDate"]);
                AClaim.ClaimReason = Convert.ToString(DB.DataTable.Rows[index]["ClaimReason"]);

                if (Convert.ToString(DB.DataTable.Rows[index]["ClaimAmnt"]).Length > 0)
                    AClaim.ClaimAmnt = Convert.ToDecimal(DB.DataTable.Rows[index]["ClaimAmnt"]);
                else
                    AClaim.ClaimAmnt = -1.00M;

                AClaim.ClaimStatus = Convert.ToBoolean(DB.DataTable.Rows[index]["ClaimStatus"]);

                if (Convert.ToString(DB.DataTable.Rows[index]["StaffID"]).Length > 0)
                    AClaim.StaffID = Convert.ToInt32(DB.DataTable.Rows[index]["StaffID"]);
                else
                    AClaim.StaffID = 0;
                _mClaimList.Add(AClaim);
                index++;
            }
        }



        public List<clsClaim> ClaimList
        { 
            get => _mClaimList;
            set => _mClaimList = value;
        }
        public clsClaim ThisClaim { get; set; }
        public int Count
        {
            get => _mClaimList.Count;
            set
            {

            }
        }

    }
}