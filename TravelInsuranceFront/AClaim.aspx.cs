﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AClaim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsClaim AClaim = new clsClaim();
        AClaim.ClaimReason = txtClaimReason.Text;
        AClaim.ClaimID = txtClaimID.Text;
        AClaim.ClaimDate = txtClaimDate.Text;
        AClaim.ClaimAmnt = txtClaimAmnt.Text;
        AClaim.ClaimStatus = txtClaimStatus.Text;
        AClaim.PolicyID = txtPolicyID.Text;
        Session["AClaim"] = AClaim;
        Response.Redirect("AddressViewer.aspx");
    }
}