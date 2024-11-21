<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Nav.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Lab.Views.Register" %>
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
     <h1>Register</h1>

    <div>
        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="Username" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="Email" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="Password"  Textmode="Password" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label4" runat="server" Text="Confirm Password"></asp:Label>
        <asp:TextBox ID="ConPass"  Textmode="Password" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label>
        <asp:TextBox ID="Gender" runat="server"></asp:TextBox>
    </div>
    <div>
         <asp:Label ID="Label6" runat="server" Text="Date of Birth"></asp:Label>
            <asp:TextBox ID="DoB" TextMode="Date" runat="server"></asp:TextBox>
    </div>
    <div>
         <asp:Label ID="Error" runat="server" Text="&nbsp;"></asp:Label>
         <asp:Button ID="RegButton" runat="server" Text="Register" OnClick="RegButton_Click" />
    </div>

    <div>
        <a href="Login.aspx">Login</a>
      </div>
</asp:Content>
