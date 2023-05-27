<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="Admin_UpdateArtist.aspx.cs" Inherits="project.View.Admin.Admin_UpdateArtist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h3>Update Artist</h3>
    <br />
    <asp:Label ID="lbl_ArtistName" runat="server" Text="Artist Name"></asp:Label>
    <asp:TextBox ID="txt_ArtistName" runat="server"></asp:TextBox>

    <br />
    <asp:Label ID="lbl_ArtistImage" runat="server" Text="Artist Image"></asp:Label>
    <asp:Image ID="ImageTobeUpdated" runat="server" Height="100" Width="100" />
    <asp:FileUpload ID="ImageUpload" runat="server" />

    <br />
    <asp:Label ID="lbl_Error" runat="server" Text=""></asp:Label>

    <br />
    <asp:Button ID="submit_update" runat="server" Text="Update" onClick="submit_update_Click"/>
</asp:Content>
