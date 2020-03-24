using System;
using System.Collections.Generic;
using System.IdentityModel.Claims;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelInsuranceClasses;

public partial class AClaim : Page
{
    private int ClaimID;
    private int ClaimIDTemp;

    protected void Page_Load(object sender, EventArgs e)
    {
        var AClaim = new clsClaim();
        ClaimID = Convert.ToInt32(Session["ClaimID"]);
        if (!IsPostBack)
            if (ClaimID != -1)
                DisplayClaim();
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        var AClaim = new clsClaim();
        var ClaimReason = txtClaimReason.Text;
        var ClaimDate = txtClaimDate.Text;
        var ClaimAmnt = txtClaimAmnt.Text;
        var CustomerID = txtCustomerID.Text;
        var StaffID = txtStaffID.Text;
        var ClaimStatus = txtClaimStatus.Text;
        var error = "";
        error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason, ClaimStatus);

        if (error == "")
        {
            AClaim.ClaimID = ClaimID;
            AClaim.ClaimReason = ClaimReason;
            AClaim.ClaimDate = Convert.ToDateTime(ClaimDate);
            AClaim.CustomerID = Convert.ToInt32(CustomerID);
            if (ClaimAmnt != "") AClaim.ClaimAmnt = Convert.ToDecimal(ClaimAmnt);
            if (ClaimStatus != "") AClaim.ClaimStatus = Convert.ToBoolean(ClaimStatus);
            if (StaffID != "") AClaim.StaffID = Convert.ToInt32(StaffID);

            var ClaimList = new clsClaimCollection();

            if (ClaimID == -1)
            {
                ClaimList.ThisClaim = AClaim;
                ClaimList.Add();
            }
            else
            {
                ClaimList.ThisClaim.Find(ClaimID);
                ClaimList.ThisClaim = AClaim;
                ClaimList.Update();
            }

            Response.Redirect("ClaimList.aspx");
        }
        else
        {
            lblError.Text = error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        var AClaim = new clsClaim();
        int ClaimID;
        if (!int.TryParse(txtClaimID.Text, out ClaimIDTemp))
        {
            lblError.Text = "<br />ClaimID is not an Integer<br />";
        }
        else
        {
            lblError.Text = "";
            ClaimID = ClaimIDTemp;
            var Found = AClaim.Find(ClaimID);
            if (Found)
            {
                txtClaimID.Text = Convert.ToString(AClaim.ClaimID);
                txtCustomerID.Text = Convert.ToString(AClaim.CustomerID);
                txtStaffID.Text = Convert.ToString(AClaim.StaffID);
                txtClaimDate.Text = Convert.ToString(AClaim.ClaimDate);
                txtClaimAmnt.Text = Convert.ToString(AClaim.ClaimAmnt);
                txtClaimStatus.Text = Convert.ToString(AClaim.ClaimStatus);
                txtClaimReason.Text = Convert.ToString(AClaim.ClaimReason);
            }
        }
    }

    protected void DisplayClaim()
    {
        var ClaimList = new clsClaimCollection();
        ClaimList.ThisClaim.Find(ClaimID);
        txtClaimID.Text = Convert.ToString(ClaimList.ThisClaim.ClaimID);
        txtCustomerID.Text = Convert.ToString(ClaimList.ThisClaim.CustomerID);
        txtStaffID.Text = Convert.ToString(ClaimList.ThisClaim.StaffID);
        txtClaimDate.Text = Convert.ToString(ClaimList.ThisClaim.ClaimDate);
        txtClaimAmnt.Text = Convert.ToString(ClaimList.ThisClaim.ClaimAmnt);
        txtClaimStatus.Text = Convert.ToString(ClaimList.ThisClaim.ClaimStatus);
        txtClaimReason.Text = Convert.ToString(ClaimList.ThisClaim.ClaimReason);
    }
}