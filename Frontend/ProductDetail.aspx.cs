using LaTeamFrontEnd.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaTeamFrontEnd
{
    
    public partial class ProductDetail : System.Web.UI.Page
    {
        Service2Client link = new Service2Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["PID"];
            var i = link.GetItem(id);

            string print = "";
            print += "<a href='Product.aspx?PID=" + i.ID;
            print += "<div class='blog-entry align-self-stretch d-md-flex'>";
            print += "<a href='" + i.image + "' class='block-20'>";
            print += "<img src='" + i.image + "' class='block-20' alt='Photo'></a>";
            image.InnerHtml = print;

            print = " ";
            print += "<div class='col-lg-12'>";
            print += "<h2>" + i.productName + "</h2>";
            print += "<hr/><h5>Type: " + i.type + "</h5><h5>Size: "  + "</h5><h5>Gender: " + i.gender + "</h5>";
            print += "<hr/><h4><span>Price: R" + Math.Round(i.productPrice, 2) + "</span></h4><hr/></div>";
            description.InnerHtml = print;
            
            string q = Request.QueryString["QUA"];
            if (!IsPostBack)
            {
                quantity.Value = q;
                if (q != null)
                {
                    btnAddToCart.Text = "Update";
                }
            }
        }

       
		              
		              

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["PID"];

            int qua = Convert.ToInt32(quantity.Value);
            Response.Redirect("AddToCart.aspx?PID=" + id + "&QUA=" + qua);


        }

    }
    }
