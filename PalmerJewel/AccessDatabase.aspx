<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccessDatabase.aspx.cs" Inherits="PalmerJewel.AccessDatabase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AccessDatabase</title>
    <h2>Access Database</h2>
</head>
<body>
    <form id="form1" runat="server">
        <div>           
            <asp:GridView ID="DatabaseAccess" runat="server" OnSelectedIndexChanged="DatabaseAccess_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                    <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                    <asp:BoundField DataField="Permission" HeaderText="Permission" SortExpression="Permission" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:YIKESConnectionString %>" SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
