<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlaceOrder.aspx.cs" Inherits="PalmerJewel.PlaceOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PlaceOrder</title>
    <h2>Place Order</h2>
</head>
<body>    
        <div>
            Named DogTag</div>
        <asp:Button ID="OrderDT" runat="server" Text="Order" OnClick="OrderDT_Click" />
        <br />
        <br />
        YIKES Necklace<br />
        <asp:Button ID="OrderYN" runat="server" Text="Order" OnClick="OrderYN_Click" />
        <br />
        <br />
        YIKES Ring<br />
        <asp:Button ID="OrderYR" runat="server" Text="Order" OnClick="OrderYR_Click" />
        <br />
        <br />
        <asp:Button ID="ToCheckout" runat="server" Text="To Checkout" OnClick="ToCheckout_Click" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:YIKESConnectionString %>" SelectCommand="SELECT * FROM [Orders]"></asp:SqlDataSource>
