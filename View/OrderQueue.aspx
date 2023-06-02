<%@ Page Title="" Language="C#" MasterPageFile="~/View/Home.Master" AutoEventWireup="true" CodeBehind="OrderQueue.aspx.cs" Inherits="project_RAAMEN.View.OrderQueue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="QueueGV" runat="server" BackColor="White" AutoGenerateColumns="False" OnSelectedIndexChanged="QueueGV_SelectedIndexChanged" OnRowDeleting="QueueGV_RowDeleting" Width="700px">
        <HeaderStyle BackColor="DarkBlue" Font-Bold="true" ForeColor="White"/>
        <Columns>  
            <asp:BoundField HeaderText="ID" DataField="id" />
            <asp:BoundField HeaderText="Name" DataField="userId" /> 
            <asp:CommandField HeaderText="Action" ButtonType="Button" DeleteText="Handle" ShowDeleteButton="true" SelectText="Show Detail" ShowSelectButton="true" ShowCancelButton="false"/>
        </Columns>

    </asp:GridView>
    <br />

    <br />
    <asp:Label ID="DetailLbl" runat="server" Text=""></asp:Label>
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

</asp:Content>
