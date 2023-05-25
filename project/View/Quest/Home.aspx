<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="project.View.Quest.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>List of Artist di quest</h1>


    <asp:GridView ID="Quest_GridView" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="ArtistName" HeaderText="Artist_Name" SortExpression="ArtistName" />
            <asp:BoundField DataField="ArtistImage" HeaderText="Artist_Image" SortExpression="ArtistImage" />
        </Columns>

    </asp:GridView>
</asp:Content>
