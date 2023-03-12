using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LaTeamFrontEnd.ServiceReference2;
namespace NewLateamFrontEnd
{
    public partial class Stylists : System.Web.UI.Page
    {
        Service2Client link = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["StylistId"]); 
            dynamic check = link.getHairstyle1(id);
            if(check!=null)
            {
                string show = "";
               // Hairstyle1 h = new Hairstyle1();
                dynamic mystyles = link.getHairstyle1(id);
                show += "<section class='ftco-section ftco-team'>";
                show += "<div class='container-fluid px-md-5'>";
                show += "<div class='row justify-content-center pb-3'>";
                show += "<div class='col-md-10 heading-section text-center ftco-animate'>";
                show += "<h2 class='mb-4'>My HairStyles</h2>";
                show += "</div>";
                show += "</div>";
                show += "<div class='row'>";
                show += "<div class='col-md-12 ftco-animate'>";
                show += "<div class='carousel-team owl-carousel'>";
                string SalonName = link.getSalonName(Convert.ToInt32(Request.QueryString["StylistId"]));
                Session["SalonNAME"] = SalonName;
                foreach (Hairstyle1 hairstyle in mystyles)
                {
                    salonName.InnerHtml = "Welcome to "+ SalonName;
                    show += "<div class='item'>";
                    show += "<a href='Booking.aspx?hairStyleID=" + hairstyle.Id + "' class='team text-center'>";
                    show += "<div class='img' style='background-image: url(" + hairstyle.Image + ");'></div>";
                    show += "<h2>" + hairstyle.HairstyleName + "</h2>";
                    show += "<span class='position'>" + hairstyle.HairstylePrice + "</span>";
                    show += "</a>";
                    show += "</div>";
                    
                }
                show += "</div>";
                show += "</div>";
                show += "</div>";
                show += "</div>";
                show += "</div>";
                show += "</section>";

                display.InnerHtml = show;
            }

        }
    }
}