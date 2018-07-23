<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserDelete.aspx.cs" Inherits="UserDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
<body style="background-color: lightslategrey;">
        <form id="form1" runat="server">
            <div id="mainD">
                <div style="width: 20%; float: left; height: 650px; background-color: lightslategrey;">
                    <div id="div1" runat="server" style="color:white;width:100% ;text-align:left;">
                        <h2>
                            Welcome
                        </h2>
                    </div>

                    <br />
                    <br />
                    <br />
                    <br />

                    <a href="Users.aspx" style="text-decoration:none; color:white;">Go Back</a>

                </div>
            
                <div style="width: 80%; float: left; height: 643px; background-color: lightskyblue;">
                    <div id="divAddUsers" runat="server" style="color:white;width:100% ;text-align:center;"><h2>Add Users</h2></div>

                    <br />
                    <br />

                    <h4 style="text-align:center">
                        <asp:Label ID="lblEmailId" Text="Email ID:    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   " runat="server"></asp:Label>
                        <asp:TextBox ID="tbEmailId" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvEmailId" runat="server" ErrorMessage="Please enter the Email Id!!" ControlToValidate="tbEmailId" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblFirstName" Text="First Name:    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    " runat="server"></asp:Label>
                        <asp:TextBox ID="tbFirstName" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ErrorMessage="Please enter the First Name!!" ControlToValidate="tbFirstName"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblLastName" Text="Last Name:    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    " runat="server"></asp:Label>
                        <asp:TextBox ID="tbLastName" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ErrorMessage="Please enter the Last Name!!" ControlToValidate="tbLastName"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblUserRole" Text="User Role:    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    " runat="server"></asp:Label>
                        <asp:TextBox ID="tbUserRole" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvUserRole" runat="server" ErrorMessage="Please enter the User Role!!" ControlToValidate="tbUserRole"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblPassword" Text="Password:    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    " runat="server"></asp:Label>
                        <asp:TextBox ID="tbPassword" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Please enter the Password!!" ControlToValidate="tbPassword"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:right">
                        <asp:Button ID="btnUserDelete" Text="Delete" runat="server" OnClick="btnUserDelete_Click" style=" top:50%; left:50%; margin-right:32%; margin-top:0px; background-color:lightskyblue; border-color:lightskyblue"/>
                    </h4>
                        
                </div>
            </div>
        </form>
    </body>
</html>
