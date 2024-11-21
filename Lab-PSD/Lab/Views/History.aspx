<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Nav.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="Lab.Views.History" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        function view(Id) {
            window.location.href = "?Id=" + Id;
        }
    </script>
    <style>
    h1{
        text-align:center;
    }
    </style>
    <h1>History</h1>

    <div>
        <% if (Selectedhead == null) { %>
        <table>
            <thead>
            <tr>
                <th>Id</th>
                <% if (IsADMIN) { %>
                    <th>
                        User Id
                    </th>
                <% } %>
                <th>Date</th>
                <th>Status</th>
                <th></th>
            </tr>
            </thead>
            <tbody>
            <% if (th.Count > 0) { %>
                <% foreach (var x in th) { %>
                    <tr>
                        <td><%= x.Id %></td>
                        <% if (IsADMIN) { %>
                            <td><%= x.UserId %></td>
                        <% } %>
                        <td><%= x.TransactionDate%></td>
                        <td><%= x.Status%></td>
                        <td>
                            <button type="button" onclick="view(<%= x.Id %>)">
                                View Details
                            </button>
                        </td>
                    </tr>
                <% } %>
            <% } %>
            </tbody>
        </table>
        <% }
           else if (Selectedhead != null && Selecteddetail != null)
           { %>
            <div>
                <p>
                    Transaction ID :  <%= Selectedhead.Id%>
                </p>
                <% if (IsADMIN) { %>
                    <p>
                       
                       User ID: <%= Selectedhead.UserId %>
                    </p>
                <% } %>
                <p>
                        Date:  <%= Selectedhead.TransactionDate %>
                </p>
                <p>
                        Status:  <%= Selectedhead.Status %>
                </p>
                <hr />
                <div>
                    <% foreach (var d in Selecteddetail) { %>
                    <div>
                        <p>
                           Item : <%= d.MakeUp.Name %>
                        </p>
                        <p>
                                Quantity : <%= d.Quantity %>
                        </p>
                        <p>
                                Price : <%= d.MakeUp.Price%>
                        </p>
                        <hr />
                    </div>
                    <% } %>
                </div>
                <br />
                <a href="History.aspx">
                        Close
                </a>
            </div>
            <% } %>
    </div>
        
</asp:Content>
