<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="LaTeamFrontEnd.Feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="imagebg"></div>
        <div class="row " style="margin-top: 50px">
            <div class="col-md-6 col-md-offset-3 form-container">
                <h2>Feedback</h2>
                <p>Please provide your feedback below: </p>
                <div class="row">
                    <div class="col-sm-12 form-group">
                        <label>What are you rating ?</label>
                        <p>
                            <label class="radio-inline">
                                <input type="radio" name="experience" id="salon_option" value="Salon">
                                Salon 
                                   
                            </label>
                            <label class="radio-inline">
                                <input type="radio" name="experience" id="style_option" value="Hairstyle">
                                Hairstyle 
                                   
                            </label>
                            <label class="radio-inline">
                                <input type="radio" name="experience" id="product_option" value="Hair Product">
                                Hair Product 
                                   
                            </label>
                        </p>
                    </div>
                </div>
                <!-- ------------------Personal Details---------------------------- -->
                <fieldset>
                    <!-- groups of widgets that share the same purpose, for styling and semantic purposes -->
                    <legend>Select the image for the item reviewed :</legend>
                    <div class="file-upload">
                        <button class="file-upload-btn" type="button" onclick="$('.file-upload-input').trigger( 'click' )">Add Image</button>

                        <div class="image-upload-wrap">
                            <input class="file-upload-input" type='file' onchange="readURL(this);" accept="image/*" />
                            <div class="drag-text">
                                <h3>Drag and drop a file or select add Image</h3>
                            </div>
                        </div>
                        <div class="file-upload-content">
                            <asp:Image id="image" class="file-upload-image" src="#" alt="your image" runat="server"/>
                            <div class="image-title-wrap">
                                <button type="button" onclick="removeUpload()" class="remove-image">Remove <span class="image-title">Uploaded Image</span></button>
                            </div>
                        </div>
                    </div>
                </fieldset>
                <fieldset>
                    <legend>Pleas rate the selected item :</legend>
                    <div class="rate">
                        <input type="radio" id="starS1" name="rate" value="1" runat="server"/>
                        <label for="starS1" title="text">1 star</label>
                        <input type="radio" id="starS2" name="rate" value="2" runat="server"/>
                        <label for="starS2" title="text">2 stars</label>
                        <input type="radio" id="starS3" name="rate" value="3" runat="server"/>
                        <label for="starS3" title="text">3 stars</label>
                        <input type="radio" id="starS4" name="rate" value="4" runat="server"/>
                        <label for="starS4" title="text">4 stars</label>
                        <input type="radio" id="starS5" name="rate" value="5" runat="server"/>
                        <label for="starS5" title="text">5 stars</label>
                    </div>
                </fieldset>
                <div class="row">
                    <div class="col-sm-12 form-group">
                        <label for="comments">Comments:</label>
                        <textarea class="form-control" name="comments" id="comments" placeholder="Your Comments" maxlength="6000" rows="7" runat="server"></textarea>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-12 form-group">
                        <asp:Button id="post" class="btn btn-lg btn-warning btn-block" Text="Post" OnClick="post_Click" runat="server"/>
                    </div>
                </div>
                <asp:Label id="success_message" style="width: 100%; height: 100%;" Visible="false" runat="server">
                </asp:Label>
                <asp:Label id="error_message" style="width: 100%; height: 100%;" Visible="false" runat="server">
                </asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
