<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BecomeStylist.aspx.cs" Inherits="NewLateamFrontEnd.BecomeStylist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="hero-wrap hero-wrap-2" style="background-image: url('images/salon2.jpg');" data-stellar-background-ratio="0.5">
        <div class="overlay"></div>
        <div class="container">
            <div class="row no-gutters slider-text js-fullheight align-items-end justify-content-center">
                <div class="col-md-9 ftco-animate pb-5 text-center">
                    <h2 class="mb-0 bread">Stylist Registration </h2>
                    <p class="breadcrumbs"><span class="mr-2"><a href="index.html">Home <i class="ion-ios-arrow-round-forward"></i></a></span><span>Become Stylist <i class="ion-ios-arrow-round-forward"></i></span></p>
                </div>
            </div>
        </div>
    </section>
    <section class="services-section ftco-section">
        <div class="container">
            <div class="row justify-content-center pb-3">
                <div class="col-md-10 heading-section text-center ftco-animate">


                    <section class="ftco-section ftco-booking bg-light">
                        <div class="container ftco-relative">
                            <div class="row justify-content-center pb-3">
                                <div class="col-md-10 heading-section text-center ftco-animate">
                                    <h2 class="mb-4">Become Stylist</h2>

                                </div>
                            </div>
                        </div>

                        <div class="row justify-content-center">
                            <div class="col-md-10 ftco-animate">

                                <div class="row">
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <input type="text" runat="server" class="form-control" id="SalonName" placeholder="Salon Name">
                                        </div>
                                    </div>
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <input type="text" runat="server" class="form-control" id="SalonAddress" placeholder="Salon Address">
                                        </div>
                                    </div>
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <input type="text" runat="server" class="form-control" id="Salonstreet" placeholder="Salon Street">
                                        </div>
                                    </div>
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <input type="text" runat="server" class="form-control" id="Saloncode" placeholder="Postal Code">
                                        </div>
                                    </div>


                                    <div class="form-group">
                                        <br />
                                        <asp:FileUpload ID="FileUpload1" runat="server" class="form-control" />
                                        <br />
                                        <asp:Button ID="Button12" runat="server" Text="Upload Image" class="btn btn-primary" OnClick="upload" />
                                        <br />


                                        <br />
                                        <asp:Image ID="Image1" runat="server" Height="250" Width="250" />
                                        <br />
                                        <div id="showImage" runat="server" class="team text-center"></div>
                                        <br />
                                        <br />
                                        <asp:Button ID="Button1" runat="server" Text="Become a stylist Now" class="btn btn-primary" OnClick="add_Click" />
                                        <br />
                                        <div id="results" runat="server"></div>

                                        <br />

                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>

                </div>
            </div>
        </div>
    </section>
</asp:Content>
