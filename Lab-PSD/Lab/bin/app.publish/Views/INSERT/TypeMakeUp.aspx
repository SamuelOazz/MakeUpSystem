<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Nav.Master" AutoEventWireup="true" CodeBehind="TypeMakeUp.aspx.cs" Inherits="Lab.Views.Insert.TypeMakeUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        ADD TYPE
    </h1>

    <div>
        <asp:Label ID="Label1" runat="server" Text="Nama"></asp:Label>
        <asp:TextBox ID="Name" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="AddTypeBtn" runat="server" Text="Add" OnClick="AddTypeBtn_Click" />
    </div>
</asp:Content>
