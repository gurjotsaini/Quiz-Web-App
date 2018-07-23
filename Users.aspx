<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Users.aspx.cs" Inherits="Users" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Users</title>
</head>
<body style="background-color:lightslategrey">
    <form id="form1" runat="server">
        
            <div id="mainD"">
                <div style="width:20%; float:left; height:650px; background-color:lightslategrey;">

                    <div id="div1" runat="server" style="color:white;width:100% ;text-align:left;">
                        <h2>Welcome
                            <b>
                                <asp:Label ID="lblUserName" runat="server" style="color:white;"></asp:Label>
                            </b>
                        </h2>
                    </div>

                    <br />
                    <br />
                    <br />
                    <br />

                    <a href="UserAdd.aspx" style="text-decoration:none; color:white;">Add New User</a>
                    <br /><br />

    <%--            <a href="#" style="text-decoration:none; color:white;">Update</a>
                    <br /><br />

                    <a href="#" style="text-decoration:none; color:white;">Delete</a>
                    <br /><br />
    --%>
                </div>


                <div  style="width:80%; float:left; height:643px; background-color:lightskyblue; overflow-y:scroll;overflow-x:hidden;">
                    <div id="divUsersPanel" runat="server" style="color:white;width:100% ;text-align:center;"><h2>Users Panel</h2></div>
                    <br />
                    <br />
                    <br />
                    <br />
                    <div id="table_Div" style="position:absolute; left:45%;">

                        <asp:Repeater ID="repeater_Users" runat="server" OnItemDataBound="repeater_Users_ItemDataBound">
                            <ItemTemplate>
                                
                                <table id="UsersShow" runat="server" style="border:1px solid; border-spacing:1px inherit; border-collapse:collapse; width:400px;">

                                    <tr style="border-bottom: thin solid black;">
                                        <td>
                                            <asp:HiddenField ID="User_HiddenID" runat="server" />
                                        </td>
                                        <td>
                                            <asp:HyperLink ID="User_Update" runat="server" NavigateUrl="~/UserUpdate.aspx" style="text-decoration:none; color:darkblue; text-align:right;">Update</asp:HyperLink>
                                        </td>
                                        <td>
                                            <asp:HyperLink ID="User_Delete" runat="server" NavigateUrl="~/UserDelete.aspx" style="text-decoration:none; color:darkblue;">Delete</asp:HyperLink>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>Email Id:</td>
                                        <td>
                                            <asp:Label ID="lblEmailId" runat="server"></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>User Password:</td>
                                        <td>
                                            <asp:Label ID="lblUserPassword" runat="server"></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>First Name:</td>
                                        <td>
                                            <asp:Label ID="lblFirstName" runat="server"></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>Last Name:</td>
                                        <td>
                                            <asp:Label ID="lblLastName" runat="server"></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>User Role:</td>
                                        <td>
                                            <asp:Label ID="lblUserRole" runat="server"></asp:Label>
                                        </td>
                                    </tr>

                                </table>
                          
                            </ItemTemplate>
                        </asp:Repeater>

                    </div>

                </div>

            </div>
        
        </form>
    </body>
</html>
