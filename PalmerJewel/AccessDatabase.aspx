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
            <asp:GridView ID="DatabaseAccess" runat="server">
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:YIKESConnectionString %>" SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>
        </div>
        <br />
        <asp:DropDownList ID="SelectTable" runat="server" OnSelectedIndexChanged="SelectTable_SelectedIndexChanged">
            <asp:ListItem>Users</asp:ListItem>
            <asp:ListItem>Products</asp:ListItem>
            <asp:ListItem>Orders</asp:ListItem>
            <asp:ListItem>OrderDetails</asp:ListItem>
            <asp:ListItem>OrderAddress</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="search" runat="server"></asp:TextBox>
        <asp:Button ID="searchButton" runat="server" OnClick="Button1_Click" Text="Search" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Entires Found "></asp:Label>
            <asp:Label ID="Entries" runat="server" Text="0"></asp:Label>
        </p>
    </form>
</body>
</html>
