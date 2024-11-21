<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Nav.Master" AutoEventWireup="true" CodeBehind="Brand.aspx.cs" Inherits="Lab.Views.Insert.Brand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        ADD BRAND
    </h1>

    <div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="Name" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Rating"></asp:Label>
        <asp:TextBox ID="Rating" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="AddBtn" runat="server" Text="Add" OnClick="AddBtn_Click" />
    </div>
</asp:Content>
