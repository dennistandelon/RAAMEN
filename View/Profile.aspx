<%@ Page Title="" Language="C#" MasterPageFile="~/View/Home.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="project_RAAMEN.View.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Label ID="Label5" runat="server" Text="Your Data: "></asp:Label>
    <br />
    <asp:Label ID="oldNameLbl" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="oldEmailLbl" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="genderLbl" runat="server" Text=""></asp:Label>
    <br />

    <br/>
    <asp:Label ID="Label6" runat="server" Text="New Data: "></asp:Label>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
    <asp:TextBox ID="usernameTxb" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Label2" runat="server" Text="Email: "></asp:Label>
    <asp:TextBox ID="emailTxb" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Label3" runat="server" Text="Gender: "></asp:Label>
    <asp:DropDownList ID="genderDropDown" runat="server">
        <asp:ListItem Value="Select gender">Select Gender</asp:ListItem>
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:DropDownList>
    <br />

    <asp:Label ID="Label4" runat="server" Text="Password: "></asp:Label>
    <asp:TextBox ID="pwTxb" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
    <br />

    <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click"/>
</asp:Content>
