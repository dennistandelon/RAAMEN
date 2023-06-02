<%@ Page Title="" Language="C#" MasterPageFile="~/View/Home.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="project_RAAMEN.View.Report" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <CR:CrystalReportViewer ID="CrystalReportViewer" runat="server" AutoDataBind="true" />
</asp:Content>
