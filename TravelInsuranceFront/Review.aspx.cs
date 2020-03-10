using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelInsuranceClasses;

public partial class Review : System.Web.UI.Page
{
    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsReview aReview = new clsReview();
        aReview.ReviewId = int.Parse(txtCustomerReview.Text);
        aReview.reviewTitle = txtReviewTitle.Text;
        aReview.ReviewText = txtReviewText.Text;
        aReview.datePublished = Convert.ToDateTime(calendar.SelectedDate);
    }
}