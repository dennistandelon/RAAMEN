<%@ Page Title="" Language="C#" MasterPageFile="~/View/Home.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="project_RAAMEN.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="roleLbl" runat="server" Text=""></asp:Label>
    <asp:GridView ID="GV1" runat="server"></asp:GridView>
    <asp:Label ID="roleLbl2" runat="server" Text=""></asp:Label>
    <asp:GridView ID="GV2" runat="server"></asp:GridView>
</asp:Content>
