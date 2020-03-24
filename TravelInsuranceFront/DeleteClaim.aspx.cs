using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelInsuranceClasses;

public partial class DeleteClaim : System.Web.UI.Page
{
    private int ClaimID;

    protected void Page_Load(object sender, EventArgs e)
    {
        ClaimID = Convert.ToInt32(Session["ClaimID"]);
    }


    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsClaimCollection ClaimList = new clsClaimCollection();
        ClaimList.ThisClaim.Find(ClaimID);
        ClaimList.Delete();
        Response.Redirect("ClaimList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ClaimList.aspx");
    }
}