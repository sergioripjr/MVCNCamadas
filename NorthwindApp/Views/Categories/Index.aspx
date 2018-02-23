<%@ Page Title="" Language="C#" 
MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<IEnumerable<NorthwindApp.Domain.Category>>" %>
<%@ Import Namespace="NorthwindApp.MVCExtensions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Id
            </th>
            <th>
                CategoryName
            </th>
            <th>
                Description
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%= Html.SafePostBackActionLink("Delete", "Delete", new { id = item.Identificador })%> |
                <%= Html.ActionLink("Edit", "Edit", new { id = item.Identificador })%> |
                <%= Html.ActionLink("Details", "Details", new { id = item.Identificador })%>
            </td>
            <td>
                <%= Html.Encode(item.Identificador)%>
            </td>
            <td>
                <%= Html.Encode(item.CategoryName) %>
            </td>
            <td>
                <%= Html.Encode(item.Description) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%= Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

