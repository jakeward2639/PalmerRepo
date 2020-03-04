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
            <asp:GridView ID="DatabaseAccess" runat="server" OnSelectedIndexChanged="DatabaseAccess_SelectedIndexChanged">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
