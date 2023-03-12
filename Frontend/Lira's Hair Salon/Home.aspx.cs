using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewLateamFrontEnd
{
    public partial class Home : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            stylistReg.Visible = false;
            first.Visible = true;
            second.Visible = false;
            if (Session["1"] != null)
            {
                stylistReg.Visible = true;
                second.Visible = true;
                first.Visible = false;
            }else if(Session["2"]!=null)
            {
                second.Visible = true;
                stylistReg.Visible = false;
                first.Visible = false;
            }else if(Session["3"]!=null)
            {
                second.Visible = true;
                first.Visible = false;
            }

        }
        protected void stylistReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("BecomeStylist.aspx");
        }
        protected void book_Click(object sender, EventArgs e)
        {
            Response.Redirect("exe");
        }
    }
}