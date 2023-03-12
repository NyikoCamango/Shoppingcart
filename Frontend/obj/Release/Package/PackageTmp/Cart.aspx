<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="LaTeamFrontEnd.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="hero-wrap hero-wrap-2" style="background-image: url('images/salon2.jpg');",  data-stellar-background-ratio="0.5">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-end justify-content-center">
          <div class="col-md-9 ftco-animate pb-5 text-center">
              
            <h2 class="mb-0 bread">Shopping Cart </h2>
            <p class="breadcrumbs"><span class="mr-2"><a href="index.html">Home <i class="ion-ios-arrow-round-forward"></i></a></span> <span>Select Items and Proceed to Checkout<i class="ion-ios-arrow-round-forward"></i></span></p>
          </div>
        </div>
      </div>
    </section>
   
        <section class="ftco-section ftco-cart">
            <div class="container">
                <br /><br />
                <div class="row">
                    <div class="col-md-12 ftco-animate">
                        <div class="cart-list">
                            <table class="table">
                                <thead class="thead-primary">
                                    <tr class="text-center">
                                        <th>&nbsp;</th>
                                        <th>&nbsp;</th>
                                        <th>Product name</th>
                                        <th>Price</th>
                                        <th>Quantity</th>
                                        <th>Total</th>
                                    </tr>
                                </thead>
                                <tbody id="cartitems" runat="server">
                                    <tr class="text-center text-black">
                                        <td class="product-remove"><a href="RemoveProduct.aspx"><span class="ion-ios-close">Remove</span></a></td>

                                        <td class="image-prod">
                                            <img src="images/shirt_1.jpg" height="100" width="100" />
                                        </td>

                                        <td>
                                            <h3>Bell Pepper</h3>
                                            
                                        </td>

                                        <td class="price">$4.90</td>

                                        <td>
                                            <div>
                                                <input type="text" readonly class="justify-content-center mb-auto px-0" size="5" value="1">
                                            </div>
                                        </td>

                                        <td class="total">$4.90</td>
                                    </tr>
                                    <!-- END TR-->
                                </tbody>


                            </table>
                        </div>
                    </div>
                </div>
            </div>
             <br /><br />
            <div class="row form-group">
                <div class="col-sm-8 col-md-8">
                    <p><a href="Product.aspx" class="btn btn-secondary py-3 px-4">Add More Items to Cart</a></p>
                </div>
            </div>

            <div class="row justify-content-end">
                <div class="col-lg-6 mt-5 cart-wrap ftco-animate">
                    <hr />
                        <div class="row form-group" visible="False" id="errorMsg" runat="server">
                        <div class="col-md-12">
                            <textarea name="message" id="message" cols="30" rows="5" class="form-control text-warning" runat="server" role="alert"></textarea>
                        </div>
                    </div>
                </div>
                
                <div class="col-lg-6 mt-5 cart-wrap ftco-animate">
                    <div class="cart-total mb-3 text-black text-capitalize">
                        <h3 class="font-weight-bold">Cart Totals</h3>
                        <p class="d-flex">
                            <span>Subtotal</span>
                            <span id="SubT" runat="server"></span>
                        </p>
                        <p class="d-flex">
                            <span>Delivery</span>
                            <span id="Delivery" runat="server"></span>
                        </p>
                        <p class="d-flex">
                            <span>Discount</span>
                            <span id="Disc" runat="server"></span>
                        </p>
                        <p class="d-flex">
                            <span>VAT (15%)</span>
                            <span id="VatF" runat="server"></span>
                        </p>
                        <hr>
                        <p class="d-flex total-price">
                            <span>Total (VAT incl.)</span>
                            <span id="Total" runat="server"></span>
                        </p>
                    </div>
                    <p><a href="Checkout.aspx" class="btn btn-success py-3 px-4">Proceed to Checkout</a></p>
                </div>
            </div>

        </section>
    
</asp:Content>
