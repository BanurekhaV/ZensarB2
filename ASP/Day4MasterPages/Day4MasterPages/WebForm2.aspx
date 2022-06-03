<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Day4MasterPages.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">


  <asp:Label ID="Label1" runat="server" Text="User Id"></asp:Label><br /><br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label><br /><br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
    <asp:Button ID="Button1" runat="server" Text="Login" />


</asp:Content>
