<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NorthwindApp.Domain.Category>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
        <p>
            Id:
            <%= Html.Encode(Model.Identificador)%>
        </p>
        <p>
            CategoryName:
            <%= Html.Encode(Model.CategoryName) %>
        </p>
        <p>
            Description:
            <%= Html.Encode(Model.Description) %>
        </p>
    </fieldset>
    <p>

        <%=Html.ActionLink("Edit", "Edit", new { id=Model.Identificador }) %> |
        <%=Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

