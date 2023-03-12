<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="NewLateamFrontEnd.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="hero-wrap js-fullheight" style="background-image: url(images/salon2.jpg);" data-stellar-background-ratio="0.5">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight justify-content-center align-items-center">
          <div class="col-lg-12 ftco-animate d-flex align-items-center">
          	<div class="text text-center">
          		<span class="subheading">Welcome to Lira's Hair Salon</span>
		  				<h1 class="mb-4">We are professional care for your hair</h1>
		  				<p id="first" runat="server"><a href="Login.aspx" class="btn btn-primary btn-outline-primary px-4 py-2">Book now</a></p>
				  	  				<p id="second" runat="server"><a href="MyStylist.aspx" class="btn btn-primary btn-outline-primary px-4 py-2">Book now</a></p>
				  <asp:Button ID="stylistReg" runat="server"  Text="Become a Stylist" class="btn btn-primary btn-outline-primary px-4 py-2"  OnClick="stylistReg_Click" />
	
							</div>
            </div>
          </div>
        </div>

    </section>
		
		<section class="ftco-section ftco-no-pt ftco-no-pb">
			<div class="container-fluid px-0">
				<div class="row no-gutters">
					<div class="col-md text-center d-flex align-items-stretch">
						<div class="services-wrap d-flex align-items-center img" style="background-image: url(images/men2.jpg);">
							<div class="text">
								<h3>For Men</h3>
								<p><a href="#" class="btn-custom">See pricing <span class="ion-ios-arrow-round-forward"></span></a></p>
							</div>
						</div>
					</div>
					<div class="col-md-3 text-center d-flex align-items-stretch">
						<div class="text-about py-5 px-4">
							<h1 class="logo">
								<a href="#"><span class="flaticon-scissors-in-a-hair-salon-badge"></span>Lira's Hair</a>
							</h1>
							<h2>Welcome to our Salon</h2>
							<p>As we know that a salon is a great necessity for both genders and we do a lot of things there ranging from something as small as shaping your brows to getting a haircut, styling your hair in various ways. As people we get busy and to go the salon and wait long until your turn comes is a lot of work and a waste of time. With the trying times that we are currently facing as the world with COVID-19 as our "new norm" we need to have a few human interactions. Also, there is a gap with knowing what exactly to do when you get to the salon because most of salons do not have platforms where they showcase their work so that they can attract more customers and for them to know what they will do when they get to the salon and the price that they are willing to pay for the service that they want.</p>
							<p class="mt-3"><a href="About.aspx" class="btn btn-primary btn-outline-primary">Read more</a></p>
						</div>
					</div>
					<div class="col-md text-center d-flex align-items-stretch">
						<div class="services-wrap d-flex align-items-center img" style="background-image: url(images/w5.jpg);">
							<div class="text">
								<h3>For Women</h3>
								<p><a href="#" class="btn-custom">See pricing <span class="ion-ios-arrow-round-forward"></span></a></p>
							</div>
						</div>
					</div>
				</div>
			</div>
		</section>
    
    <section class="services-section ftco-section">
      <div class="container">
      	<div class="row justify-content-center pb-3">
          <div class="col-md-10 heading-section text-center ftco-animate">
          	<span class="subheading">Services</span>
            <h2 class="mb-4">Services And Product Menu</h2>
            <p>Best Quality Affordable Service,best hair products</p>
          </div>
        </div>
        <div class="row no-gutters d-flex">
          <div class="col-md-6 col-lg-3 d-flex align-self-stretch ftco-animate">
            <div class="media block-6 services d-block text-center">
              <div class="icon"><span class="flaticon-male-hair-of-head-and-face-shapes"></span></div>
              <div class="media-body">
                <h3 class="heading mb-3">Haircut &amp; Styling</h3>
                <p>We have stylists for both Men and Women.</p>
              </div>
            </div>    
          </div>
          <div class="col-md-6 col-lg-3 d-flex align-self-stretch ftco-animate">
            <div class="media block-6 services d-block text-center">
              <div class="icon"><span class="flaticon-beard"></span></div>
              <div class="media-body">
                <h3 class="heading mb-3">Beard</h3>
                <p>Let us take care of your charms, a fresh clean beard is a real confidence booster.</p>
              </div>
            </div>      
          </div>
          <div class="col-md-6 col-lg-3 d-flex align-self-stretch ftco-animate">
            <div class="media block-6 services d-block text-center">
              <div class="icon"><span class="flaticon-beauty-products"></span></div>
              <div class="media-body">
                <h3 class="heading mb-3">Hair Products</h3>
                <p>We have the best hair products at an Amzing low price.</p>
              </div>
            </div>      
          </div>
          <div class="col-md-6 col-lg-3 d-flex align-self-stretch ftco-animate">
            <div class="media block-6 services d-block text-center">
              <div class="icon"><span class="flaticon-healthy-lifestyle-logo"></span></div>
              <div class="media-body">
                <h3 class="heading mb-3">Body Treatment</h3>
                <p>A small river named Duden flows by their place and supplies.</p>
              </div>
            </div>      
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

	              <input type="submit" value="Make an Appointment" class="btn btn-primary">
	            </div>
	    
    		
    		</div>
    	</div>
    </section>
	
			  <div id="showImage" runat="server" class="team text-center"></div>

    
    <section class="ftco-section ftco-no-pt ftco-no-pb">
    	<div class="container">
    		<div class="row no-gutters justify-content-center mb-5 pb-2">
          <div class="col-md-6 text-center heading-section ftco-animate">
          	<span class="subheading">Gallery</span>
            <h2 class="mb-4">Our gallery</h2>
            <p>Separated they live in. A small river named Duden flows by their place and supplies it with the necessary regelialia.</p>
          </div>
        </div>
    	</div>
			<div class="container-fluid p-0">
    		<div class="row no-gutters">
    			<div class="col-md-6 col-lg-3 ftco-animate">
    				<div class="project">
	    				<img src="images/work-1.jpg" class="img-fluid" alt="Colorlib Template">
	    				<div class="text">
	    					<span>Stylist</span>
	    					<h3><a href="project.html">Beard</a></h3>
	    				</div>
	    				<a href="images/work-1.jpg" class="icon image-popup d-flex justify-content-center align-items-center">
	    					<span class="icon-expand"></span>
	    				</a>
    				</div>
    			</div>
    			<div class="col-md-6 col-lg-3 ftco-animate">
    				<div class="project">
	    				<img src="images/work-2.jpg" class="img-fluid" alt="Colorlib Template">
	    				<div class="text">
	    					<span>Beauty</span>
	    					<h3><a href="project.html">Haircut</a></h3>
	    				</div>
	    				<a href="images/work-2.jpg" class="icon image-popup d-flex justify-content-center align-items-center">
	    					<span class="icon-expand"></span>
	    				</a>
    				</div>
    			</div>
    			<div class="col-md-6 col-lg-3 ftco-animate">
    				<div class="project">
	    				<img src="images/work-3.jpg" class="img-fluid" alt="Colorlib Template">
	    				<div class="text">
	    					<span>Beauty</span>
	    					<h3><a href="project.html">Hairstylist</a></h3>
	    				</div>
	    				<a href="images/work-3.jpg" class="icon image-popup d-flex justify-content-center align-items-center">
	    					<span class="icon-expand"></span>
	    				</a>
    				</div>
    			</div>
    			<div class="col-md-6 col-lg-3 ftco-animate">
    				<div class="project">
	    				<img src="images/work-4.jpg" class="img-fluid" alt="Colorlib Template">
	    				<div class="text">
	    					<span>Beauty</span>
	    					<h3><a href="project.html">Haircut</a></h3>
	    				</div>
	    				<a href="images/work-4.jpg" class="icon image-popup d-flex justify-content-center align-items-center">
	    					<span class="icon-expand"></span>
	    				</a>
    				</div>
    			</div>
    			<div class="col-md-6 col-lg-3 ftco-animate">
    				<div class="project">
	    				<img src="images/work-5.jpg" class="img-fluid" alt="Colorlib Template">
	    				<div class="text">
	    					<span>Beauty</span>
	    					<h3><a href="project.html">Makeup</a></h3>
	    				</div>
	    				<a href="images/work-5.jpg" class="icon image-popup d-flex justify-content-center align-items-center">
	    					<span class="icon-expand"></span>
	    				</a>
    				</div>
    			</div>
    			<div class="col-md-6 col-lg-3 ftco-animate">
    				<div class="project">
	    				<img src="images/work-6.jpg" class="img-fluid" alt="Colorlib Template">
	    				<div class="text">
	    					<span>Fashion</span>
	    					<h3><a href="project.html">Model</a></h3>
	    				</div>
	    				<a href="images/work-6.jpg" class="icon image-popup d-flex justify-content-center align-items-center">
	    					<span class="icon-expand"></span>
	    				</a>
    				</div>
    			</div>
    			<div class="col-md-6 col-lg-3 ftco-animate">
    				<div class="project">
	    				<img src="images/work-7.jpg" class="img-fluid" alt="Colorlib Template">
	    				<div class="text">
	    					<span>Beauty</span>
	    					<h3><a href="project.html">Makeup</a></h3>
	    				</div>
	    				<a href="images/work-7.jpg" class="icon image-popup d-flex justify-content-center align-items-center">
	    					<span class="icon-expand"></span>
	    				</a>
    				</div>
    			</div>
    			<div class="col-md-6 col-lg-3 ftco-animate">
    				<div class="project">
	    				<img src="images/work-8.jpg" class="img-fluid" alt="Colorlib Template">
	    				<div class="text">
	    					<span>Beauty</span>
	    					<h3><a href="project.html">Makeup</a></h3>
	    				</div>
	    				<a href="images/work-8.jpg" class="icon image-popup d-flex justify-content-center align-items-center">
	    					<span class="icon-expand"></span>
	    				</a>
    				</div>
    			</div>
    		</div>
    	</div>
		</section>
		<br>
		
		<section class="testimony-section bg-light">
      <div class="container">
        <div class="row ftco-animate justify-content-center">
        	<div class="col-md-6 col-lg-5 d-flex">
        		<div class="testimony-img" style="background-image: url(images/testimony-img.jpg);"></div>
        	</div>
          <div class="col-md-6 col-lg-7 py-5 pl-md-5">
          	<div class="py-md-5">
	          	<div class="heading-section ftco-animate">
	          		<span class="subheading">Testimony</span>
			          <h2 class="mb-0">Happy Customer</h2>
			        </div>
	            <div class="carousel-testimony owl-carousel ftco-animate">
	              <div class="item">
	                <div class="testimony-wrap pb-4">
	                  <div class="text">
	                    <p class="mb-4">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
	                  </div>
	                  <div class="d-flex">
		                  <div class="user-img" style="background-image: url(images/stylist-1.jpg)">
		                  </div>
		                  <div class="pos ml-3">
		                  	<p class="name">Jeff Nucci</p>
		                    <span class="position">Businessman</span>
		                  </div>
		                </div>
	                </div>
	              </div>
	              <div class="item">
	                <div class="testimony-wrap pb-4">
	                  <div class="text">
	                    <p class="mb-4">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
	                  </div>
	                  <div class="d-flex">
		                  <div class="user-img" style="background-image: url(images/stylist-2.jpg)">
		                  </div>
		                  <div class="pos ml-3">
		                  	<p class="name">Jeff Nucci</p>
		                    <span class="position">Businessman</span>
		                  </div>
		                </div>
	                </div>
	              </div>
	              <div class="item">
	                <div class="testimony-wrap pb-4">
	                  <div class="text">
	                    <p class="mb-4">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
	                  </div>
	                  <div class="d-flex">
		                  <div class="user-img" style="background-image: url(images/stylist-3.jpg)">
		                  </div>
		                  <div class="pos ml-3">
		                  	<p class="name">Jeff Nucci</p>
		                    <span class="position">Businessman</span>
		                  </div>
		                </div>
	                </div>
	              </div>
	              <div class="item">
	                <div class="testimony-wrap pb-4">
	                  <div class="text">
	                    <p class="mb-4">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
	                  </div>
	                  <div class="d-flex">
		                  <div class="user-img" style="background-image: url(images/stylist-4.jpg)">
		                  </div>
		                  <div class="pos ml-3">
		                  	<p class="name">Jeff Nucci</p>
		                    <span class="position">Businessman</span>
		                  </div>
		                </div>
	                </div>
	              </div>
	              <div class="item">
	                <div class="testimony-wrap pb-4">
	                  <div class="text">
	                    <p class="mb-4">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
	                  </div>
	                  <div class="d-flex">
		                  <div class="user-img" style="background-image: url(images/stylist-5.jpg)">
		                  </div>
		                  <div class="pos ml-3">
		                  	<p class="name">Jeff Nucci</p>
		                    <span class="position">Businessman</span>
		                  </div>
		                </div>
	                </div>
	              </div>
	            </div>
	          </div>
          </div>
        </div>
      </div>
    </section>
<br>


</asp:Content>
