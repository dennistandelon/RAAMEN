<%@ Page Title="" Language="C#" MasterPageFile="~/View/Home.Master" AutoEventWireup="true" CodeBehind="UpdateRamen.aspx.cs" Inherits="project_RAAMEN.View.UpdateRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label5" runat="server" Text="Ramen Data: "></asp:Label>
    <br />
    <asp:Label ID="NameLbl" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="MeatLbl" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="BrothLbl" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="PriceLbl" runat="server" Text=""></asp:Label>
    <br />

    <br />
    <asp:Label ID="Label6" runat="server" Text="New Data: "></asp:Label>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
    <asp:TextBox ID="nameTxb" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Label3" runat="server" Text="Meat: "></asp:Label>
    <asp:DropDownList ID="MeatDropDown" runat="server">
        <asp:ListItem Value="Select meat">Select Meat</asp:ListItem>
    </asp:DropDownList>
    <br />


    <asp:Label ID="Label2" runat="server" Text="Broth: "></asp:Label>
    <asp:TextBox ID="brothTxb" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Label4" runat="server" Text="Price: "></asp:Label>
    <asp:TextBox ID="priceTxb" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
    <br />

    <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
    <asp:Button ID="BackBtn" runat="server" Text="Back" OnClick="BackBtn_Click" />
</asp:Content>
