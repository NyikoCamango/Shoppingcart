<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="NewLateamFrontEnd.Booking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.css" />
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.js"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <section class="hero-wrap hero-wrap-2" style="background-image: url('images/salon2.jpg');" data-stellar-background-ratio="0.5">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-end justify-content-center">
          <div class="col-md-9 ftco-animate pb-5 text-center">
            <h2 class="mb-0 bread">Booking </h2>
            <p class="breadcrumbs"><span class="mr-2"><a href="index.html">Home <i class="ion-ios-arrow-round-forward"></i></a></span> <span>Booking <i class="ion-ios-arrow-round-forward"></i></span></p>
          </div>
        </div>
      </div>
    </section>
    <section class="ftco-section ftco-booking bg-light">
    	<div class="container ftco-relative">
    		<div class="row justify-content-center pb-3">
          <div class="col-md-10 heading-section text-center ftco-animate">
          	<span class="subheading">Booking</span>
            <h2 class="mb-4">Make an Appointment</h2>

          </div>
        </div>
       
    		<div class="row justify-content-center">
    			<div class="col-md-10 ftco-animate">
    				
	            <div class="row">
	              <div class="col-sm-6">
	                <div class="form-group">
			              <input type="text"  runat="server" class="form-control" id="appointment_name" placeholder="Name">
			            </div>
	              </div>
	              <div class="col-sm-6">
	                <div class="form-group">
			              <input type="text" class="form-control" id="appointment_email" runat="server" placeholder="Username">
			            </div>
	              </div>
	              <div class="col-sm-6">
	                <div class="form-group">
	                  <input type="text" id="appointment_date" class="form-control appointment_date" runat="server" placeholder="Date">
	                </div>    
	              </div>
	              <div class="col-sm-6">
	                <div class="form-group">
	                  <input type="text" id="appointment_time" class="form-control appointment_time" runat="server" placeholder="Time">
	                </div>
	              </div>
	             <!-- <div class="col-sm-6">
	                <div class="form-group">
			              <div class="select-wrap">
                      <div class="icon"><span class="ion-ios-arrow-down"></span></div>
                      <select name="" id="type" runat="server" class="form-control">
                      	<option value="">Haircut</option>
                        <option value="">Beard Tramming</option>
                        <option value="">Style</option>
                        <option value="">Other &amp; Coloring</option>
                      </select>
                    </div>
			            </div>
	              </div>-->
	              <div class="col-sm-6">
	                <div class="form-group">
	                  <input type="text" class="form-control" runat="server" id="phone" placeholder="Phone">
	                </div>
	              </div>
	              <div class="col-md-12">
	              	<div class="form-group">
		                <textarea name="" id="message1" runat="server" cols="30" rows="7" class="form-control" placeholder="Message"></textarea>
		              </div>
	              </div>
		          </div>
		          <div class="form-group">
                      <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Make an Appointment" OnClick="AddAppointment"/>
	              <br />
					  <div id="book" visible="false" runat="server">
						 <script type="text/javascript">
                             swal("Booking was Successful!", "Your stylist will be notified!", "success");
                             swal("Booking was Successful!", "Your stylist will be notified!", "success");

                         </script>
					  </div>

					  <div id="results" runat="server"></div>
	            </div>
	         <div id="status" runat="server"></div>
    			</div>
    		</div>
    	
    </section>
</asp:Content>
