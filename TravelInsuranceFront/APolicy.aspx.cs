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
        aPolicy.PolicyID = int.Parse(txtPolicyID.Text);
        var staffId = txtStaffID.Text;
        var customerId = txtCustomerID.Text;
        var price = txtPrice.Text;
        var policeDetails = txtPolicyDetails.Text;
        var startDate = calStartDate.SelectedDate.ToString();
        var error = aPolicy.Valid(staffId, customerId, policeDetails, startDate, price);
        if (error == "")
        {
            aPolicy.StaffID = int.Parse(txtStaffID.Text);
            aPolicy.CustomerID = int.Parse(txtCustomerID.Text);
            aPolicy.Price = decimal.Parse(Convert.ToDecimal(txtPrice.Text).ToString("N2"));
            aPolicy.StartDate = calStartDate.SelectedDate;
            aPolicy.PolicyDetails = txtPolicyDetails.Text;
            aPolicy.Accepted = Convert.ToBoolean(chkAccepted.Checked);
            Session["APolicy"] = aPolicy;
            Response.Redirect("PolicyViewer.aspx");
        }
        else
        {
            lblError.Text = error;
        }
    }


    protected void BtnFind_Click(object sender, EventArgs e)
    {
        var aPolicy = new clsPolicy();
        var PolicyID = Convert.ToInt32(txtPolicyID.Text);
        var Found = aPolicy.Find(PolicyID);
        if (!Found) return;
        txtPolicyID.Text = aPolicy.PolicyID.ToString();
        txtStaffID.Text = aPolicy.StaffID.ToString();
        txtCustomerID.Text = aPolicy.CustomerID.ToString();
        txtPolicyDetails.Text = aPolicy.PolicyDetails;
        txtPrice.Text = aPolicy.Price.ToString();
        chkAccepted.Checked = aPolicy.Accepted;
        calStartDate.VisibleDate = aPolicy.StartDate;
        calStartDate.SelectedDate = aPolicy.StartDate;
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {

    }
}