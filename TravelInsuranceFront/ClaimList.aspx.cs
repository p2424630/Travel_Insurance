using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelInsuranceClasses;

public partial class ClaimList : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false) DisplayClaims();
    }

    private void DisplayClaims()
    {
        var Claims = new clsClaimCollection();
        lstClaimList.DataSource = Claims.ClaimList;
        lstClaimList.DataValueField = "ClaimID";
        lstClaimList.DataTextField = "ClaimReason";
        lstClaimList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ClaimID"] = -1;
        Response.Redirect("AClaim.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int ClaimID;
        if (lstClaimList.SelectedIndex != -1)
        {
            ClaimID = Convert.ToInt32(lstClaimList.SelectedValue);
            Session["ClaimID"] = ClaimID;
            Response.Redirect("DeleteClaim.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        int ClaimID;
        if (lstClaimList.SelectedIndex != -1)
        {
            ClaimID = Convert.ToInt32(lstClaimList.SelectedValue);
            Session["ClaimID"] = ClaimID;
            Response.Redirect("AClaim.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        var Claims = new clsClaimCollection();
        Claims.ReportByClaimReason("");
        txtClaimReason.Text = "";
        lstClaimList.DataSource = Claims.ClaimList;
        lstClaimList.DataValueField = "ClaimID";
        lstClaimList.DataTextField = "ClaimReason";
        lstClaimList.DataBind();
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        var Claims = new clsClaimCollection();
        Claims.ReportByClaimReason(txtClaimReason.Text);
        lstClaimList.DataSource = Claims.ClaimList;
        lstClaimList.DataValueField = "ClaimID";
        lstClaimList.DataTextField = "ClaimReason";
        lstClaimList.DataBind();
    }
}