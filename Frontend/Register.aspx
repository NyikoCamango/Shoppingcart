<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="NewLateamFrontEnd.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="hero-wrap hero-wrap-2" style="background-image: url('images/salon2.jpg');" data-stellar-background-ratio="0.5">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-end justify-content-center">
          <div class="col-md-9 ftco-animate pb-5 text-center">
            <h2 class="mb-0 bread">Register </h2>
            <p class="breadcrumbs"><span class="mr-2"><a href="index.html">Home <i class="ion-ios-arrow-round-forward"></i></a></span> <span>Register <i class="ion-ios-arrow-round-forward"></i></span></p>
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
            <h2 class="mb-4">Create Account</h2>

          </div>
        </div>
       
    		<div class="row justify-content-center">
    			<div class="col-md-10 ftco-animate">
    			
	            <div class="row">
	              <div class="col-sm-6">
	                <div class="form-group">
			              <input type="text" runat="server" class="form-control" id="FirstName" placeholder="First Name">
			            </div>
	              </div>
	              <div class="col-sm-6">
	                <div class="form-group">
			              <input type="text" runat="server" class="form-control" id="LastName" placeholder="Last Name">
			            </div>
	              </div>
                    	              <div class="col-sm-6">
	                <div class="form-group">
			              <input type="text" runat="server" class="form-control" id="Email" placeholder="Email">
			            </div>
	              </div>
                    	              <div class="col-sm-6">
	                <div class="form-group">
			              <input type="text" runat="server" class="form-control" id="Phone" placeholder="Phone Number">
			            </div>
	              </div>

						              <div class="col-sm-6">
	                <div class="form-group">
			              <input type="text" runat="server" class="form-control" id="Address" placeholder="Address">
			            </div>
	              </div>
						              <div class="col-sm-6">
	                <div class="form-group">
			              <input type="text" runat="server" class="form-control" id="City" placeholder="City">
			            </div>
	              </div>
						              <div class="col-sm-6">
	                <div class="form-group">
			              <input type="text" runat="server" class="form-control" id="Code" placeholder="Code">
			            </div>
	              </div>
						              <div class="col-sm-6">
	                <div class="form-group">
			              <input type="text" class="form-control" runat="server" id="UserName" placeholder="User Name">
			            </div>
	              </div>
						              <div class="col-sm-6">
	                <div class="form-group">
			              <input type="password" class="form-control" runat="server" id="Password" placeholder="Password">
			            </div>
	              </div>
						              <div class="col-sm-6">
	                <div class="form-group">
			              <input type="password" runat="server" class="form-control" id="ConfPassword" placeholder="Confirm Password">
			            </div>
	              </div>
	              <div class="form-group">
                      <asp:Button ID="Button1" runat="server" Text="Create Account" class="btn btn-primary" OnClick="CreateAccount" />
					  <br />
					  <div id="results" runat="server"></div>
					  <br />
					  <a href="Login.aspx">Already Have an Account? Login now</a>
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
