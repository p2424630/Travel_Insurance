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
        AClaim.ClaimReason = txtClaimReason.Text;
        AClaim.ClaimID = Int32.Parse(txtClaimID.Text);
        AClaim.ClaimDate = DateTime.Parse(txtClaimDate.Text);
        AClaim.ClaimAmnt = Decimal.Parse(txtClaimAmnt.Text);
        AClaim.ClaimStatus = Boolean.Parse(txtClaimStatus.Text);
        AClaim.CustomerID = Int32.Parse(txtCustomerID.Text);
        AClaim.StaffID = Int32.Parse(txtStaffID.Text);
        Session["AClaim"] = AClaim;
        Response.Redirect("ClaimViewer.aspx");
    }
}