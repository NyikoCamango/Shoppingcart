using LaTeamFrontEnd.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaTeamFrontEnd
{
    public partial class AddToCart : System.Web.UI.Page
    {
        Service2Client link = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (link.UpdateQuantity(Convert.ToInt32(Session["bookingID"]), Convert.ToInt32(Request.QueryString["PID"]), Convert.ToInt32(Request.QueryString["QUA"])) == true)
            {
                Response.Redirect("Cart.aspx");
            }
            else
            {
                bool res = link.AddToCart(Convert.ToString(Session["bookingID"].ToString()), Request.QueryString["PID"], Convert.ToInt32(Request.QueryString["QUA"]));
                Response.Redirect("Cart.aspx");
            }

        }
    }
}