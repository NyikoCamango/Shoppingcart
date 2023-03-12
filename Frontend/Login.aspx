<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NewLateamFrontEnd.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="hero-wrap hero-wrap-2" style="background-image: url('images/salon2.jpg');" data-stellar-background-ratio="0.5">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-end justify-content-center">
          <div class="col-md-9 ftco-animate pb-5 text-center">
            <h2 class="mb-0 bread">Login </h2>
            <p class="breadcrumbs"><span class="mr-2"><a href="index.html">Home <i class="ion-ios-arrow-round-forward"></i></a></span> <span>Login <i class="ion-ios-arrow-round-forward"></i></span></p>
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
            <h2 class="mb-4">Sign In</h2>

          </div>
        </div>
       
    		<div class="row justify-content-center">
    			<div class="col-md-10 ftco-animate">
    				
	            <div class="row">
	              <div class="col-sm-6">
	                <div class="form-group">
                        <input id="userName" type="text" runat="server" placeholder="UserName"  class="form-control">
			            </div>
	              </div>
	              <div class="col-sm-6">
	                <div class="form-group">
			              <input type="password" runat="server" class="form-control" id="password" placeholder="Password">
			                               <br />
	            <div id="status" runat="server" style="color:red; text-align:left"></div>
                    <br />
                    </div>
	              </div>
	              <div class="col-sm-6">
	                <div class="form-group">
	                </div>    
	              </div>
	              <div class="col-sm-6">
	                <div class="form-group">
	                </div>
	              </div>
                       <span></span>
                      <span></span>
         		          <div class="form-group">
                  <pre><asp:Button ID="Button1" runat="server" Text="Login" OnClick="SignIn" class="btn btn-primary" />
	       
	           
	       
	           
	       
	           
	       
	           </pre> </div>
                                <br />
            <a href="ForgotPassword.aspx">forgot Password?</a>
            <br />
            <a href="Register.aspx">Create Account</a>
            <br />
    			</div>
    		</div>
    	</div>
    </section>
     
          </div>
        </div>
      </div>
    </section>
</asp:Content>
