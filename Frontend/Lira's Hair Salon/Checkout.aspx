<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="LaTeamFrontEnd.Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class='container'>
        <div class='window'>
            <div class='order-info'>
                <div class='order-info-content'>
                    <h2>Order Summary</h2>
                    <div id="orderedItems" runat="server">

                    </div>
                    <div class='total'>
                        <span style='float: left;'>
                            <div class='thin dense'>VAT 19%</div>
                            <div class='thin dense'>Delivery</div>
                            TOTAL
                        </span>
                        <span style='float: right; text-align: right;' id="total" runat="server">
                            <div class='thin dense' id="vat" runat="server"></div>
                            <div class='thin dense' id="delivery" runat="server"></div>
                        </span>
                    </div>
                </div>
            </div>
            <div class='credit-info'>
                <div class='credit-info-content'>
                    <table class='half-input-table'>
                        <tr>
                            <td>Please select your card: </td>
                            <td>
                                <div class='dropdown' id='card-dropdown'>
                                    <div class='dropdown-btn' id='current-card'>Visa</div>
                                    <div class='dropdown-select'>
                                        <ul>
                                            <li>Master Card</li>
                                            <li>American Express</li>
                                        </ul>
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </table>
                    <img src='https://dl.dropboxusercontent.com/s/ubamyu6mzov5c80/visa_logo%20%281%29.png' height='80' class='credit-card-image' id='credit-card-image'/>
                    Card Number
                    <input class='input-field' name="card_number" id="card_num" readonly="readonly" onfocus="this.placeholder=''" onblur="this.placeholder='Card Number'" runat="server"/>
                    Card Holder
                    <input class='input-field' name="card_name" id="card_name" readonly="readonly" onfocus="this.placeholder=''" onblur="this.placeholder='Card Holder'" runat="server"/>
                    <table class='half-input-table'>
                        <tr>
                            <td>Expires
                                <input class='input-field' name="expiry_date" id="exp_date" readonly="readonly" onfocus="this.placeholder=''" onblur="this.placeholder='MM / YY'" 
                                    runat="server"/>
                            </td>
                            <td>CVC
                                <input class='input-field' name="cvc" id="cvv" readonly="readonly" onfocus="this.placeholder=''" onblur="this.placeholder='CVV'" runat="server"/>
                            </td>
                        </tr>
                    </table>
                    <asp:Button ID="btn_checkout" Text="Confirm Purchase" runat="server" class='pay-btn' OnClick="checkout_Click"/>
                    <asp:Label ID="error" Text="" Visible="false" runat="server"></asp:Label>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
