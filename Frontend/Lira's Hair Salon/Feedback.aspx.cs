using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LaTeamFrontEnd.ServiceReference2;

namespace LaTeamFrontEnd
{
    public partial class Feedback : System.Web.UI.Page
    {
        Service2Client SC = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void post_Click(object sender, EventArgs e)
        {
            Review review = new Review();
            review.Image = image.ImageUrl;
            review.User_ID = Convert.ToInt32(Session["UID"]);
            double rating = 0.0;
            if (starS1.Checked) rating = Convert.ToDouble(starS1.Value);
            if (starS2.Checked) rating = Convert.ToDouble(starS2.Value);
            if (starS3.Checked) rating = Convert.ToDouble(starS3.Value);
            if (starS4.Checked) rating = Convert.ToDouble(starS4.Value);
            if (starS5.Checked) rating = Convert.ToDouble(starS5.Value);
            review.Rating = (float)rating;
            review.Description = comments.Value;

            var check = SC.addReview(review);

            if(check == 1)
            {
                success_message.Visible = true;
                success_message.Text = "Posted your feedback successfully!";
                Response.Redirect("Home.aspx");
            }
            else
            {
                error_message.Visible = true;
                error_message.Text = "Sorry there was an error sending your form. " + Convert.ToString(check);
            }
        }
    }
} 