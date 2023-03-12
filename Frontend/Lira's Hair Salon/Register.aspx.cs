using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LaTeamFrontEnd.ServiceReference2;

namespace NewLateamFrontEnd
{
    public partial class Register : System.Web.UI.Page
    {
        Service2Client link = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateAccount(object sender, EventArgs e)
        {
            bool check = link.isReg(UserName.Value, Password.Value);
            if (check == false)
            {
                var add = new UserClass
                {
                    firstName = FirstName.Value,
                    lastName = LastName.Value,
                    email = Email.Value,
                    phoneNumber = Phone.Value,
                    address = Address.Value,
                    city = City.Value,
                    postalcode = Code.Value,
                    username = UserName.Value,
                    password = Password.Value,
                    confirmpass = ConfPassword.Value
                };
                int test = link.register(add);
                if (test == 1)
                {
                    Response.Redirect("Login.aspx");
                }
            }
            else
            {
                results.InnerHtml = "User Already Exists";
            }
        }

    }
}
