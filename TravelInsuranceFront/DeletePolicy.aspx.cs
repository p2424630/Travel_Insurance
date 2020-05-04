using System;
using System.Web.UI;
using TravelInsuranceClasses;

public partial class DeletePolicy : Page
{
    private int PolicyId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the id of policy to be deleted from session obj
        PolicyId = Convert.ToInt32(Session["PolicyId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //instance of policy
        var PolicyList = new clsPolicyCollection();
        //find the record
        PolicyList.ThisPolicy.Find(PolicyId);
        //delete the record
        PolicyList.Delete();
        //redirect back to main
        Response.Redirect("PolicyList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("PolicyList.aspx");
    }
}