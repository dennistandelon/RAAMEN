<%@ Page Title="" Language="C#" MasterPageFile="~/View/Home.Master" AutoEventWireup="true" CodeBehind="DetailPage.aspx.cs" Inherits="project_RAAMEN.View.DetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Transaction Detail:"></asp:Label>
    <br />
    <asp:Label ID="TrIdLabel" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="StaffLbl" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="DateLbl" runat="server" Text=""></asp:Label>
    <br />
    <asp:GridView ID="DetailGV" runat="server" AutoGenerateColumns="false">
        <HeaderStyle BackColor="DarkBlue" Font-Bold="true" ForeColor="White"/>
        <Columns>
            <asp:BoundField DataField="ramen" HeaderText="Ramen" />
            <asp:BoundField DataField="quantity" HeaderText="Quantity" />
        </Columns>
    </asp:GridView>
</asp:Content>
