<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="Admin_InsertArtist.aspx.cs" Inherits="project.View.Admin.Admin_InsertArtist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />

    <br />
    <asp:Label ID="lbl_ArtistName" runat="server" Text="Artist Name"></asp:Label>
    <asp:TextBox ID="txt_ArtistName" runat="server"></asp:TextBox>

    <br />

    <asp:Label ID="lbl_ArtistImage" runat="server" Text="Artist Image"></asp:Label>
    <asp:FileUpload ID="ImageUpload" runat="server" />

    <br />

    <asp:Label ID="lbl_Error" runat="server" Text=""></asp:Label>

    <br />

    <asp:Button ID="Button1" runat="server" Text="Submit" onClick="Button1_Click"/>
</asp:Content>
