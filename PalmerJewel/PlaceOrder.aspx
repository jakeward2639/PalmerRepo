<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlaceOrder.aspx.cs" Inherits="PalmerJewel.PlaceOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PlaceOrder</title>
    <h2>Place Order</h2>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Named DogTag</div>
        <asp:Button ID="OrderDT" runat="server" Text="Order" />
        <br />
        <br />
        YIKES Necklace<br />
        <asp:Button ID="OrderYN" runat="server" Text="Order" />
        <br />
        <br />
        YIKES Ring<br />
        <asp:Button ID="OrderYR" runat="server" Text="Order" />
    </form>
</body>
</html>
