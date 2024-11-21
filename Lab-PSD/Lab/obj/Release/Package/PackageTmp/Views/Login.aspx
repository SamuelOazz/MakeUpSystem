<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Nav.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Lab.Views.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
    body{
        display:flex;
        justify-content:center;
        align-items:center;
    }
    h1{
        text-align:center;
    }
    div{
        margin-top:10px;
    }
</style>
<h1>LOGIN</h1>

<div>
    <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
    <asp:TextBox ID="Username" runat="server"></asp:TextBox>
</div>

<div>
    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="Password" TextMode="Password" runat="server"></asp:TextBox>
</div>

<div>
    <asp:CheckBox ID="remember" runat="server" />
    <asp:Label ID="Label3" runat="server" Text="Remember Me" ></asp:Label>
</div>

<div>
    <asp:Label ID="Error" runat="server" Text="&nbsp;"></asp:Label>
    <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" />
</div>

<div>
    <a href="Register.aspx">Register</a>
</div>
</asp:Content>
