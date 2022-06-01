<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="querysource.aspx.cs" Inherits="Day2ASP.querysource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />

            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Redirect" runat="server" Text="Redirect" OnClick="Redirect_Click" />
        </div>
    </form>
</body>
</html>
