using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using TravelInsuranceClasses;
public partial class ClaimViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsClaim AClaim = new clsClaim();
        AClaim = (clsClaim)Session["AClaim"];
        Response.Write(AClaim.ClaimID);
    }
}