<%@ Page Title="" Language="C#" MasterPageFile="~/View/Home.Master" AutoEventWireup="true" CodeBehind="OrderRamen.aspx.cs" Inherits="project_RAAMEN.View.OrderRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="RaamenView" runat="server" BackColor="White" AutoGenerateColumns="False" OnSelectedIndexChanged="RaamenView_SelectedIndexChanged" Width="466px">
        <HeaderStyle BackColor="DarkBlue" Font-Bold="true" ForeColor="White"/>
        <Columns>  
            <asp:BoundField HeaderText="Id" DataField="id" /> 
            <asp:BoundField HeaderText="Name" DataField="name" /> 
            <asp:BoundField HeaderText="Meat" DataField="meat" />  
            <asp:BoundField HeaderText="Broth" DataField="broth" />
            <asp:BoundField HeaderText="Price" DataField="price" />
           
           <asp:CommandField ShowSelectButton="true" SelectText="Order"  ButtonType="Button" />
        </Columns>

    </asp:GridView>
    <br />

    <asp:Label ID="Lable7" runat="server" Text="Your Cart:"></asp:Label>
    <br />

    <asp:GridView ID="CartGV" runat="server" BackColor="White" AutoGenerateColumns="False"  Width="466px">
        <HeaderStyle BackColor="DarkBlue" Font-Bold="true" ForeColor="White"/>
        <Columns>  
            <asp:BoundField HeaderText="Name" DataField="name" /> 
            <asp:BoundField HeaderText="Meat" DataField="meat" />  
            <asp:BoundField HeaderText="Broth" DataField="broth" />
            <asp:BoundField HeaderText="Price" DataField="price" />
            <asp:BoundField HeaderText="Quantity" DataField="quantity" />
        </Columns>

    </asp:GridView>
    <br />

    <asp:Button ID="ClearCart" runat="server" Text="Clear Cart" OnClick="ClearCart_Click" />
    <asp:Button ID="BuyBtn" runat="server" Text="Buy" OnClick="BuyBtn_Click" />
</asp:Content>
