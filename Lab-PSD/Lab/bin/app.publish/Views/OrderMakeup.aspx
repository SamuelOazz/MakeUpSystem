<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Nav.Master" AutoEventWireup="true" CodeBehind="OrderMakeup.aspx.cs" Inherits="Lab.Views.OrderMakeup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        function addToCart(id) {
            var qty = document.getElementById("qty-" + id).value
            window.location.href = "?action=add&id=" + id + "&q=" + (qty === "" ? "0" : qty);
        }
        function clearCart() {
            window.location.href = "?action=clear";
        }
        function checkout() {
            window.location.href = "?action=checkout";
        }
    </script>
    <style>
    h1{
        text-align:center;
    }
    </style>
    <h1>
        Order
    </h1>
    
    <div>
        <h2>Item</h2>
        <table>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Brand</th>
                    <th>Type</th>
                    <th>Weight</th>
                    <th>Price</th>
                    <th>Quantity</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <% if(MakeUps.Count > 0) {  %>
                    <% foreach (var x in MakeUps) {  %>
                        <tr>
                            <td><%= x.Name %></td>
                            <td><%= x.MakeUpBrand.Name %></td>
                            <td><%= x.MakeUpType.name %></td>
                            <td><%= x.Weight %></td>
                            <td><%= x.Price.ToString("C") %></td>
                            <td>
                            <input type="number" name="quantity" id="qty-<%= x.Id %>" />
                            </td>
                            <td>
                             <button type="button" onclick="addToCart(<%= x.Id %>)">
                             Add to Cart
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
            <h2>Cart</h2>
            <div>
                 <button type="button" onclick="clearCart()">
                        Clear
                </button>
                <button type="button" onclick="checkout()">
                     Checkout
                </button>
            </div>
        </div>
        <div>
            <% if(Carts.Count > 0) {  %>
                <% foreach (var i in Carts) {  %>
                    <% if (i != null) {  %>
                    <div>
                        <main>
                            <p>(<%= i.MakeUp.Id %>) || <%= i.MakeUp.Name %> </p>
                            <p>|<%= i.MakeUp.MakeUpBrand.Name %> | <%= i.MakeUp.MakeUpType.name %></p>
                            <p>|<%= i.MakeUp.Weight %>| g </p>
                        </main>
                        <p>|<%= i.Quantity %>| x |<%= i.MakeUp.Price.ToString("C") %>|</p>
                    </div>
                    <% } %>
                <%} %>
            <% } %>
        </div>
    </div>

</asp:Content>
