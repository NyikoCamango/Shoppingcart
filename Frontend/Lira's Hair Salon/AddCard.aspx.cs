using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LaTeamFrontEnd.ServiceReference2;

namespace LaTeamFrontEnd
{
    public partial class AddCard : System.Web.UI.Page
    {
        Service2Client SC = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            //instantiate new bank account object
            Bank_Account account = new Bank_Account();
            account.A_Name = card_owner.Value;
            account.Credit_Card_Nr = card_num.Value;
            account.CVV = cvv.Value;
            account.Expiry_Date = Convert.ToDateTime(exp_date.Value);
            account.Cust_Id = Convert.ToInt32(Session["UID"]);

            //Call addBankAccount()
            var add = SC.addBankAccount(account);

            if (add == 1)
            {
                Response.Redirect("Checkout.aspx");
            }
            else if (add == 0)
            {
                error.Text = "This user does not exist.";
                error.Visible = true;
            }
            else
            {
                error.Text = "Something went wrong please try again later";
                error.Visible = true;
            }
        }
    }
}