<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CacheForm.aspx.cs" Inherits="Day3Caching.CacheForm" %>
<%@ OutputCache Duration="30" VaryByParam="None" Location="Client" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
        </div>
        <p>
            Server Time : 
            <asp:Label ID="Label1" runat="server" Text="Label1"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Client Time :
            <script>
                document.write(Date());
            </script>
          </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Empid" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Empid" HeaderText="Empid" ReadOnly="True" SortExpression="Empid" />
                <asp:BoundField DataField="EmpName" HeaderText="EmpName" SortExpression="EmpName" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="DId" HeaderText="DId" SortExpression="DId" />
                <asp:BoundField DataField="Phoneno" HeaderText="Phoneno" SortExpression="Phoneno" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZensarDBConnectionString %>" SelectCommand="SELECT * FROM [tblEmployee]"></asp:SqlDataSource>
    </form>
</body>
</html>
