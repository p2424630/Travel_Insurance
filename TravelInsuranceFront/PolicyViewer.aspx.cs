using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelInsuranceClasses;

public partial class PolicyViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsPolicy APolicy = new clsPolicy();
        APolicy = (clsPolicy)Session["APolicy"];
        Response.Write(APolicy.PolicyID);
    }
}