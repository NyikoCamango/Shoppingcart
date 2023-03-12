using LaTeamFrontEnd.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaTeamFrontEnd
{
    public partial class Product : System.Web.UI.Page
    {

        Service2Client link = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dynamic items = link.GetAllItems();

                CatalogPrint(items);
            }
           
        }

        protected void DDL1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DDL1.SelectedItem.Value.Equals("1"))
            {
                dynamic items = link.sortPrice();

                CatalogPrint(items);

            }
            else if (DDL1.SelectedItem.Value.Equals("2"))
            {
                dynamic items = link.sortName();

                CatalogPrint(items);
            }
            else
            {
                dynamic items = link.GetAllItems();

                CatalogPrint(items);
            }

        }

        private void CatalogPrint(dynamic items)
        {
           // int id = Convert.ToInt32(Session["Stylistid"].ToString());
            string show = "";
            int total = 0;

         //   Product h = new Product();
          //  dynamic mystyles = link.getHairstyle1(id);
            show += "<section class='ftco-section ftco-team'>";
            show += "<div class='container-fluid px-md-5'>";
            show += "<div class='row justify-content-center pb-3'>";
            show += "<div class='col-md-10 heading-section text-center ftco-animate'>";
            show += "<h2 class='mb-4'>Our Salon Products</h2>";
            show += "</div>";
            show += "</div>";
            show += "<div class='row'>";
            show += "<div class='col-md-12 ftco-animate'>";
            show += "<div class='carousel-team owl-carousel'>";
            foreach (ProductClass prod in items)
            {
                show += "<div class='item'>";
                show += "<a href='ProductDetail.aspx?PID=" + prod.ID+"'class='team text-center'>" ;
                show += "<div class='img' style='background-image: url(" + prod.image + ");'></div>";
                show += "<h2>" + prod.productName + "</h2>";
                show += "<span class='position'>" + Math.Round( prod.productPrice, 2) + "</span>";
                show += "</a>";
                show += "</div>";
                total += 1;
            }
            show += "</div>";
            show += "</div>";
            show += "</div>";
            show += "</div>";
            show += "</div>";
            show += "</section>";

            showHairstyles.InnerHtml = show;
        }
    }
}