<%@ Page Title="" Language="C#" MasterPageFile="~/View/Home.Master" AutoEventWireup="true" CodeBehind="ManageRamen.aspx.cs" Inherits="project_RAAMEN.View.ManageRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="RaamenView" runat="server" BackColor="White" AutoGenerateColumns="False" OnRowEditing="RaamenView_RowEditing" OnRowDeleting="RaamenView_RowDeleting" Width="600px">
        <HeaderStyle BackColor="DarkBlue" Font-Bold="true" ForeColor="White"/>
        <Columns> 
            <asp:BoundField HeaderText="Id" DataField="id" /> 
            <asp:BoundField HeaderText="Name" DataField="name" /> 
            <asp:BoundField HeaderText="Meat" DataField="meat" />  
            <asp:BoundField HeaderText="Broth" DataField="broth" />
            <asp:BoundField HeaderText="Price" DataField="price" />
           
           <asp:CommandField HeaderText="Action" ShowCancelButton="false" ShowEditButton="true" EditText="Update" ShowDeleteButton="true" DeleteText="Delete" ButtonType="Button" />
        </Columns>
    </asp:GridView>

    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="insertBtn" runat="server" Text="Insert New Ramen" OnClick="insertBtn_Click" />
    <br />
</asp:Content>
