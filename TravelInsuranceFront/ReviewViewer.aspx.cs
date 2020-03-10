using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelInsuranceClasses;
public partial class ReviewViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create new instance of clsReview
        clsReview aReview = new clsReview();

        //get the data from the session object
        aReview = (clsReview)Session["aReview"];
        Response.Write(aReview);
    }
}