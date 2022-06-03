<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Day4MasterPages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <h1>Head 1<asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        Todays Dat: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </h1>
    <p>
        <asp:Button ID="BtnDate" runat="server" Text="Click" OnClick="BtnDate_Click" />
    </p>

</asp:Content>

