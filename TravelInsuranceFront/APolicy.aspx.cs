using System;
using System.Web.UI;
using TravelInsuranceClasses;

public partial class APolicy : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsPolicy aPolicy = new clsPolicy();
        aPolicy.PolicyID = int.Parse(txtPolicyID.Text);
        aPolicy.StaffID = int.Parse(txtStaffID.Text);
        aPolicy.CustomerID = int.Parse(txtCustomerID.Text);
        aPolicy.Price = decimal.Parse(txtPrice.Text);
        aPolicy.StartDate = calStartDate.SelectedDate;
        aPolicy.PolicyDetails = txtPolicyDetails.Text;
        aPolicy.Accepted = Convert.ToBoolean(chkAccepted.Checked);
        Session["APolicy"] = aPolicy;
        Response.Redirect("PolicyViewer.aspx");
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
        calStartDate.SelectedDate = aPolicy.StartDate;
        TextBox1.Text = aPolicy.StartDate.ToShortDateString();
    }
}