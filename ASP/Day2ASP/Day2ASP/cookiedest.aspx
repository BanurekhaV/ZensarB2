<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookiedest.aspx.cs" Inherits="Day2ASP.cookiedest" %>

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
            <br />
            <asp:Button ID="Retrieve" runat="server" Text="Retrieve the Data" OnClick="Retrieve_Click" />
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
