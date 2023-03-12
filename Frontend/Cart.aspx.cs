using LaTeamFrontEnd.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaTeamFrontEnd
{
    public partial class Cart : System.Web.UI.Page
    {
        Service2Client link = new Service2Client();

        public static decimal total;
        public static decimal subTotal;
        public static decimal delivery;
        public static decimal discount;
        public static decimal VAT;
        protected void Page_Load(object sender, EventArgs e)
        {
           if (Session["bookingID"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            subTotal = 0;
            delivery = 0;
            discount = 0;
            total = 0;
            VAT = 0;

            dynamic cart = link.GetCartProducts(Convert.ToInt32(Session["bookingID"]));
            string print = "";
            int ID = Convert.ToInt32(Session["bookingID"]);

            foreach (getCartItemsResult i in cart)
            {
                print += "<tr class='text-center text-black'>";
                print += "<td class='product-remove'><a href='RemoveCartItem.aspx?PID=" + i.ID + "&bookingID=" + ID + "'><span class='ion-ios-close'>Remove</span></a></td>";
                print += "<td class='image-prod'>";
                print += "<a href='AboutProduct.aspx?PID=" + i.ID + "'><img src='" + i.Image + "' height='100' width='100'/></td>";
                print += "<td><h4 class='text-black'>" + i.Name + "</h4></a>";
                print += "<p class='section-sub-title'></p></td>";
                print += "<td class='price'>R" + Math.Round(i.Price, 2) + "</td><td>";
                print += "<div class='justify-content-center mb-auto'>";
                print += "<input type='number' name='quantity' class='form-control justify-content-center text-center w-100' readonly value='" + i.Quantity + "' min='1' max='100'>";
                print += "<br/><a href='AboutProduct.aspx?PID=" + i.ID + "&QUA=" + i.Quantity + "' >Update</a></div></td><td class='total'>R" + Math.Round(i.Total, 2) + "</td></tr>";

                subTotal += i.Total;
            }

            cartitems.InnerHtml = print;

            //Calculations
            if (subTotal > 600)
            {
                delivery = 0;
                if (subTotal > 1200 && subTotal <= 5000)
                {
                    discount = 150;
                }
                else if (subTotal > 5000)
                {
                    discount = subTotal * Convert.ToDecimal(0.07);
                }
            }
            else
            {
                delivery = 50;
                discount = 0;
            }

            //Calculating Total
            total = subTotal + delivery - discount;
            //VAT Calculations
            VAT = total * Convert.ToDecimal(0.15);

            SubT.InnerText = "R" + Convert.ToString(Math.Round(subTotal, 2));
            Delivery.InnerText = "R" + Convert.ToString(Math.Round(delivery, 2));
            VatF.InnerText = "R" + Convert.ToString(Math.Round(VAT, 2));
            Disc.InnerText = "-R" + Convert.ToString(Math.Round(discount, 2));
            Total.InnerText = "R" + Convert.ToString(Math.Round(total, 2));
        }
    }
    }
