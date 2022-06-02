<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomValidations.aspx.cs" Inherits="Day3ASP.CustomValidations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function IsEven(source, args) {
            if (args.Value == '') {
                args.IsValid = false;
            }
            else {
                if ((args.Value > 0) && (args.Value % 2 == 0)) {
                    args.IsValid = true;
                }
                else {
                    args.IsValid = false;
                }
            }
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Enter a Positive and an Even Number :
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1"
                ErrorMessage="Number has to be Positive and Even" ForeColor="Red"
                OnServerValidate="CustomValidator1_ServerValidate" ValidateEmptyText="True" ClientValidationFunction="IsEven"></asp:CustomValidator>
            <br />
            <br />
            <br />
            <asp:Button ID="SaveBtn" runat="server" Text="Save" OnClick="SaveBtn_Click" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
