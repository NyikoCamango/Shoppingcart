using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LaTeamFrontEnd.ServiceReference2;
namespace NewLateamFrontEnd
{
    public partial class editAppointment : System.Web.UI.Page
    {
        Service2Client link = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void update(object sender, EventArgs e)
        {
            bool check = link.editAppointment(Convert.ToInt32(Request.QueryString["appId"]), appointment_date.Value, appointment_time.Value);
            if(check==true)
            {
                status.InnerHtml = "Appointment Updated, your stylist will be Notified!";
            }
            else
            {
                status.InnerHtml = Request.QueryString["appId"];
            }
        }
        public void cancel(object sender, EventArgs e)
        {
            bool check = link.deleteAppointment(Convert.ToInt32(Request.QueryString["appId"]));
            if(check==true)
            {
                status.InnerHtml = "Appointment Successfully Cancelled,your stylist will be Notified";
            }
        }
    }
}