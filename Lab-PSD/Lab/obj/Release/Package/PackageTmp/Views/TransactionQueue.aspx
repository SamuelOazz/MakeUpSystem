<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Nav.Master" AutoEventWireup="true" CodeBehind="TransactionQueue.aspx.cs" Inherits="Lab.Views.TransactionQueue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <script>
       function handle(Id) {
           window.location.href = "?Id=" + Id;
       }
   </script>

    <style>
        h1{
            text-align:center;
        }
    </style>
    <h1>
        Transaction Queue
    </h1>

    <div>
        <table>
            <thead>
                <tr>
                    <th>Id</th>
                    <th>UserId</th>
                    <th>Date</th>
                    <th>Status</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
               <% if (transactions.Count > 0) {  %>
                    <% foreach (var x in transactions) {  %>
                        <tr>
                            <td><%= x.Id %></td>
                            <td><%= x.UserId %></td>
                            <td><%= x.TransactionDate %></td>
                            <td><%= x.Status %></td>
                            <td>
                                <% if (x.Status == "Unhandled") {  %>
                                    <button type="button" onclick="handle(<%= x.Id %>)">
                                        Handle
                                    </button>
                                <% } %>
                            </td>
                        </tr>
                     <%} %>
                <% } %>
            </tbody>
        </table>
        <asp:Label ID="Error" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
