using LaTeamFrontEnd.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewLateamFrontEnd
{
    public partial class Profile : System.Web.UI.Page
    {
        Service2Client link = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void uname_Click(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editUserName(u, username.Value);
            if (check == true)
            {
                results.InnerText = "UserName successfully Changed to " + username.Value;
            }
            else
            {
                results.InnerText = "An Error Has Occured";
            }
            string s = Session["2"].ToString();
            bool check1 = link.editStylistUsername(s, username.Value);
            if (check1 == true)
            {
                results.InnerText = "UserName successfully Changed to " + username.Value;
            }
            else
            {
                results.InnerText = "An Error Has Occured";
            }

        }

        protected void passWord(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editPassword(u, password.Value);
            if (check == true)
            {
                Div1.InnerText = "Password successfully Changed to " + password.Value;
            }
            else
            {
                Div1.InnerText = "An Error Has Occured";
            }
        }

        protected void phoneNumber(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editPhoneNumber(u, phone.Value);
            if (check == true)
            {
                Div2.InnerText = "PhoneNumber successfully Changed to " + phone.Value;
            }
            else
            {
                Div2.InnerText = "An Error Has Occured";
            }
        }

        /*protected void Address(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editAddress(u, address.Value);
            if (check == true)
            {
                Div3.InnerText = "Address successfully Changed to " + address.Value;
            }
            else
            {
                Div3.InnerText = "An Error Has Occured";
            }
        }*/

        protected void BookingHistory(object sender, EventArgs e)
        {
            myTable.Visible = true;

            var display = "";
            dynamic check = link.getAppointMent(Convert.ToInt32(Session["bookingID"].ToString()));
            if (check != null)
            {
                display += "<table>";
                display += "<tr>";
                display += "<th>" + "No" + "</th>";
                display += "<th>" + "Date" + "</th>";
                display += "<th>" + "Time" + "</th>";
                display += "<th>" + "Salon Name" + "</th>";
                display += "</tr>";
                display += "<tr>";
                foreach (Appointment a in check)
                {
                    display += "<td>" + a.Id + "</td>";
                    display += "<td>" + a.Date + "</td>";
                    display += "<td>" + a.Time + "</td>";
                    display += "<td>" + a.SalonName + "</td>";
                    display += "<td>" + "<a href='editAppointment.aspx?appId=" + a.UserID + "' >Edit Appointment</a>" + "</td>";
                    //display += "<a href='singleProduct.aspx?hairStyleID=" + a.UserID + "' ></a>";
                    display += "</tr>";
                }

                display += "</tr>";
                display += "</table>";
                displayStylists.InnerHtml = display;
            }
            else displayStylists.InnerText = " You do not have any appointment";
        }

    }

}
