<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="Admin_Home.aspx.cs" Inherits="project.View.Admin.Admin_Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br />
    <h3>List Of Artist</h3>
    <br />

    <asp:GridView ID="Admin_GridView" runat="server" AutoGenerateColumns="False" OnRowDeleting="Admin_GridView_RowDeleting" OnRowEditing="Admin_GridView_RowEditing" OnSelectedIndexChanging="Admin_GridView_SelectedIndexChanging">
        <Columns>
            <asp:BoundField DataField="ArtistID" HeaderText="Artist_ID" SortExpression="ArtistID" />
            <asp:BoundField DataField="ArtistName" HeaderText="Artist_Name" SortExpression="ArtistName" />
            <asp:ImageField DataImageUrlField="ArtistImage" ControlStyle-Width="100px" ControlStyle-Height="100px" HeaderText="Artist_Image">
<ControlStyle Height="100px" Width="100px"></ControlStyle>
            </asp:ImageField>
            <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            <asp:CommandField ButtonType="Button" HeaderText="Select" ShowHeader="True" ShowSelectButton="True" />
        </Columns>

    </asp:GridView>

    <br />

    <asp:Button ID="insrt_artist" runat="server" Text="Insert Artist" onClick="insrt_artist_Click"/>
</asp:Content>
