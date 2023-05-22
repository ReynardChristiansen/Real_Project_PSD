<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="project.View.Quest.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>List of Artist</h1>

    <table style="width:500px" border="1">
        <tr>
            <td>Artis Image</td>
            <td>Artist Name</td>
        </tr>
    

    <% foreach(var x in Artists)
    { %>
        <tr>
            <td><%=x.ArtistName%></td>
        </tr>

    <%}%>


    </table>
</asp:Content>
