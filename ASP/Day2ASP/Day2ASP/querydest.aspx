<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="querydest.aspx.cs" Inherits="Day2ASP.querydest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Retrieve" runat="server" Text="Retrieve" OnClick="Retrieve_Click" />
        </div>
    </form>
</body>
</html>
