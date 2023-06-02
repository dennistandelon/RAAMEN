<%@ Page Title="" Language="C#" MasterPageFile="~/View/Home.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="project_RAAMEN.View.History" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="HeaderGV" runat="server" BackColor="White" AutoGenerateColumns="False" OnSelectedIndexChanged="HeaderGV_SelectedIndexChanged">
        <HeaderStyle BackColor="DarkBlue" Font-Bold="true" ForeColor="White"/>
        <Columns>
            <asp:BoundField DataField="id" HeaderText="Transaction ID" />
            <asp:BoundField DataField="customer" HeaderText="Customer" />
            <asp:BoundField DataField="staff" HeaderText="Staff" />
            <asp:BoundField DataField="date" HeaderText="Date" />
            <asp:CommandField ButtonType="Button" HeaderText="Details" ShowSelectButton="true" SelectText="View Detail"/>
        </Columns>
        
    </asp:GridView>
</asp:Content>
