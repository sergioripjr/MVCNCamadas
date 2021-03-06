<%@ Page Title="" Language="C#" 
MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<NorthwindApp.Domain.Category>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit</h2>

    <%= Html.ValidationSummary("Edit was unsuccessful. Please correct the errors and try again.") %>

    <% using (Html.BeginForm()) {%>

        <% =Html.AntiForgeryToken() %>
        <fieldset>
            <legend>Fields</legend>
            <p>
                <label for="Id">Id:</label>
                <%= Html.Encode(Model.Identificador)%>
                <%= Html.Hidden("Identificador", Model.Identificador)%>
            </p>
            <p>
                <label for="CategoryName">CategoryName:</label>
                <%= Html.TextBox("CategoryName", Model.CategoryName) %>
                <%= Html.ValidationMessage("CategoryName", "*") %>
            </p>
            <p>
                <label for="Description">Description:</label>
                <%= Html.TextBox("Description", Model.Description) %>
                <%= Html.ValidationMessage("Description", "*") %>
            </p>
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%=Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

