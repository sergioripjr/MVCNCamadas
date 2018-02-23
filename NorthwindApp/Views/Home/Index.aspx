<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%= Html.Encode(ViewData["Message"]) %></h2>
    <h3>
        <%= Html.ActionLink("Minhas categorias", "Index", "Categories")%><br />
        <%= Html.ActionLink("Meus produtos", "Index", "Products")%>
    </h3>
</asp:Content>
