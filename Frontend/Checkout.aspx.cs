using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LaTeamFrontEnd.ServiceReference2;

namespace LaTeamFrontEnd
{
    public partial class Checkout : System.Web.UI.Page
    {
        Service2Client SC = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"] != null)
            {
                int userID = Convert.ToInt32(Session["UID"]);
                var account = SC.getAccount(userID);

                dynamic purchases = SC.getAllPurchases();
                string print = "";

                foreach(Purchase pay in purchases)
                {
                    if(pay.Cust_Id == userID)
                    {
                        var product = SC.getProduct(pay.Prod_Id);
                        print += "<div class='line'></div>";
                        print += "<table class='order-table'>";
                        print += "<tbody>";
                        print += "<tr>";
                        print += "<td>";
                        print += "<img src='"+ product.ProductImage +"' class='full-width'/>";
                        print += "</td>";
                        print += "<td>";
                        print += "<br>";
                        print += "<span class='thin'>"+ product.ProductName +"</span>";
                        print += "<br>";
                        print += "<span class='thin small'>Quantity: "+ product.Quantity +"<br>";
                        print += "<br>";
                        print += "</span>";
                        print += "</td>";
                        print += "</tr>";
                        print += "<tr>";
                        print += "<td>";
                        print += "<div class='price'>"+ product.ProductPrice +"</div>";
                        print += "</td>";
                        print += "</tr>";
                        print += "</tbody>";
                        print += "</table>";
                        print += "<div class='line'></div>";
                    }
                }

                orderedItems.InnerHtml = print;
                total.InnerText = "R" + Convert.ToString(Cart.total);
                vat.InnerText = "R" + Convert.ToString(Cart.VAT);
                delivery.InnerText = "R" + Convert.ToString(Cart.delivery);

                if (!IsPostBack)
                {
                    card_name.Value = account.A_Name;
                    card_num.Value = account.Credit_Card_Nr;
                    exp_date.Value = Convert.ToString(account.Expiry_Date);
                    cvv.Value = account.CVV;
                }

            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void checkout_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(Session["UserID"]);
            var account = SC.getAccount(userID);

            var pay = new Purchase();
            pay.Cust_Id = userID;
            pay.Prod_Id = Convert.ToInt32(Session["PID"]);
            pay.P_Date = DateTime.Now;
            pay.Quantity = SC.getProduct(pay.Prod_Id).Quantity;

            //Call makePurchase() to process payment
            var purchase = SC.makePurchase(pay);

            if (purchase == 1)
            {
                var trxn = new Transaction();
                trxn.T_Date = pay.P_Date;
                trxn.Amount = SC.getProduct(pay.Prod_Id).ProductPrice;
                trxn.P_ID = pay.Id;
                trxn.ACC_ID = account.Id;

                var transaction = SC.logTransaction(trxn);

                if(transaction == 1)
                {
                    error.Visible = true;
                    error.Text = "Payment Successful";
                }
                else
                {
                    error.Visible = true;
                    error.Text = "Payment failed ! Please try again later";
                }
                
            }
            else if (purchase == 0)
            {
                error.Visible = true;
                error.Text = "Error user does not exist";
            }
            else
            {
                error.Visible = true;
                error.Text = "Payment failed ! Please try again later";
            }
        }
    }
}