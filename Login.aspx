<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Login</title>
</head>
    <body style="background-color:lightslategrey">
        
        <form id="form1" runat="server">
        
                <div style="width:500px; height:400px; z-index:10; top:50%; left:50%; background-color:lightskyblue; margin:75px 0 0 400px">
            
                <br />
                <br />
                <h1 style="text-align:center">
                    <asp:Label ID="lblLogin" Text="User Login" runat="server" ></asp:Label>
                </h1>
                <br />
                <br />
                <h4 style="text-align:center">
                    <asp:Label ID="lblName" Text="Username:" runat="server"></asp:Label>
                    <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rfvLogin" runat="server" ErrorMessage="Please enter the Username!" ControlToValidate="tbName"></asp:RequiredFieldValidator>
                </h4>
                
                <h4 style="text-align:center">
                    <asp:Label ID="lblPassword" Text="Password:" runat="server"></asp:Label>
                    <asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Please enter the Password!" ControlToValidate="tbPassword"></asp:RequiredFieldValidator>
                </h4>
                
                <h4 style="text-align:right"><asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" style=" top:50%; left:50%; margin-right:28%; margin-top:5%; background-color:lightskyblue; border-color:lightskyblue"/></h4>
                <br />
                <br />
            </div>
        </form>
    </body>
</html>
