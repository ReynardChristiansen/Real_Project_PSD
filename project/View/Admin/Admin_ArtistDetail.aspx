<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="Admin_ArtistDetail.aspx.cs" Inherits="project.View.Admin.Admin_ArtistDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>List Of Artist</h3>

    <asp:GridView ID="Admin_GridView_ArtistDetail" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="ArtistID" HeaderText="Artist_ID" SortExpression="ArtistID" />
            <asp:BoundField DataField="ArtistName" HeaderText="Artist_Name" SortExpression="ArtistName" />
            <asp:ImageField DataImageUrlField="ArtistImage" HeaderText="Artist_Image">
                <ControlStyle Height="100px" Width="100px"></ControlStyle>
            </asp:ImageField>
        </Columns>
        
    </asp:GridView>

    <br />

    <h3>List of Album</h3>
    <br />

    <asp:GridView ID="Admin_GridView_Album" runat="server" AutoGenerateColumns="False" OnRowDeleting="Admin_GridView_Album_RowDeleting" OnRowEditing="Admin_GridView_Album_RowEditing">
        <Columns>
            <asp:BoundField DataField="AlbumID" HeaderText="Album_ID" SortExpression="AlbumName" />
            <asp:ImageField DataImageUrlField="AlbumImage" HeaderText="Album_Image">
                <ControlStyle Height="100px" Width="100px"></ControlStyle>
            </asp:ImageField>
            <asp:BoundField DataField="AlbumName" HeaderText="Album_Name" SortExpression="AlbumName" />
            <asp:BoundField DataField="AlbumPrice" HeaderText="Album_Price" SortExpression="AlbumPrice" />
            <asp:BoundField DataField="AlbumStock" HeaderText="Album_Stock" SortExpression="AlbumStock" />
            <asp:BoundField DataField="AlbumDescription" HeaderText="Album_Description" SortExpression="AlbumDescription" />
            <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>


    <br />

    <asp:Button ID="Button1" runat="server" Text="Insert Album" onClick="Button1_Click"/>

</asp:Content>
