using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewLateamFrontEnd
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            profile.Visible = false;
            dashboard.Visible = false;
            mySalon.Visible = false;
            logout.Visible = false;

            if (Session["1"] != null)
            {
                profile.Visible = true;
                logout.Visible = true;
                login.Visible = false;
            }
            if (Session["2"] != null)
            {
                profile.Visible = true;
                mySalon.Visible = true;
                logout.Visible = true;
                login.Visible = false;
            }
            if (Session["3"] != null)
            {
                profile.Visible = true;
                dashboard.Visible = true;
                logout.Visible = true;
                login.Visible = false;
            }
            if(Session["UserName"]== null)
            {
                login.Visible = true;
                logout.Visible = false;
                profile.Visible = false;
                dashboard.Visible = false;
                mySalon.Visible = false;
            }
        }
    }
}