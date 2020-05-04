using System;
using TravelInsuranceClasses;

public partial class PolicyList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //first time
        if (IsPostBack == false)
        {
            //update the list box
            DisplayPolicies();
        }
    }

    private void DisplayPolicies()
    {
        //instance of Policy Collection
        TravelInsuranceClasses.clsPolicyCollection Policies = new TravelInsuranceClasses.clsPolicyCollection();
        //set the datasource to the list of policies
        lstPolicyList.DataSource = Policies.PolicyList;
        //set the name of primary key
        lstPolicyList.DataValueField = "PolicyId";
        //set the data field to display
        lstPolicyList.DataTextField = "CustomerId";
        //bind data to the list
        lstPolicyList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["PolicyId"] = -1;
        //redirect to the data entry page
        Response.Redirect("APolicy.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //store the PK value of record to be deleted
        //if a record is selected from the list
        if (lstPolicyList.SelectedIndex != -1)
        {
            //get PK of the record
            //store the data in the session obj
            Session["PolicyId"] = Convert.ToInt32(lstPolicyList.SelectedValue);
            //redirect to delete page
            Response.Redirect("DeletePolicy.aspx");
        }
        else
        {
            //display error
            lblError.Text = "Please select a record to delete from the list < /br>";
        }
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        int PolicyId;
        if (lstPolicyList.SelectedIndex != -1)
        {
            PolicyId = Convert.ToInt32(lstPolicyList.SelectedValue);
            Session["PolicyId"] = PolicyId;
            Response.Redirect("APolicy.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        var Policies = new clsPolicyCollection();
        Policies.ReportByCustomerId("");
        txtCustomerId.Text = "";
        lstPolicyList.DataSource = Policies.PolicyList;
        lstPolicyList.DataValueField = "PolicyId";
        lstPolicyList.DataTextField = "CustomerId";
        lstPolicyList.DataBind();
    }
    protected void btnApply_Click(object sender, EventArgs e)
    {
        var Policies = new clsPolicyCollection();
        Policies.ReportByCustomerId(txtCustomerId.Text);
        lstPolicyList.DataSource = Policies.PolicyList;
        lstPolicyList.DataValueField = "PolicyId";
        lstPolicyList.DataTextField = "CustomerId";
        lstPolicyList.DataBind();
    }
}