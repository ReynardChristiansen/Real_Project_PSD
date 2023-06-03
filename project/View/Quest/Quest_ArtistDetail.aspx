<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="Quest_ArtistDetail.aspx.cs" Inherits="project.View.Quest.Quest_ArtistDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>List Of Artist</h3>
    <asp:GridView ID="Quest_GridView_ArtistDetail" runat="server" AutoGenerateColumns="False">
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

    <asp:GridView ID="Quest_GridView_Album" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:ImageField DataImageUrlField="AlbumImage" HeaderText="Album_Image">
                <ControlStyle Height="100px" Width="100px"></ControlStyle>
            </asp:ImageField>
            <asp:BoundField DataField="AlbumName" HeaderText="Album_Name" SortExpression="AlbumName" />
            <asp:BoundField DataField="AlbumPrice" HeaderText="Album_Price" SortExpression="AlbumPrice" />
            <asp:BoundField DataField="AlbumStock" HeaderText="Album_Stock" SortExpression="AlbumStock" />
            <asp:BoundField DataField="AlbumDescription" HeaderText="Album_Description" SortExpression="AlbumDescription" />
        </Columns>
    </asp:GridView>
</asp:Content>
