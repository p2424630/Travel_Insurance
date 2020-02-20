using System;
using System.Web.UI;
using TravelInsuranceClasses;

public partial class PolicyViewer : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var APolicy = new clsPolicy();
        APolicy = (clsPolicy) Session["APolicy"];
        Response.Write(APolicy.PolicyID + "<br />");
        Response.Write(APolicy.StaffID + "<br />");
        Response.Write(APolicy.CustomerID + "<br />");
        Response.Write(APolicy.PolicyDetails + "<br />");
        Response.Write(APolicy.Price + "<br />");
        Response.Write(APolicy.StartDate + "<br />");
        Response.Write(APolicy.Accepted + "<br />");
    }
}