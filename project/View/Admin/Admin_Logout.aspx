<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="Admin_Logout.aspx.cs" Inherits="project.View.Admin.Admin_Logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    are you sure want to log out?
    <asp:Button ID="yes" runat="server" Text="Yes" onClick="yes_Click"/>
    <asp:Button ID="no" runat="server" Text="No" onClick="no_Click"/>
</asp:Content>
