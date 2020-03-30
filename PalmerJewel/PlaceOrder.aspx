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
        <asp:Button ID="OrderDT" runat="server" Text="Order" OnClick="OrderDT_Click" />
        <asp:DropDownList ID="DropDownDT" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        YIKES Necklace<br />
        <asp:Button ID="OrderYN" runat="server" Text="Order" OnClick="OrderYN_Click" />
        <asp:DropDownList ID="DropDownYN" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        YIKES Ring<br />
        <asp:Button ID="OrderYR" runat="server" Text="Order" OnClick="OrderYR_Click" />
        <asp:DropDownList ID="DropDownYR" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="ToCheckout" runat="server" Text="To Checkout" OnClick="ToCheckout_Click" /> 
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:YIKESConnectionString %>" SelectCommand="SELECT * FROM [Orders, Users]" ></asp:SqlDataSource>
   </form>
</body>