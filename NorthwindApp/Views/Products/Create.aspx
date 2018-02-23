<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NorthwindApp.Models.EditProductViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create</h2>

    <%= Html.ValidationSummary("Create was unsuccessful. Please correct the errors and try again.") %>

    <% using (Html.BeginForm()) {%>

        <% =Html.AntiForgeryToken() %>
        <fieldset>
            <legend>Fields</legend>
            <p>
                <label for="ProductName">Category:</label>
                <% =Html.DropDownList("Category.Identificador", 
                    new SelectList(Model.Categories,"Identificador", "CategoryName", (Model.Product.Category == null ? 0 : Model.Product.Category.Identificador))) %>
                <%= Html.ValidationMessage("Product.Category.Identificador", "*") %>
            </p>
            <p>
                <label for="ProductName">ProductName:</label>
                <%= Html.TextBox("Product.ProductName") %>
                <%= Html.ValidationMessage("Product.ProductName", "*") %>
            </p>
            <p>
                <label for="SupplierID">SupplierID:</label>
                <%= Html.TextBox("Product.SupplierID") %>
                <%= Html.ValidationMessage("Product.SupplierID", "*") %>
            </p>
            <p>
                <label for="QuantityPerUnit">QuantityPerUnit:</label>
                <%= Html.TextBox("Product.QuantityPerUnit") %>
                <%= Html.ValidationMessage("Product.QuantityPerUnit", "*") %>
            </p>
            <p>
                <label for="UnitPrice">UnitPrice:</label>
                <%= Html.TextBox("Product.UnitPrice", String.Format("{0:F}", Model.Product.UnitPrice))%>
                <%= Html.ValidationMessage("Product.UnitPrice", "*") %>
            </p>
            <p>
                <label for="UnitsInStock">UnitsInStock:</label>
                <%= Html.TextBox("Product.UnitsInStock") %>
                <%= Html.ValidationMessage("Product.UnitsInStock", "*") %>
            </p>
            <p>
                <label for="UnitsOnOrder">UnitsOnOrder:</label>
                <%= Html.TextBox("Product.UnitsOnOrder") %>
                <%= Html.ValidationMessage("Product.UnitsOnOrder", "*") %>
            </p>
            <p>
                <label for="ReorderLevel">ReorderLevel:</label>
                <%= Html.TextBox("Product.ReorderLevel") %>
                <%= Html.ValidationMessage("Product.ReorderLevel", "*") %>
            </p>
            <p>
                <label for="Discontinued">Discontinued:</label>
                <%= Html.CheckBox("Product.Discontinued") %>
                <%= Html.ValidationMessage("Product.Discontinued", "*") %>
            </p>
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%=Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

