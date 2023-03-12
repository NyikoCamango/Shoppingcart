<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Manager1.aspx.cs" Inherits="NewLateamFrontEnd.Manager1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <section class="hero-wrap hero-wrap-2" style="background-image: url('images/salon2.jpg');",  data-stellar-background-ratio="0.5">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-end justify-content-center">
          <div class="col-md-9 ftco-animate pb-5 text-center">
           
            <h2 class="mb-0 bread">Manager Dashboard </h2>
            <p class="breadcrumbs"><span class="mr-2"><a href="index.html">Home <i class="ion-ios-arrow-round-forward"></i></a></span> <span>Manager Dashboard<i class="ion-ios-arrow-round-forward"></i></span></p>
          </div>
        </div>
      </div>
    </section>

           <section class="ftco-section ftco-booking bg-light">
             
                <div id="edit" runat="server" visible="false">
    	<div class="container ftco-relative">
    		<div class="row justify-content-center pb-3">
          <div class="col-md-10 heading-section text-center ftco-animate">         
              </div>
                </div>
          </div>
        </div>
    		<div class="row justify-content-center">
    			<div class="col-md-10 ftco-animate">
    				
	            <div class="row">
	              <div class="col-sm-6">
	                <div class="form-group">
                            </div>
                      </div>
                    </div>
                    </div>
                </div>
                       </section>

    <asp:Button ID="Button1" runat="server" Text="Edit Profile" OnClick="edit_Click" />
    <br />
    <div id="myProfile" runat="server" visible="false">
        <br />
            <input id="username" type="text" placeholder="Username" runat="server"/>
            <asp:Button ID="uname" runat="server" Text="Edit User Name" OnClick="uname_Click" Height="23px" />
            <br />
            <div id="results"  runat="server"></div>
        </div>
        <div>
            <br />
            <input id="password" type="password" placeholder="Enter new Password" runat="server"/>
            <asp:Button ID="pass" runat="server" Text="Edit Password" OnClick="passWord" />
            <br />
            <div id="Div2"  runat="server"></div>
        </div><div>
            <br />
            <input id="phone" type="text" placeholder="Enter new Phone Number" runat="server"/>
            <asp:Button ID="phoneN" runat="server" Text="Edit Phone Number" OnClick="EditphoneNumber" />
            <br />
            <div id="Div3"  runat="server"></div>
        </div>
            <br />
            <input id="Text2" type="text" placeholder="Enter New Address" runat="server"/>
            <asp:Button ID="add" runat="server" Text="Edit Address" OnClick="EditAddress" />
            <br />
            <div id="Div4"  runat="server"></div>
            <div>
            <br />
            <input id="Editemail" type="text" placeholder="Enter New Email" runat="server"/>
            <asp:Button ID="button" runat="server" Text="Edit Email" OnClick="EditEmail" />
            <br />
            <div id="Div5"  runat="server"></div>
        </div>

            <div>
            <asp:Button ID="users" runat="server" Text="View Customers" OnClick="users_Click" /></div>
            <div id="show" runat="server">
                <br />
 <h2>Customers</h2>

 <div id="displayUsers" runat="server">

                </div>
        
        </div>
            <br />
         
            <asp:Button ID="stylists" runat="server" Text="View Stylists" OnClick="Stylists_Click" />
             <h2>Stylists</h2>
<br />

 <div id="displayStylists" runat="server"></div>
     <br />
        <h2>Add Stylists</h2>
            <br />
            <input id="LastName" type="text" runat="server" placeholder="Last Name"/>  
            <br />
            <input id="Email" type="text" runat="server" placeholder="Email"/>  
            <br />
            <input id="phoneNumber" type="text" runat="server" placeholder="Phone Number"/>  
            <br />
            <input id="Address" type="text" runat="server" placeholder="Address"/>  
            <br />
             <asp:Button ID="addStylist" runat="server" Text="Add Stylist" OnClick="addStylist_Click1" />
            <br />
             <div id="stylist_Result" runat="server"></div>
                <br /> 

                <br />
        <input id="search" type="text" runat="server" placeholder="Enter User Email"/>  
            <br />
             <asp:Button ID="SearchU" runat="server" Text="Get User" OnClick="searchUser_Click" />
            <br />
            <div id="foundUser" runat="server"></div>
        <asp:Button ID="remove" runat="server" Text="Delete User" OnClick="remove_Click" />
        <br />
        <div id="removeStatus" runat="server"></div>
        <br />
        <br />
        <input id="Text1" type="text" runat="server" placeholder="Enter Email"/>
        <br />
        <div id="foundStylist" runat="server"></div>
        <br />
             <asp:Button ID="Button2" runat="server" Text="Get Stylist" OnClick="searchStylist_Click" />
            <br />
            <div id="Div1" runat="server"></div>
                <br />
                <asp:Button ID="deleteStylist" runat="server" Text="Delete Stylist" OnClick="deleteStylist_Click" />
                <div id="deleteStylist_Result" runat="server"></div>

</asp:Content>
