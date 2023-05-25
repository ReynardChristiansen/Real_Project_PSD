<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="Admin_Home.aspx.cs" Inherits="project.View.Admin.Admin_Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br />

    <asp:GridView ID="Admin_GridView" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="ArtistName" HeaderText="Artist_Name" SortExpression="ArtistName" />
            <asp:ImageField DataImageUrlField="ArtistImage" HeaderText="Artist_Image">
            </asp:ImageField>
        </Columns>

    </asp:GridView>

    <br />

    <asp:Button ID="insrt_artist" runat="server" Text="Insert Artist" onClick="insrt_artist_Click"/>
</asp:Content>
