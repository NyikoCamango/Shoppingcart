<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="editAppointment.aspx.cs" Inherits="NewLateamFrontEnd.editAppointment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <section class="hero-wrap hero-wrap-2" style="background-image: url('images/salon2.jpg');" data-stellar-background-ratio="0.5">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-end justify-content-center">
          <div class="col-md-9 ftco-animate pb-5 text-center">
            <h2 class="mb-0 bread">Edit Appointment </h2>
            <p class="breadcrumbs"><span class="mr-2"><a href="Home.aspx">Home <i class="ion-ios-arrow-round-forward"></i></a></span> <span>Become Stylist <i class="ion-ios-arrow-round-forward"></i></span></p>
          </div>
        </div>
      </div>
    </section>
    <br />
    <br />
 
	          
			              <input type="text"  runat="server" id="appointment_date" class="form-control appointment_date" placeholder="Appointment Date">
			                <br />
			             <input type="text" id="appointment_time" class="form-control appointment_time" runat="server" placeholder="Time">
			           <br />
                      <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="update booking" OnClick="update" />
    <br />
      <br />
                      <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="cancel booking" OnClick="cancel"  />
               <br />
    <div id="status" runat="server"></div>
    <br />
	              
</asp:Content>
