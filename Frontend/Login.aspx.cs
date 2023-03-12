using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LaTeamFrontEnd.ServiceReference2;

namespace NewLateamFrontEnd
{
    public partial class Login : System.Web.UI.Page
    {
        Service2Client link = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignIn(object sender, EventArgs e)
        {
            int check = link.logintype(userName.Value, password.Value);
            if (check == 1)
            {
                Session["UserName"] = userName.Value;
                Session["1"] = check;
                int id = link.getMyUser(userName.Value);
                Session["bookingID"] = id;
                Response.Redirect("Home.aspx");
            }
            else if (check == 2)
            {
                Session["UserName"] = userName.Value;
                Session["2"] = check;
                Stylist s = new Stylist();
                int id = link.getStylist(userName.Value);
                Session["Stylistid"] = id;
                string salonName = link.getSalonName(id);
                Session["SALON_NAME"] = salonName;
                Session["StylistUName"] = userName.Value;
                //Redirect("Dummy.aspx");
                Response.Redirect("Home.aspx");
            }
            else if (check == 3)
            {
                Session["UserName"] = userName.Value;
                Session["3"] = check;
                Response.Redirect("Home.aspx");
            }
            else
            {
                status.InnerText = "Invalid userName or Password";
            }
        }
    }
}
