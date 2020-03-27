<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="PalmerJewel.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>checkout</title>
    <div class="w3-container">
        <h2>Checkout</h2>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="OrderandPay" runat="server" Text="Order and Pay" OnClick="OrderandPay_Click" />
        </div>
    </form>
</body>
</html>
