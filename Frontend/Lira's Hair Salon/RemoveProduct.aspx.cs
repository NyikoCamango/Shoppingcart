using LaTeamFrontEnd.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaTeamFrontEnd
{
    public partial class RemoveProduct : System.Web.UI.Page
    {
        Service2Client link = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            string PID = Request.QueryString["PID"];
            string ID = Request.QueryString["ID"];

            if (PID != null)
            {
                bool x = link.StatusProduct(Convert.ToInt32(PID), 1);
                Response.Redirect("ProductInfo.aspx");
            }
            else if (ID != null)
            {
                bool x = link.StatusProduct(Convert.ToInt32(ID), 0);
                Response.Redirect("ProductInfo.aspx");
            }
            else
            {
                Response.Redirect("ProductInfo.aspx");
            }

        }
    }
    }
