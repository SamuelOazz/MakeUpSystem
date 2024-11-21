<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Nav.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="Lab.Views.Report" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        h1{
            text-align:center;
        }
    </style>
    <h1>
        Report
    </h1>
    <div>
        <CR:CrystalReportViewer ID="CrystalReportViewer2" runat="server" AutoDataBind="true" />
    </div>
</asp:Content>
