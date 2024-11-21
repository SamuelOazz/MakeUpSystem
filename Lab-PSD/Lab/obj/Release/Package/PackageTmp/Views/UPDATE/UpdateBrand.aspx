<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Nav.Master" AutoEventWireup="true" CodeBehind="UpdateBrand.aspx.cs" Inherits="Lab.Views.Update.Brand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        UPDATE BRAND
    </h1>
     <p>
        Brand ID: <%=Request.QueryString["Id"]  %>
    </p>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="Name" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Rating"></asp:Label>
        <asp:TextBox ID="Rating" TextMode="Number" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="UpdateBrandBtn" runat="server" Text="Update" OnClick="UpdateBrandBtn_Click"/>
        <a href="/Views/ManageMakeUp.aspx">Cancel</a>
    </div>
</asp:Content>
