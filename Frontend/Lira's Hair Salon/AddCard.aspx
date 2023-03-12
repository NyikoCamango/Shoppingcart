<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddCard.aspx.cs" Inherits="LaTeamFrontEnd.AddCard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <div class="page-header">
            <h1>Credit Card Payment Form</h1>
        </div>

        <!-- Credit Card Payment Form - START -->

        <div class="container">
            <div class="row">
                <div class="col-xs-12 col-md-4 col-md-offset-4">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <div class="row">
                                <h3 class="text-center">Payment Details</h3>
                                <img class="img-responsive cc-img" src="http://www.prepbootstrap.com/Content/images/shared/misc/creditcardicons.png">
                            </div>
                        </div>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-xs-12">
                                    <div class="form-group">
                                        <label>CARD NUMBER</label>
                                        <div class="input-group">
                                            <input type="tel" name="card_number" id="card_num" class="form-control" placeholder="Valid Card Number" required
                                                onfocus="this.placeholder=''" onblur="this.placeholder='Card Number'" runat="server" />
                                            <span class="input-group-addon"><span class="fa fa-credit-card"></span></span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-7 col-md-7">
                                    <div class="form-group">
                                        <label><span class="hidden-xs">EXPIRATION</span><span class="visible-xs-inline">EXP</span> DATE</label>
                                        <input type="tel" name="expiration" id="exp_date" class="form-control" placeholder="MM / YY" required
                                            onfocus="this.placeholder=''" onblur="this.placeholder='MM / YY'" runat="server" />
                                    </div>
                                </div>
                                <div class="col-xs-5 col-md-5 pull-right">
                                    <div class="form-group">
                                        <label>CV CODE</label>
                                        <input type="tel" name="cv_code" id="cvv" class="form-control" placeholder="CVC" required
                                            onfocus="this.placeholder=''" onblur="this.placeholder='CVC'" runat="server" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-12">
                                    <div class="form-group">
                                        <label>CARD OWNER</label>
                                        <input type="text" name="card_owner" id="card_owner" class="form-control" placeholder="Card Owner Names"
                                            onfocus="this.placeholder=''" onblur="this.placeholder='Name of Owner'" runat="server" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="panel-footer">
                            <div class="row">
                                <div class="col-xs-12">
                                    <asp:Button ID="btn_addCard" runat="server" Text="Save Card" class="btn btn-warning btn-lg btn-block" OnClick="Add_Click" />
                                </div>
                                <div class="col-xs-12">
                                    <asp:Label ID="error" runat="server" Text="" Visible="false"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <style>
            .cc-img {
                margin: 0 auto;
            }
        </style>
        <!-- Credit Card Payment Form - END -->

    </div>
</asp:Content>
