<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="PalmerJewel.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link rel="stylesheet" href="StyleSheet.css">
<head runat="server">
    <title>login</title>
    <div class="w3-container">
        <h2>Login</h2>
    <div class="w3-container">        
        <p style="width: 265px">Don&#39;t have an Account? <a href="CreateAccount.aspx" style="color:DodgerBlue;"  target="_top" > Click here!</a></p>
</head>
<body>
    <form id="form1" runat="server">
        <div>            
        </div>       
        <p>
            <input id="UsernameEnter" type="text" /></p>
        <p>
            <input id="PasswordEnter" type="text" /></p>
        <asp:Button ID="SubmitLoginRequest" runat="server" OnClick="SubmitLoginRequest_Click" Text="Login" />
    </form>
</body>
</html>

