using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelInsuranceClasses;

public partial class AClaim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsClaim AClaim = new clsClaim();

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsClaim AClaim = new clsClaim();
        string ClaimReason = txtClaimReason.Text;
        string ClaimDate = txtClaimDate.Text;
        string ClaimAmnt = txtClaimAmnt.Text;
        string CustomerID = txtCustomerID.Text;
        string StaffID = txtStaffID.Text;
        string error = "";
        error = AClaim.Valid(StaffID, CustomerID, ClaimDate, ClaimAmnt, ClaimReason);

        if (error == "")
        {
            AClaim.ClaimReason = txtClaimReason.Text;
            AClaim.ClaimID = Convert.ToInt32(txtClaimID.Text);
            AClaim.ClaimDate = Convert.ToDateTime(txtClaimDate.Text);
            AClaim.CustomerID = Convert.ToInt32(txtCustomerID.Text);

            if (txtClaimAmnt.Text != "")
            {
                AClaim.ClaimAmnt = Convert.ToDecimal(txtClaimAmnt.Text);
            }

            if (txtClaimStatus.Text != "")
            {
                AClaim.ClaimStatus = Convert.ToBoolean(txtClaimStatus.Text);
            }

            if (txtStaffID.Text != "")
            {
                AClaim.StaffID = Convert.ToInt32(txtStaffID.Text);
            }

            Session["AClaim"] = AClaim;
            Response.Redirect("ClaimViewer.aspx");
        }
        else
        {
            lblError.Text = error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsClaim AClaim = new clsClaim();
        int ClaimID;
        ClaimID = Convert.ToInt32(txtClaimID.Text);
        bool Found = AClaim.Find(ClaimID);
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