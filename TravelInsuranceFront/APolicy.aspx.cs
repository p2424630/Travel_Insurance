using System;
using System.Web.UI;
using TravelInsuranceClasses;

public partial class APolicy : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        var aPolicy = new clsPolicy();
        aPolicy.PolicyId = int.Parse(txtPolicyId.Text);
        var staffId = txtStaffId.Text;
        var customerId = txtCustomerId.Text;
        var price = txtPrice.Text;
        var policeDetails = txtPolicyDetails.Text;
        var startDate = calStartDate.SelectedDate.ToString();
        var error = aPolicy.Valid(staffId, customerId, policeDetails, startDate, price);
        if (error == "")
        {
            aPolicy.StaffId = int.Parse(txtStaffId.Text);
            aPolicy.CustomerId = int.Parse(txtCustomerId.Text);
            aPolicy.Price = decimal.Parse(Convert.ToDecimal(txtPrice.Text).ToString("N2"));
            aPolicy.StartDate = calStartDate.SelectedDate;
            aPolicy.PolicyDetails = txtPolicyDetails.Text;
            aPolicy.Accepted = Convert.ToBoolean(chkAccepted.Checked);
            // Session["APolicy"] = aPolicy;
            //create a new instance of the policy collection
            var policyList = new clsPolicyCollection();
            //set the ThisPolicy property
            policyList.ThisPolicy = aPolicy;
            //add new record
            policyList.Add();
            //redirect back to listpage
            Response.Redirect("PolicyList.aspx");
            // Response.Redirect("PolicyViewer.aspx");
        }
        else
        {
            lblError.Text = error;
        }
    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        var aPolicy = new clsPolicy();
        var PolicyId = Convert.ToInt32(txtPolicyId.Text);
        var Found = aPolicy.Find(PolicyId);
        if (!Found) return;
        txtPolicyId.Text = aPolicy.PolicyId.ToString();
        txtStaffId.Text = aPolicy.StaffId.ToString();
        txtCustomerId.Text = aPolicy.CustomerId.ToString();
        txtPolicyDetails.Text = aPolicy.PolicyDetails;
        txtPrice.Text = aPolicy.Price.ToString();
        chkAccepted.Checked = aPolicy.Accepted;
        calStartDate.VisibleDate = aPolicy.StartDate;
        calStartDate.SelectedDate = aPolicy.StartDate;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
    }
}