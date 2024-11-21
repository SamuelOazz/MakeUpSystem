<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Nav.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Lab.Views.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        h1{
            text-align:center;
        }
    </style>
    <h1>
        HOMEPAGE
    </h1>

    <h1 ID="Users"></h1>
    <asp:GridView ID="ListUserStore" runat="server"></asp:GridView>
</asp:Content>
