<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IntroForm.aspx.cs" Inherits="Day2ASP.IntroForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Count :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt1" runat="server">

            </asp:TextBox>
            
            <br />
            <br />
            <asp:Button ID="Btn_Count" runat="server" OnClick="Btn_Count_Click" Text="Click for Count" />
            
        </div>
    </form>
</body>
</html>
