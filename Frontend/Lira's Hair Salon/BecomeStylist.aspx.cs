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
    public partial class BecomeStylist : System.Web.UI.Page
    {
        Service2Client link = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void upload(object sender, EventArgs e)
        {
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
        }

        protected void add_Click(object sender, EventArgs e)
        {
            string username = Session["UserName"].ToString();
            bool check = link.becomeStylist(username, SalonName.Value,
                SalonAddress.Value, Salonstreet.Value, Saloncode.Value, Session["image"].ToString());
            Stylist s = new Stylist();
            Session["styleID"] = s.Id;
            if (check == true)
            {
                //int id = link.getStylist(Session["2"].ToString());
                //Session["StylistID"] = id;
                Response.Redirect("AddStyle.aspx");
            }
            else
            {
                Response.Redirect("An Error Has Occured");
            }

        }

    }

    }
