<%@ Page Title="" Language="C#" MasterPageFile="~/View/Register.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="project_RAAMEN.View.Register1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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

    <asp:Label ID="Label5" runat="server" Text="Confirm Password: "></asp:Label>
    <asp:TextBox ID="cpwTxb" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
    <br />

    <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click" />
    <asp:HyperLink ID="login" runat="server">Already Have an Account?</asp:HyperLink>
</asp:Content>
