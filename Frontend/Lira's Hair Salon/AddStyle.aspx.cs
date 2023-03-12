using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LaTeamFrontEnd.ServiceReference2;

namespace NewLateamFrontEnd
{
    public partial class AddStyle : System.Web.UI.Page
    {
        Service2Client link = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void editStylist_Click(object sender, EventArgs e)
        {
            edit.Visible = true;
        }

        protected void uname_Click(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editStylistUsername(u, username.Value);
            if (check == true)
            {
                Div1.InnerText = "UserName successfully Changed to " + username.Value;
            }
            else
            {
                Div1.InnerText = "An Error Has Occured";
            }
        }

        protected void email_Click(object sender, EventArgs e)
        {/*
            string u = Session["UserName"].ToString();
            bool check = link.editStylistEmail(u, email.Value);
            if (check == true)
            {
                em.InnerText = "Email successfully Changed to " + email.Value;
            }
            else
            {
                results.InnerText = "An Error Has Occured";
            }*/
        }

        protected void passWord(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editStylistPassword(u, password.Value);
            if (check == true)
            {
                passwordDisplay.InnerText = "Password successfully Changed ";
            }
            else
            {
                passwordDisplay.InnerText = "An Error Has Occured";
            }
        }

        protected void phoneNumber(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editStylistPhoneNumber(u, phone.Value);
            if (check == true)
            {
                phoneDisplay.InnerText = "Phone Number successfully Changed to " + phone.Value;
            }
            else
            {
                phoneDisplay.InnerText = "An Error Has Occured";
            }
        }

        protected void Address(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editStylistAddress(u, address.Value);
            if (check == true)
            {
                addressDisplay.InnerText = "Address successfully Changed to " + address.Value;
            }
            else
            {
                addressDisplay.InnerText = "An Error Has Occured";
            }
        }

        protected void postal(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editStylistPostalCode(u, postalCode.Value);
            if (check == true)
            {
                postalCodeDisplay.InnerText = "Postal code successfully Changed to " + postalCode.Value;
            }
            else
            {
                postalCodeDisplay.InnerText = "An Error Has Occured";
            }
        }


        protected void salonname(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editSalonName(u, salonName.Value);
            if (check == true)
            {
                salonNameDisplay.InnerText = "Salon Name successfully Changed to " + salonName.Value;
            }
            else
            {
                salonNameDisplay.InnerText = "An Error Has Occured";
            }
        }

        protected void salonaddress(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editSalonAdress(u, salonAddress.Value);
            if (check == true)
            {
                salonAddressDisplay.InnerText = "Salon Address successfully Changed to " + salonAddress.Value;
            }
            else
            {
                salonAddressDisplay.InnerText = "An Error Has Occured";
            }
        }

        protected void salonstreet(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editSalonStreet(u, salonStreet.Value);
            if (check == true)
            {
                salonStreetDisplay.InnerText = "Salon Street Name successfully Changed to " + salonStreet.Value;
            }
            else
            {
                salonStreetDisplay.InnerText = "An Error Has Occured";
            }
        }

        protected void salonpostalcode(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editSalonPostalCode(u, salonPostalCode.Value);
            if (check == true)
            {
                salonpostalCodeDisplay.InnerText = "Salon Postal Code successfully Changed to " + salonPostalCode.Value;
            }
            else
            {
                salonpostalCodeDisplay.InnerText = "An Error Has Occured";
            }
        }

        protected void citybtn(object sender, EventArgs e)
        {
            string u = Session["UserName"].ToString();
            bool check = link.editStylistCity(u, city.Value);
            if (check == true)
            {
                CityDisplay.InnerText = "City successfully Changed to " + city.Value;
            }
            else
            {
                CityDisplay.InnerText = "An Error Has Occured";
            }
        }
        protected void upload(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/pictures/");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            FileUpload1.SaveAs(path + Path.GetFileName(FileUpload1.FileName));
            Image1.ImageUrl = "/pictures/" + Path.GetFileName(FileUpload1.FileName);
            Session["image"] = Image1.ImageUrl;
        }
        protected void Add_Click(object sender, EventArgs e)
        {

            /*
            var add = new HairstyleClass
            {
                Styllist_id = Convert.ToInt32(Session["Stylistid"].ToString()),
                HairStyleName = name.Value,
                price = Convert.ToDouble(price.Value),
                image = Session["image"].ToString(),
                

                //image = HttpContext.Current.Session["ImageUpload"].ToString()
            };

            decimal decimalVar = Convert.ToDecimal(price.Value);

            decimalVar = decimal.Round(decimalVar, 2, MidpointRounding.AwayFromZero);

            decimalVar = Math.Round(decimalVar, 2);
            */
            bool check = link.addHairstyle1(Convert.ToInt32(Session["Stylistid"].ToString()), name.Value, Convert.ToDouble(price.Value),
                Session["image"].ToString());
            if (check == true)
            {
                showImage.InnerText = "Hair Style Added";
            }
            else
            {
                showImage.InnerText = "An Error Occured";
            }
        }
        protected void uploadProduct(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/pictures/");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            //changed fileupload and Image from 1 to 2
            FileUpload2.SaveAs(path + Path.GetFileName(FileUpload2.FileName));
            Image2.ImageUrl = "/pictures/" + Path.GetFileName(FileUpload2.FileName);
            Session["image2"] = Image2.ImageUrl;
        }
        protected void AddProduct_Click(object sender, EventArgs e)
        {
            var product = new ProductClass
            {
                productName = productname.Value,
                productDescription = description.Value,
                productPrice = Convert.ToDecimal(productprice.Value),
                image = Session["image2"].ToString()
            };
            bool check = link.addProduct(product);
            // bool check = link.addProduct();
            if (check == true)
            {
                available.InnerText = "Product succesfully added";
            }
            else
            {
                available.InnerText = "Product already exists";
            }

        }


        protected void ViewStyle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["Stylistid"].ToString());
            string show = "";
            Hairstyle1 h = new Hairstyle1();
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
            foreach (Hairstyle1 hairstyle in mystyles)
            {
                show += "<div class='item'>";
                show += "<a href='#' class='team text-center'>";
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

            showHairstyles.InnerHtml = show;
        }

        protected void ViewBookings_Click(object sender, EventArgs e)
        {
            myTable.Visible = true;

            var display = "";
            dynamic check = link.stylistAppointment(Session["SALON_NAME"].ToString());
            if (check != null)
            {
                display += "<table>";
                display += "<tr>";
                display += "<th>" + "Date" + "</th>";
                display += "<th>" + "Time" + "</th>";
                display += "<th>" + "User Name" + "</th>";
                display += "</tr>";
                display += "<tr>";
                foreach (Appointment a in check)
                {

                    display += "<td>" + a.Date + "</td>";
                    display += "<td>" + a.Time + "</td>";
                    display += "<td>" + a.UserName + "</td>";
                    display += "</tr>";
                }
                display += "</tr>";
                display += "</table>";
                showBookings.InnerHtml = display;
            }
            else showBookings.InnerText = " You do not have any appointment";
        }
    }

}
