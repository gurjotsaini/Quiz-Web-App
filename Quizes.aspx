<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Quizes.aspx.cs" Inherits="Quizes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Quizes</title>
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

                    <div id="div2" runat="server" style="color:white;width:100% ;text-align:left;">
                        <h4>Category Title:
                            <b>
                                <asp:Label ID="lblCategoryTitle" runat="server" style="color:white;"></asp:Label>
                            </b>
                        </h4>
                    </div>

                    <br />
                    <br />
                    <a href="QuizesAdd.aspx" style="text-decoration:none; color:white;">Add New Quiz</a>
                    <br /><br />

                </div>

                <div  style="width:80%; float:left; height:643px; background-color:lightskyblue; overflow-y:scroll;overflow-x:hidden;">
                    <div id="divQuizPanel" runat="server" style="color:white;width:100% ;text-align:center;">
                        <h2>
                            Quiz Panel
                        </h2>
                    </div>

                    <br />
                    <br />
                    <br />
                    <br />

                    <div id="table_Div" style="position:absolute; left:45%;">

                        <asp:Repeater ID="repeater_Quizes" runat="server" OnItemDataBound="repeater_Quizes_ItemDataBound">
                            <ItemTemplate>
                                
                                <table id="QuizesUsersShow" runat="server" style="border:1px solid; border-spacing:1px inherit; border-collapse:collapse; width:400px;">

                                    <tr style="border-bottom: thin solid black;">
                                        <td>
                                            <asp:HiddenField ID="hfQuizID" runat="server" />
                                        </td>
                                        <td>
                                            <asp:HyperLink ID="hlQuizTitle" runat="server" NavigateUrl="~/QuizQuestions.aspx"  style="text-decoration:none; color:darkblue; text-align:right;"></asp:HyperLink>
                                        </td>
                                    </tr>

                                    <tr style="border-bottom: thin solid black;">
                                        <td></td>
                                        <td>
                                            <asp:HyperLink ID="Quiz_Update" runat="server" NavigateUrl="~/QuizUpdate.aspx" style="text-decoration:none; color:darkblue; text-align:right;">Update</asp:HyperLink>
                                        </td>
                                        <td>
                                            <asp:HyperLink ID="Quiz_Delete" runat="server" NavigateUrl="~/QuizDelete.aspx" style="text-decoration:none; color:darkblue;">Delete</asp:HyperLink>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>Category ID:</td>
                                        <td>
                                            <asp:Label ID="lblCategoryId" runat="server"></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>Quiz Description:</td>
                                        <td>
                                            <asp:Label ID="lblQuizDesc" runat="server"></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>Is Time Based:</td>
                                        <td>
                                            <asp:Label ID="lblIsTimeBased" runat="server"></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>Number Of Questions:</td>
                                        <td>
                                            <asp:Label ID="lblNoOfQuestions" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    
                                    <tr>
                                        <td>Is Published:</td>
                                        <td>
                                            <asp:Label ID="lblIsPublished" runat="server"></asp:Label>
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
