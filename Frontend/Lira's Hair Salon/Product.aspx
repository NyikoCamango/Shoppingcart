<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="LaTeamFrontEnd.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="hero-wrap hero-wrap-2" style="background-image: url('images/salon2.jpg');",  data-stellar-background-ratio="0.5">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-end justify-content-center">
          <div class="col-md-9 ftco-animate pb-5 text-center">
              
            <h2 class="mb-0 bread">Salon Products </h2>
            <p class="breadcrumbs"><span class="mr-2"><a href="index.html">Home <i class="ion-ios-arrow-round-forward"></i></a></span> <span>Products Dashboard<i class="ion-ios-arrow-round-forward"></i></span></p>
          </div>
        </div>
      </div>
    </section>

     <div class="row text-black">
                <div class="col-12">
                    <hr />
                    <div class="product-topbar d-flex align-items-center justify-content-between">
                        <!-- Total Products -->
                        <div class="total-products">
                            <p class="m-auto"><span id="found" runat="server"></span>Products found</p>
                        </div>

    <div class="sidebar-box bg-light ftco-animate fadeInUp ftco-animated">
                            <h3 class="heading-2">Filter Products By:</h3>
                           
                                <asp:DropDownList ID="DDL1" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="DDL1_SelectedIndexChanged" runat="server">
                                    <asp:ListItem Value="0" Text="Recent" Selected="True">Recent</asp:ListItem>
                                    <asp:ListItem Value="1" Text="Price">Price</asp:ListItem>
                                    <asp:ListItem Value="2" Text="Name">Name</asp:ListItem>
                                </asp:DropDownList>
                           
                        </div>
                   

                        
                    </div>
                    <hr />
                </div>

  </div>
            
    <div id="showHairstyles" runat="server">

             </div>
       
</asp:Content>
