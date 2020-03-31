<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="PalmerJewel.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>checkout</title>
    <div class="w3-container">
        <h2>Checkout</h2>
</head>
<body>
    <br />
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Full Name"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="City"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Postcode"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Mobile Number"></asp:Label>
        <div>
            <asp:Button ID="OrderandPay" runat="server" Text="Order and Pay" OnClick="OrderandPay_Click" />
        </div>
    </form>
</body>
</html>
