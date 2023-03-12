<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="NewLateamFrontEnd.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="hero-wrap hero-wrap-2" style="background-image: url('images/salon2.jpg');" data-stellar-background-ratio="0.5">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-end justify-content-center">
          <div class="col-md-9 ftco-animate pb-5 text-center">
            <h2 class="mb-0 bread">Edit Profile</h2>
            <p class="breadcrumbs"><span class="mr-2"><a href="Home.aspx">Home <i class="ion-ios-arrow-round-forward"></i></a></span> <span>Profile <i class="ion-ios-arrow-round-forward"></i></span></p>
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
            <h2 class="mb-4">Profile</h2>

          </div>
        </div>
       
    		<div class="row justify-content-center">
    			<div class="col-md-10 ftco-animate">
    				
	            <div class="row">
	              <div class="col-sm-6">
	                <div class="form-group">
                        <input id="username" type="text" runat="server" placeholder="Enter New Username"  class="form-control">
			            <div id="results" runat="server" style="color:lightseagreen; text-align:left"></div>
                        </div>
	              </div>
                      <span></span>
         		          <div class="form-group">
                  <pre><asp:Button ID="Button1" runat="server" Text="Update Username" OnClick="uname_Click" class="btn btn-primary" />
	           </pre> </div>
    			</div>
    		</div>
    	</div>
            <div class="row justify-content-center">
    			<div class="col-md-10 ftco-animate">
    				
	            <div class="row">
	              <div class="col-sm-6">
	                <div class="form-group">
                        <input id="password" type="text" runat="server" placeholder="Enter New Password"  class="form-control">
			            <div id="Div1" runat="server" style="color:lightseagreen; text-align:left"></div>
                        </div>
	              </div>
                      <span></span>
         		          <div class="form-group">
                  <pre><asp:Button ID="Button5" runat="server" Text="Recorver Password" OnClick="passWord" class="btn btn-primary" />
	      
	           </pre> </div>
    			</div>
    		</div>
           </div>
                	<div class="row justify-content-center">
    			<div class="col-md-10 ftco-animate">
    				
	            <div class="row">
	              <div class="col-sm-6">
	                <div class="form-group">
                        <input id="phone" type="text" runat="server" placeholder="Enter New PhoneNumber"  class="form-control">
			            <div id="Div2" runat="server" style="color:lightseagreen; text-align:left"></div>
                        </div>
	              </div>
                      <span></span>
         		          <div class="form-group">
                  <pre><asp:Button ID="Button2" runat="server" Text="Update Phone Number" OnClick="phoneNumber" class="btn btn-primary" />
	      
	           </pre> </div>
    			</div>
    		</div>
           </div>

            <div class="row justify-content-center">
    			<div class="col-md-10 ftco-animate">
	            <div class="row">
	              <div class="col-sm-6">
	                <div class="form-group">
                     <asp:Button ID="book" runat="server"  Text="View Booking History" OnClick="BookingHistory" class="btn btn-primary" />
			            <div id="Div3" runat="server" style="color:lightseagreen; text-align:left"></div>
                        </div>
	              </div>     
                        </div>  
                        </div>  
               
	        <br />       
            <br />
            <div id="myTable" Visible="false" runat="server">
            <style>
table {
  font-family: arial, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

td, th {
  border: 1px solid #dddddd;
  text-align: left;
  padding: 8px;
}

tr:nth-child(even) {
  background-color: #dddddd;
}
</style>
                </div>

			            <div id="Div4" runat="server" style="color:lightseagreen; text-align:left"></div>
                        </div>
        <div id="displayStylists" runat="server"></div>
    </section>
     
          </div>
        </div>
      </div>
    </section>
</asp:Content>
