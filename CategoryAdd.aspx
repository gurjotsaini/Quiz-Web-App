<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CategoryAdd.aspx.cs" Inherits="CategoryAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Add Category</title>
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

                    <a href="Categories.aspx" style="text-decoration:none; color:white;">Go Back</a>

                </div>
            
                <div style="width: 80%; float: left; height: 643px; background-color: lightskyblue;">
                    <div id="divAddCategories" runat="server" style="color:white;width:100% ;text-align:center;"><h2>Add Categories</h2></div>

                    <br />
                    <br />

                    <h4 style="text-align:center">
                        <asp:Label ID="lblTitle" Text="Title:    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   " runat="server"></asp:Label>
                        <asp:TextBox ID="tbTitle" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbTitle"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblDescription" Text="Description:    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    " runat="server"></asp:Label>
                        <asp:TextBox ID="tbDescription" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvDescription" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbDescription"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblAddedBy" Text="Added By:    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    " runat="server"></asp:Label>
                        <asp:TextBox ID="tbAddedBy" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvAddedBy" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbAddedBy"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblApproved" Text="Approved:    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    " runat="server"></asp:Label>
                        <asp:TextBox ID="tbApproved" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvApproved" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbApproved"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblActive" Text="Active:    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    " runat="server"></asp:Label>
                        <asp:TextBox ID="tbActive" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvActive" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbActive"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:right">
                        <asp:Button ID="btnCategorySubmit" Text="Submit" runat="server" onClick="btnCategorySubmit_Click" style=" top:50%; left:50%; margin-right:32%; margin-top:0px; background-color:lightskyblue; border-color:lightskyblue"/>
                    </h4>
                        
                </div>
            </div>
        </form>
    </body>
</html>
