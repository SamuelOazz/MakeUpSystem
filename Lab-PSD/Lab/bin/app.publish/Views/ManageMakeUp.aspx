<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Nav.Master" AutoEventWireup="true" CodeBehind="ManageMakeUp.aspx.cs" Inherits="Lab.Views.ManageMakeUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
    h1{
        text-align:center;
    }
    a{
        padding: 10px;
    }
</style>
     <script>
         function Delete(item, Id) {
             window.location.href = "?action=delete&item=" + item + "&id=" + Id;
         }
     </script>
<h1>
    Manage MAKE UP
</h1>

 <div>
    <div>
        <h1>MakeUp</h1>
        <a href="INSERT/MakeUp.aspx">
            INSERT
        </a>
    </div>
    <table>
        <thead>
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Price</th>
                <th>Weight</th>
                <th>Brand</th>
                <th>Type</th>
                <th></th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            <%-- Loop--%>
            <% if(makeup.Count > 0) {  %>
                 <% foreach (var x in makeup) {  %>
                    <tr>
                        <td><%= x.Id %></td>
                        <td><%= x.Name %></td>
                        <td><%= x.Price %></td>
                        <td><%= x.Weight %></td>
              <td><%= x.MakeUpBrand != null ? x.MakeUpBrand.Name : "No Brand" %></td>
                        <td><%= x.MakeUpType != null ? x.MakeUpType.name : "No Type" %></td>
                        <td>
                            <a href="UPDATE/MakeUp.aspx?id=<%= x.Id %>">
                                Update
                            </a>
                        </td>
                        <td>
                            <button type="button" onclick="Delete('makeup',<%= x.Id %>)">
                                Delete
                            </button>
                        </td>
                    </tr>
                <% }%>
            <% } %>
        </tbody>
    </table>
 </div>
    <div>
        <div>
            <h1>Type</h1>
            <a href="INSERT/TypeMakeUp.aspx">
                INSERT
            </a>
        </div>
        <table>
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <%--LOOP --%>
                <% if(type.Count > 0) { %>
                    <% foreach (var x in type) {  %>
                        <tr>
                            <td><%= x.Id %></td>
                            <td><%= x.name %></td>
                            <td>
                                <a href="UPDATE/UpdateType.aspx?id=<%= x.Id %>">Update</a>
                            </td>
                            <td>
                                <button type="button" onclick="Delete('type',<%= x.Id %>)">
                                    Delete
                                </button>
                            </td>
                        </tr>
                    <%} %>
                <% } %>
            </tbody>
        </table>
    </div>
    <div>
        <div>
            <h1>Brand</h1>
            <a href="INSERT/Brand.aspx">
                INSERT
            </a>
        </div>
        <table>
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Rating</th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <%-- LOOP--%>
                <% if(brand.Count > 0) {  %>
                    <% foreach (var x in brand) { %>
                        <tr>
                            <td><%= x.Id %></td>
                            <td><%= x.Name%></td>
                            <td><%= x.Rating%></td>
                            <td>
                                <a href="UPDATE/UpdateBrand.aspx?id=<%= x.Id %>">Update</a>
                            </td>
                            <td>
                                 <button type="button" onclick="Delete('brand',<%= x.Id %>)">
                                        Delete
                                 </button>
                            </td>
                        </tr>
                    <% } %>
                <% } %>
            </tbody>
        </table>
    </div>

</asp:Content>
