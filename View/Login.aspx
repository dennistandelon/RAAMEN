<%@ Page Title="" Language="C#" MasterPageFile="~/View/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="project_RAAMEN.View.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Label ID="usernameLbl" runat="server" Text="Username: "></asp:Label>
    <asp:TextBox ID="usernameTxb" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="passwordLbl" runat="server" Text="Password: "></asp:Label>
    <asp:TextBox ID="passwordTxb" runat="server"></asp:TextBox>
    <br />
    
    <asp:CheckBox ID="cookieBox" runat="server" />
    <asp:Label ID="cookieLbl" runat="server" Text="Remember Me"></asp:Label>
    <br />


    <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
    <br/>

    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
    <asp:HyperLink ID="regist" runat="server">Create Account?</asp:HyperLink>

    <br />
</asp:Content>
