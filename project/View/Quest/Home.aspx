<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="project.View.Quest.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>List of Artist</h1>
    <asp:GridView ID="Quest_GridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanging="Quest_GridView_SelectedIndexChanging">
        <Columns>
            <asp:BoundField DataField="ArtistID" HeaderText="Artist_ID" SortExpression="ArtistID" />
            <asp:BoundField DataField="ArtistName" HeaderText="Artist_Name" SortExpression="Artist_Name" />
            <asp:ImageField DataImageUrlField="ArtistImage" HeaderText="Artist_Image">
                <ControlStyle Height="100px" Width="100px"></ControlStyle>
            </asp:ImageField>
            <asp:CommandField ButtonType="Button" HeaderText="Select" ShowHeader="True" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>

    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>
