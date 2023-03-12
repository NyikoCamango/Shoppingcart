<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddStyle.aspx.cs" Inherits="NewLateamFrontEnd.AddStyle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="hero-wrap hero-wrap-2" style="background-image: url('images/salon2.jpg');",  data-stellar-background-ratio="0.5">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-end justify-content-center">
          <div class="col-md-9 ftco-animate pb-5 text-center">
              
            <h2 class="mb-0 bread">Stylist Dashboard </h2>
            <p class="breadcrumbs"><span class="mr-2"><a href="index.html">Home <i class="ion-ios-arrow-round-forward"></i></a></span> <span>Stylist Dashboard<i class="ion-ios-arrow-round-forward"></i></span></p>
          </div>
        </div>
      </div>
    </section>

         <section class="ftco-section ftco-booking bg-light">
             <asp:Button ID="Button11" runat="server" Text="Edit Profile" class="btn btn-primary" OnClick="editStylist_Click"/>
                <div id="edit" runat="server" visible="false">
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
			            <div id="Div1" runat="server" style="color:lightseagreen; text-align:left"></div>
                        </div>
	              </div>
                      <span></span>
         		          <div class="form-group">
                  <pre><asp:Button ID="Button3" runat="server" Text="Update Username" OnClick="uname_Click" class="btn btn-primary" /></asp:Button>
	           
	           </pre> </div>
    			</div>
    		</div>
    	</div>
            <div class="row justify-content-center">
    			<div class="col-md-10 ftco-animate">
    				
	            <div class="row">
	              <div class="col-sm-6">
	                <div class="form-group">
                        <input id="password" type="password" runat="server" placeholder="Enter New Password"  class="form-control">
			            <div id="passwordDisplay" runat="server" style="color:lightseagreen; text-align:left"></div>
                        </div>
	              </div>
                      <span></span>
         		          <div class="form-group">
                  <pre><asp:Button ID="Button6" runat="server" Text="Update Password" OnClick="passWord" class="btn btn-primary" />
	      
	           
	      
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
			            <div id="phoneDisplay" runat="server" style="color:lightseagreen; text-align:left"></div>
                        </div>
	              </div>
                      <span></span>
         		          <div class="form-group">
                  <pre><asp:Button ID="Button7" runat="server" Text="Update Phone Number" OnClick="phoneNumber" class="btn btn-primary" />
	      
	           
	      
	           </pre> </div>
    			</div>
    		</div>
           </div>

            <div class="row justify-content-center">
    			<div class="col-md-10 ftco-animate">
    				
	            <div class="row">
	              <div class="col-sm-6">
	                <div class="form-group">
                        <input id="address" type="text" runat="server" placeholder="Enter New Address"  class="form-control">
			            <div id="addressDisplay" runat="server" style="color:lightseagreen; text-align:left"></div>
                        </div>
	              </div>
                      <span></span>
         		          <div class="form-group">
                  <pre><asp:Button ID="Button8" runat="server" Text="Update Address" OnClick="Address" class="btn btn-primary" />
	      
	           
	      
	           </pre> </div>
    			</div>
    		</div>
           </div>

                        <div class="row justify-content-center">
    			<div class="col-md-10 ftco-animate">
    				
	            <div class="row">
	              <div class="col-sm-6">
	                <div class="form-group">
                        <input id="postalCode" type="text" runat="server" placeholder="Enter New PostalCode"  class="form-control">
			            <div id="postalCodeDisplay" runat="server" style="color:lightseagreen; text-align:left"></div>
                        </div>
	              </div>
                      <span></span>
         		          <div class="form-group">
                  <pre><asp:Button ID="Button1" runat="server" Text="Update Address" OnClick="postal" class="btn btn-primary" />
	      
	           
	      
	           </pre> </div>
    			</div>
    		</div>
           </div>

                        <div class="row justify-content-center">
    			<div class="col-md-10 ftco-animate">
    				
	            <div class="row">
	              <div class="col-sm-6">
	                <div class="form-group">
                        <input id="city" type="text" runat="server" placeholder="Enter City Name"  class="form-control">
			            <div id="CityDisplay" runat="server" style="color:lightseagreen; text-align:left"></div>
                        </div>
	              </div>
                      <span></span>
         		          <div class="form-group">
                  <pre><asp:Button ID="Button2" runat="server" Text="Update City" OnClick="citybtn" class="btn btn-primary" />
	      
	           
	      
	           </pre> </div>
    			</div>
    		</div>
           </div>

                        <div class="row justify-content-center">
    			<div class="col-md-10 ftco-animate">
    				
	            <div class="row">
	              <div class="col-sm-6">
	                <div class="form-group">
                        <input id="salonName" type="text" runat="server" placeholder="Enter New Salon Name"  class="form-control">
			            <div id="salonNameDisplay" runat="server" style="color:lightseagreen; text-align:left"></div>
                        </div>
	              </div>
                      <span></span>
         		          <div class="form-group">
                  <pre><asp:Button ID="Button4" runat="server" Text="Update Salon Name" OnClick="salonname" class="btn btn-primary" />
	      
	           
	      
	           </pre> </div>
    			</div>
    		</div>
           </div>

                        <div class="row justify-content-center">
    			<div class="col-md-10 ftco-animate">
    				
	            <div class="row">
	              <div class="col-sm-6">
	                <div class="form-group">
                        <input id="salonAddress" type="text" runat="server" placeholder="Enter New Address"  class="form-control">
			            <div id="salonAddressDisplay" runat="server" style="color:lightseagreen; text-align:left"></div>
                        </div>
	              </div>
                      <span></span>
         		          <div class="form-group">
                  <pre><asp:Button ID="Button5" runat="server" Text="Update Salon Address" OnClick="salonaddress" class="btn btn-primary" />
	      
	           
	      
	           </pre> </div>
    			</div>
    		</div>
           </div>

                        <div class="row justify-content-center">
    			<div class="col-md-10 ftco-animate">
    				
	            <div class="row">
	              <div class="col-sm-6">
	                <div class="form-group">
                        <input id="salonStreet" type="text" runat="server" placeholder="Enter Salon Street"  class="form-control">
			            <div id="salonStreetDisplay" runat="server" style="color:lightseagreen; text-align:left"></div>
                        </div>
	              </div>
                      <span></span>
         		          <div class="form-group">
                  <pre><asp:Button ID="Button9" runat="server" Text="Update Salon Street" OnClick="salonstreet" class="btn btn-primary" />
	      
	           
	      
	           </pre> </div>
    			</div>
    		</div>
           </div>

                                    <div class="row justify-content-center">
    			<div class="col-md-10 ftco-animate">
    				
	            <div class="row">
	              <div class="col-sm-6">
	                <div class="form-group">
                        <input id="salonPostalCode" type="text" runat="server" placeholder="Enter Salon PostalCode"  class="form-control">
			            <div id="salonpostalCodeDisplay" runat="server" style="color:lightseagreen; text-align:left"></div>
                        </div>
	              </div>
                      <span></span>
         		          <div class="form-group">
                  <pre><asp:Button ID="Button10" runat="server" Text="Enter New Address" OnClick="salonpostalcode" class="btn btn-primary" />
	      
	           
	      
	           </pre> </div>
    			</div>
    		</div>
           </div>
          </div>
        </div>

             <!--Adding a Hairstyle-->
            <div class="container ftco-relative">
    		<div class="row justify-content-center pb-3">
          <div class="col-md-10 heading-section text-center ftco-animate">
            <h2 class="mb-4">Add Hairstyle</h2>
                  <input id="name" type="text" runat="server" class="form-control" placeholder="Enter Style Name"/>
               <br />
            <input id="price" type="text" runat="server" class="form-control" placeholder="Enter Style Price" />
            <br />
              <asp:FileUpload ID="FileUpload1" runat="server" class="form-control"  />
    <br />
              <asp:Button ID="uploadHairProduct" runat="server" Text="Upload Image" class="btn btn-primary" OnClick="upload" />
    <br />
              <br />
    <asp:Image ID="Image1" runat="server" Height = "500" Width = "500"  />
              <br />
                <div id="showImage" runat="server" class="team text-center"></div>
    <br />
               <asp:Button runat="server" Text="Add Hairstyle" OnClick="Add_Click" class="btn btn-primary"/>
    <br />
              </div>
            
            </div>
                    </div>

             <!--Adding HairProducts-->
               <div class="container ftco-relative">
    		<div class="row justify-content-center pb-3">
          <div class="col-md-10 heading-section text-center ftco-animate">
            <h2 class="mb-4">Add Hair Product</h2>
                  <input id="productname" type="text" runat="server" class="form-control" placeholder="Enter Product Name"/>
               <br />
            <input id="productprice" type="text" runat="server" class="form-control" placeholder="Enter Product Price" />
            <br />
               <br />
            <input id="description" type="text" runat="server" class="form-control" placeholder="product Description" />
            <br />
              <asp:FileUpload ID="FileUpload2" runat="server" class="form-control"  />
    <br />
              <asp:Button ID="Button13" runat="server" Text="Upload Image" class="btn btn-primary" OnClick="uploadProduct" />
    <br />
              <br />
    <asp:Image ID="Image2" runat="server" Height = "500" Width = "500"  />
              <br />
                <div id="showImage1" runat="server" ></div>
    <br />
               <asp:Button runat="server" Text="Add Hair Product" OnClick="AddProduct_Click" class="btn btn-primary"/>
                <div id="available" runat="server"></div>
    <br />
              <br />
               <asp:Button ID="Button14" runat="server" Text="View Hairstyles" OnClick="ViewStyle_Click" class="btn btn-primary" />
              </div>
            
            <!----/div>
                  <!---  </div>--->

             <br />
            
             <div id="showHairstyles" runat="server">

             <br/>
                 <asp:Button ID="Button12" runat="server" Text="View Bookings" OnClick="ViewBookings_Click" class="btn btn-primary" />
              </div>
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

     
             <br />
            
             <div id="showBookings" runat="server">
             </div>
    </section>
    


</asp:Content>
