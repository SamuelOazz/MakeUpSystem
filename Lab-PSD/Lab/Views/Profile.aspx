<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Nav.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Lab.Views.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
    h1{
        text-align:center;
    }
</style>
    <h1>
        Profile
    </h1>

    <div>
        <asp:TextBox ID="userid" visible="false" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
        <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="Email" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
        <asp:TextBox ID="Gender" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="DOB"></asp:Label>
        <asp:TextBox ID="DOB" TextMode="Date" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Old Password"></asp:Label>
        <asp:TextBox ID="OldPass" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="New Password"></asp:Label>
        <asp:TextBox ID="NewPass" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Err" runat="server" Text=""></asp:Label>
        <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />


    </div>

</asp:Content>
