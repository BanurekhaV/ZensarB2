<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Day4WebService_Client.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          Enter Name :  <asp:TextBox ID="Txtname" runat="server"></asp:TextBox>
            <br />
            <br />
          Enter a Number:  <asp:TextBox ID="Txtnumber" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnMsg" runat="server" Text="Display Message Button" OnClick="BtnMsg_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnSquare" runat="server" Text="Find Square Button" OnClick="BtnSquare_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
