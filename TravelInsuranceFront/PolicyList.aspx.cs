using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
}