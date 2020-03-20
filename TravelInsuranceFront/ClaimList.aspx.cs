using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClaimList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayClaims();
        }
    }

    private void DisplayClaims()
    {
        TravelInsuranceClasses.clsClaimCollection Claims = new TravelInsuranceClasses.clsClaimCollection();
        lstClaimList.DataSource = Claims.ClaimList;
        lstClaimList.DataValueField = "ClaimID";
        lstClaimList.DataTextField = "StaffID";
        lstClaimList.DataBind();
    }
}