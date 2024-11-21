<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Nav.Master" AutoEventWireup="true" CodeBehind="UpdateType.aspx.cs" Inherits="Lab.Views.Update.UpdateType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        Update Type
    </h1>
    <p>
        Type ID = <%= Request.QueryString["Id"] %>
    </p>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="UpdateTypebtn" runat="server" Text="Update" OnClick="UpdateTypebtn_Click" />
         <a href="/Views/ManageMakeUp.aspx">Cancel</a>
    </div>
</asp:Content>
