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
        lstPolicyList.DataValueField = "PolicyID";
        //set the data field to display
        lstPolicyList.DataTextField = "CustomerID";
        //bind data to the list
        lstPolicyList.DataBind();
    }
}