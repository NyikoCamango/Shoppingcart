using LaTeamFrontEnd.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewLateamFrontEnd
{
    public partial class Manager1 : System.Web.UI.Page
    {
       
        Service2Client link = new Service2Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            remove.Visible = true;
        }

        protected void users_Click(object sender, EventArgs e)
        {
            User u = new User();
            var display = "";
            dynamic check = link.getUsers(u);
            display += "<table>";
            display += "<tr>";
            display += "<th>" + "User Id" + "</th>";
            display += "<th>" + " First Name" + "</th>";
            display += "<th>" + "Last Name" + "</th>";
            display += "<th>" + "Phone Number" + "</th>";
            display += "<th>" + "Email" + "</th>";
            display += "<th>" + "Address " + "</th>";
            display += "<th>" + "City" + "</th>";
            display += "<th>" + "PostalCode" + "</th>";
            display += "<th>" + "UserName" + " </th> ";
            display += "</tr>";

            display += "<tr>";
            foreach (User k in check)
            {

                display += "<td >" + k.Id + "</td>";
                display += "<td >" + k.FirstName + "</td>";
                display += "<td >" + k.LastName + "</td>";
                display += "<td >" + k.PhoneNumber + "</td>";
                display += "<td >" + k.Email + "</td>";
                display += "<td >" + k.Address + "</td>";
                display += "<td >" + k.City + "</td>";
                display += "<td >" + k.PostalCode + "</td>";
                display += "<td >" + k.UserName + "</td>";
                display += "</tr>";

            }
            display += "</tr>";
            display += "</table>";
            displayUsers.InnerHtml = display;
        }

        protected void Stylists_Click(object sender, EventArgs e)
        {
            Stylist style = new Stylist();
            var display = "";
            dynamic check = link.getStylists(style);
            display += "<table>";
            display += "<tr>";
            display += "<th>" + "User Id" + "</th>";
            display += "<th>" + "Last Name" + "</th>";
            display += "<th>" + "Email" + "</th>";
            display += "<th>" + "PhoneNumber " + "</th>";
            display += "<th>" + "Address" + "</th>";
            display += "</tr>";

            display += "<tr>";
            foreach (Stylist k in check)
            {

                display += "<td >" + k.Id + "</td>";
                display += "<td >" + k.LastName + "</td>";
                display += "<th>" + k.Email + "</th>";
                display += "<th>" + k.PhoneNumber + "</th>";
                display += "<th>" + k.Address + "</th>";

                display += "</tr>";
            }
            display += "</tr>";
            display += "</table>";
            displayStylists.InnerHtml = display;
        }

        protected void addStylist_Click1(object sender, EventArgs e)
        {
            bool exists = link.stylistExist(Email.Value);
            if (exists == false)
            {
                var add = new StylistClass
                {
                    lastName = LastName.Value,
                    email = Email.Value,
                    phoneNumber = phoneNumber.Value,
                    address = Address.Value

                };
                bool check = link.addStylist(add);
                if (check == true)
                {
                    stylist_Result.InnerText = "Stylist Succesfully Added";
                }
                else
                {
                    stylist_Result.InnerText = "An Error has Occured!";
                }
            }
            else
            {
                stylist_Result.InnerText = "User Already Exists";
            }
        }

        protected void searchUser_Click(object sender, EventArgs e)
        {

            User k = link.searchUser(search.Value);
            string display = " ";
            if (k != null)
            {
                display += "<table>";
                display += "<tr>";
                display += "<th>" + "User Id" + "</th>";
                display += "<th>" + " First Name" + "</th>";
                display += "<th>" + "Last Name" + "</th>";
                display += "<th>" + "Phone Number" + "</th>";
                display += "<th>" + "Email" + "</th>";
                display += "<th>" + "Address " + "</th>";
                display += "<th>" + "City" + "</th>";
                display += "<th>" + "PostalCode" + "</th>";
                display += "<th>" + "UserName" + " </th> ";
                display += "</tr>";
                display += "<tr>";
                display += "<td >" + k.Id + "</td>";
                display += "<td >" + k.FirstName + "</td>";
                display += "<td >" + k.LastName + "</td>";
                display += "<td >" + k.PhoneNumber + "</td>";
                display += "<td >" + k.Email + "</td>";
                display += "<td >" + k.Address + "</td>";
                display += "<td >" + k.City + "</td>";
                display += "<td >" + k.PostalCode + "</td>";
                display += "<td >" + k.UserName + "</td>";
                display += "</tr>";
                display += "</tr>";
                display += "</table>";
                foundUser.InnerHtml = display;
            }
            else
            {
                foundUser.InnerText = "User Email Not Found,please recheck the Email";
            }
        }

        protected void remove_Click(object sender, EventArgs e)
        {
            int test = link.deleteUser(search.Value);
            if (test == 1)
            {
                removeStatus.InnerHtml = "User Successfully removed";
            }
            else
            {
                Response.Redirect("An error has ocurred");
            }
        }

        protected void searchStylist_Click(object sender, EventArgs e)
        {
            Stylist k = new Stylist();
            k = link.searchStylist(Text1.Value);
            string display = "";
            if (k != null)
            {
                display += "<table>";
                display += "<tr>";
                display += "<th>" + "User Id" + "</th>";
                display += "<th>" + "Last Name" + "</th>";
                display += "<th>" + "Email" + "</th>";
                display += "<th>" + "PhoneNumber " + "</th>";
                display += "<th>" + "Address" + "</th>";
                display += "</tr>";
                display += "<tr>";
                display += "<td >" + k.Id + "</td>";
                display += "<td >" + k.LastName + "</td>";
                display += "<td>" + k.Email + "</td>";
                display += "<td>" + k.PhoneNumber + "</td>";
                display += "<td>" + k.Address + "</td>";
                display += "<td>" + k.Address + "</td>";
                display += "</tr>";
                display += "</tr>";
                display += "</table>";
                Div1.InnerHtml = display;
            }
            else
            {
                Div1.InnerText = "Invalid Stylist Email,please recheck the Email";
            }
        }

        protected void deleteStylist_Click(object sender, EventArgs e)
        {
            int test = link.deleteStylist(Text1.Value);
            if (test == 1)
            {
                deleteStylist_Result.InnerHtml = "User Successfully removed";
            }
            else
            {
                deleteStylist_Result.InnerHtml = "An Error has occured";
            }
        }

        protected void edit_Click(object sender, EventArgs e)
        {
            myProfile.Visible = true;
        }

        protected void uname_Click(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editManagerUsername(u, username.Value);
            if (check == true)
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
            bool check = link.editManagerPassword(u, password.Value);
            if (check == true)
            {
                Div1.InnerText = "Password successfully Changed to " + password.Value;
            }
            else
            {
                Div1.InnerText = "An Error Has Occured";
            }

        }

        protected void EditphoneNumber(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editPhoneNumber(u, phone.Value);
            if (check == true)
            {
                Div1.InnerText = "Password successfully Changed to " + password.Value;
            }
            else
            {
                Div1.InnerText = "An Error Has Occured";
            }

        }



        protected void EditAddress(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editManagerAddress(u, Address.Value);
            if (check == true)
            {
                Div1.InnerText = "Password successfully Changed to " + Address.Value;
            }
            else
            {
                Div1.InnerText = "An Error Has Occured";
            }

        }

        protected void EditEmail(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editManagerEmail(u, Editemail.Value);
            if (check == true)
            {
                Div1.InnerText = "Password successfully Changed to " + Editemail.Value;
            }
            else
            {
                Div1.InnerText = "An Error Has Occured";
            }

        }
    }
}