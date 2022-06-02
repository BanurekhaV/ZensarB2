<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationsForm.aspx.cs" Inherits="Day3ASP.ValidationsForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="text-align:center">Registration Form</h2>
          UserName&nbsp;  <asp:TextBox ID="Txtname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Username Cannot Be Blank" 
                ForeColor="Red" ControlToValidate="Txtname">*</asp:RequiredFieldValidator>
            <br />
            <br />
           Password&nbsp;&nbsp; <asp:TextBox ID="Txtpwd" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter Password"
                ForeColor="Red" ControlToValidate="Txtpwd">*</asp:RequiredFieldValidator>
            <br />
            <br />
         Confirm password&nbsp;&nbsp; <asp:TextBox ID="Txtcpwd" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password Do not Match"
               ForeColor="Red" ControlToValidate="Txtcpwd" ControlToCompare="Txtpwd" ></asp:CompareValidator>
            <br />
            <br />
         Age&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Txtage" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Txtage" ErrorMessage="Age has to be between 18 and 45" ForeColor="Red" MaximumValue="45" MinimumValue="18" Type="Integer"></asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Age"
                ForeColor="Red" ControlToValidate="Txtage"></asp:RequiredFieldValidator>
            <br />
            <br />
         Email&nbsp;&nbsp;&nbsp;&nbsp;   <asp:TextBox ID="Txtemail" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Txtemail" ErrorMessage="Enter valid Email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
