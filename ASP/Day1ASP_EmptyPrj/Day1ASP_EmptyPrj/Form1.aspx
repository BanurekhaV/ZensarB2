<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form1.aspx.cs" Inherits="Day1ASP_EmptyPrj.Form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Form1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>ASP.NET Application</p>
        </div>
        User Name : &nbsp; <asp:Label ID="Label1" runat="server"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Text="Zensar"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Click" OnClick="Button1_Click" />
    </form>
</body>
</html>
