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
    public partial class Booking : System.Web.UI.Page
    {
        Service2Client link = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddAppointment(object sender, EventArgs e)
        {
            var add = new AppointmentClass
            {
                name = appointment_name.Value,
                email = appointment_email.Value,
                date = appointment_date.Value,
                time = appointment_time.Value,
                username = appointment_email.Value,
                phone = phone.Value,
                message = message1.Value,
                userid = (Session["bookingID"].ToString()),
                salonname = Session["SalonName"].ToString()
            };
            Session["UserMail"] = appointment_email.Value;
            bool check = link.addAppointment(add);
            if (check == true)
            {/*
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    message.From = new MailAddress("reason.sithole99@gmail.com");
                    message.To.Add(new MailAddress(Session["UserMail"].ToString()));
                    message.Subject = "BOOKING ";
                    message.IsBodyHtml = true;
                    
                    message.Body = appointment_name.Value + " Just Made a Booking, Date " + appointment_date.Value
                            + " Time " + appointment_time.Value
                            + "Special Request  "+ message1.Value;
                smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";
                   smtp.Timeout = 10000;
                smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("reason.sithole99@gmail.com", "akfzhsntochjyolc");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                Session["custName"] = appointment_name.Value;
                Session["date"] = appointment_date.Value;
                Session["time"] = appointment_time.Value;*/
                book.Visible = true;
                status.InnerText = "Your Booking was successful,your Stylist will be notified";
            }
            else
            {
                status.InnerText = "An error Has occured!!";
            }

        }

    }
    }

