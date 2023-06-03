<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="Admin_UpdateAlbum.aspx.cs" Inherits="project.View.Admin.Admin_UpdateAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h3>Update Album</h3>
    <br />

    <asp:Label ID="lbl_Name" runat="server" Text="Album Name"></asp:Label>
    <asp:TextBox ID="txt_Name" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="lbl_Desc" runat="server" Text="Album Desc"></asp:Label>
    <asp:TextBox ID="txt_Desc" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="lbl_Price" runat="server" Text="Album Price"></asp:Label>
    <asp:TextBox ID="txt_Price" runat="server" TextMode="Number"></asp:TextBox>
    <br />


    <asp:Label ID="lbl_Stock" runat="server" Text="Album Stock"></asp:Label>
    <asp:TextBox ID="txt_Stock" runat="server" TextMode="Number"></asp:TextBox>
    <br />

    <asp:Label ID="lbl_Image" runat="server" Text="Label"></asp:Label>
    <asp:FileUpload ID="ImageUpload" runat="server" />

    <br />
    <asp:Label ID="lbl_Error" runat="server" Text=""></asp:Label>
    <br />

    <asp:Button ID="btn_UpdateAlbum" runat="server" Text="Update Album" onClick="btn_UpdateAlbum_Click"/>
</asp:Content>
