<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="LaTeamFrontEnd.ProductDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <section class="hero-wrap hero-wrap-2" style="background-image: url('images/salon2.jpg');",  data-stellar-background-ratio="0.5">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-end justify-content-center">
          <div class="col-md-9 ftco-animate pb-5 text-center">
              
            <h2 class="mb-0 bread">Product Detail </h2>
            <p class="breadcrumbs"><span class="mr-2"><a href="index.html">Home <i class="ion-ios-arrow-round-forward"></i></a></span> <span>Products Details Shown<i class="ion-ios-arrow-round-forward"></i></span></p>
          </div>
        </div>
      </div>
    </section>
    <div class="container">
            <div class="row">
                <div class="col-lg-6 float-right" id="image" runat="server">
                    <a href="images/shoe_1.jpg" class="image-popup">
                        <img src="images/shoe_1.jpg" class="img-fluid" alt="image"></a>
                </div>
                <div class="col-lg-6  text-black clearfix">
                    <div class="row" id="description" runat="server">
                        <div class="col-lg-12">
                            <h2>Bell Pepper</h2>
                            <hr />
                            <h5>Type: </h5>
                            <hr />
                            <h4 class="section-sub-titl"><span>Price: R120.00</span></h4>
                            <hr />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-12">
                            
                                Quantity:<br />
                                <input type="number" class="form-control text-center w-25" required runat="server" id="quantity"/><br /><br />
                                <asp:Button type="button" ID="btnAddToCart" Text="Add To Cart" OnClick="btnAddToCart_Click" class="btn btn-black py-3 w-50" runat="server" />

                      
                        </div>
                    </div>
                </div>
            </div>
        </div>
   
</asp:Content>
