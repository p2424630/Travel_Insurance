using System;
using System.Web.UI;
using TravelInsuranceClasses;

public partial class APolicy : Page
{
    //page level scope variable of PK
    int PolicyId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the policy to be processed
        PolicyId = Convert.ToInt32(Session["PolicyId"]);
        if (IsPostBack == false)
        {
            //if not new record
            if (PolicyId != -1)
            {
                //display current data for the record
                DisplayPolicy();
            }
        }
    }

    private void DisplayPolicy()
    {
        //instance of address book
        var policyList = new clsPolicyCollection();
        //find record
        policyList.ThisPolicy.Find(PolicyId);
        //display data for this record
        txtPolicyId.Text = policyList.ThisPolicy.PolicyId.ToString();
        txtStaffId.Text = policyList.ThisPolicy.StaffId.ToString();
        txtCustomerId.Text = policyList.ThisPolicy.CustomerId.ToString();
        txtPolicyDetails.Text = policyList.ThisPolicy.PolicyDetails;
        txtPrice.Text = policyList.ThisPolicy.Price.ToString();
        chkAccepted.Checked = policyList.ThisPolicy.Accepted;
        calStartDate.VisibleDate = policyList.ThisPolicy.StartDate;
        calStartDate.SelectedDate = policyList.ThisPolicy.StartDate;
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
            //capture policy id
            aPolicy.PolicyId = PolicyId;
            aPolicy.StaffId = int.Parse(txtStaffId.Text);
            aPolicy.CustomerId = int.Parse(txtCustomerId.Text);
            aPolicy.Price = decimal.Parse(Convert.ToDecimal(txtPrice.Text).ToString("N2"));
            aPolicy.StartDate = calStartDate.SelectedDate;
            aPolicy.PolicyDetails = txtPolicyDetails.Text;
            aPolicy.Accepted = Convert.ToBoolean(chkAccepted.Checked);
            // Session["APolicy"] = aPolicy;
            //create a new instance of the policy collection
            var policyList = new clsPolicyCollection();
            
            //if this is a new record
            if (PolicyId == -1)
            {
                //set the ThisPolicy property
                policyList.ThisPolicy = aPolicy;
                //add new record
                policyList.Add();
            }

            //otherwise it must be an update
            else
            {
                //find record
                policyList.ThisPolicy.Find(PolicyId);
                //set the ThisPolicy property
                policyList.ThisPolicy = aPolicy;
                //update the record
                policyList.Update();
            }

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