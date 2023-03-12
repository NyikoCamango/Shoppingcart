using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;

using LaTeamFrontEnd.ServiceReference2;

namespace NewLateamFrontEnd
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        Service2Client link = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Recorver(object sender, EventArgs e)
        {
            UserClass u = new UserClass();
            string check = link.getPassword(Email.Value);
            if (check != null)
            {

                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("reason.sithole99@gmail.com");
                message.To.Add(new MailAddress("ziwaphibookings1@gmail.com"));
                message.Subject = "Email Address Recorvery ";
                message.IsBodyHtml = true;
                message.Body = "Your password is " + check;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("reason.sithole99@gmail.com", "akfzhsntochjyolc");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                status.InnerText = "Email Successfully Sent";



            }
            else
            {
                status.InnerText = "Email does not Exist!!";
            }

        }
    }
}