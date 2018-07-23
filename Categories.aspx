<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Categories.aspx.cs" Inherits="Categories" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Categories</title>
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
                    <a href="CategoryAdd.aspx" style="text-decoration:none; color:white;">Add New Category</a>
                    <br /><br />

                </div>

                <div  style="width:80%; float:left; height:643px; background-color:lightskyblue; overflow-y:scroll;overflow-x:hidden;">
                    <div id="divCategoryPanel" runat="server" style="color:white;width:100% ;text-align:center;">
                        <h2>
                            Category Panel
                        </h2>
                    </div>

                    <br />
                    <br />
                    <br />
                    <br />

                    <div id="table_Div" style="position:absolute; left:45%;">

                        <asp:Repeater ID="repeater_Categories" runat="server" OnItemDataBound="repeater_Categories_ItemDataBound">
                            <ItemTemplate>
                                
                                <table id="CateoriesUsersShow" runat="server" style="border:1px solid; border-spacing:1px inherit; border-collapse:collapse; width:400px;">

                                    <tr style="border-bottom: thin solid black;">
                                        <td>
                                            <asp:HiddenField ID="Category_HiddenID" runat="server" />
                                        </td>
                                        <td>
                                            <asp:HyperLink ID="Category_Title" runat="server" NavigateUrl="~/Quizes.aspx"  style="text-decoration:none; color:darkblue; text-align:right;"></asp:HyperLink>
                                        </td>
                                    </tr>

                                    <tr style="border-bottom: thin solid black;">
                                        <td></td>
                                        <td>
                                            <asp:HyperLink ID="Category_Update" runat="server" NavigateUrl="~/CategoryUpdate.aspx" style="text-decoration:none; color:darkblue; text-align:right;">Update</asp:HyperLink>
                                        </td>
                                        <td>
                                            <asp:HyperLink ID="Category_Delete" runat="server" NavigateUrl="~/CategoryDelete.aspx" style="text-decoration:none; color:darkblue;">Delete</asp:HyperLink>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>Description:</td>
                                        <td>
                                            <asp:Label ID="lblDescription" runat="server"></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>Added By:</td>
                                        <td>
                                            <asp:Label ID="lblAddedBy" runat="server"></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>Approved:</td>
                                        <td>
                                            <asp:Label ID="lblApproved" runat="server"></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>Active:</td>
                                        <td>
                                            <asp:Label ID="lblActive" runat="server"></asp:Label>
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