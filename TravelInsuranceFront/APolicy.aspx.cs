using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelInsuranceClasses;

public partial class APolicy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsPolicy APolicy = new clsPolicy();
        APolicy.PolicyID = Int32.Parse(PolicyID.Text);
        Session["APolicy"] = APolicy;
        Response.Redirect("PolicyViewer.aspx");
    }

    protected void PolicyID_TextChanged(object sender, EventArgs e)
    {

    }
}