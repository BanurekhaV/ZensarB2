<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hiddenfield.aspx.cs" Inherits="Day2ASP.hiddenfield" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:HiddenField ID="HiddenField2" runat="server" />
            <br />
            <br />
            <asp:Button ID="Store" runat="server" Text="Store" OnClick="Store_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Load" runat="server" Text="Load" OnClick="Load_Click" />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text=" "></asp:Label>
        </div>
    </form>
</body>
</html>
