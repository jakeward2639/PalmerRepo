﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="PalmerJewel.CreateAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link rel="stylesheet" href="StyleSheet.css">
<head runat="server">
    <title>create account</title>
    <div class="w3-container">
        <h2>Create Account</h2>
    <div class="w3-container">        
        <p style="width: 285px">Already have an Account? <a href="LoginPage.aspx" style="color:DodgerBlue;"  target="_top" > Click here!</a></p>
</head>
<body>
    <form id="form1" runat="server">
        <div>            
        </div>       
        <p>
            <asp:TextBox ID="UsernameCreate" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="PasswordCreate" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="SubmitAccountRequest" runat="server" OnClick="SubmitAccountRequest_Click" Text="Login" />
        </div>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PalmerConnectionString %>" SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>
    </form>
</body>
</html>
