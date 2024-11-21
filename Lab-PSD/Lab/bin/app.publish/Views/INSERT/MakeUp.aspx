<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Nav.Master" AutoEventWireup="true" CodeBehind="MakeUp.aspx.cs" Inherits="Lab.Views.Insert.MakeUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
    ADD MakeUp
    </h1>

    <div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="Name" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="Price" Textmode="Number" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Weight"></asp:Label>
        <asp:TextBox ID="Weight" Textmode="Number" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label4" runat="server" Text="Type"></asp:Label>
        <asp:DropDownList ID="ListType" runat="server">
             <asp:ListItem Text="Select Type" Value="-1"></asp:ListItem>
        </asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="Label5" runat="server" Text="Brand"></asp:Label>
        <asp:DropDownList ID="ListBrand" runat="server">
             <asp:ListItem Text="Select Brand" Value="-1"></asp:ListItem>
        </asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="AddMakeUpBtn" runat="server" Text="Add" OnClick="AddMakeUpBtn_Click" />
    </div>
</asp:Content>
