<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuizQuestionOptions.aspx.cs" Inherits="QuizQuestionOptions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Quiz Question Options</title>
    </head>

    <body style="background-color:lightslategrey">
        <form id="form1" runat="server">
            <div id="mainD">
                <div style="width:20%; float:left; height:650px; background-color:lightslategrey;">

                    <div id="div1" runat="server" style="color:white;width:100% ;text-align:left;">
                        <h2>Welcome "
                            <b>
                                <asp:Label ID="lblUserName" runat="server" style="color:white;"></asp:Label>
                            </b>"
                        </h2>
                    </div>
                    
                    <br />

                    <div id="div2" runat="server" style="color:white;width:100% ;text-align:left;">
                        <h4>
                            <b>Category Title:</b>
                                <i><asp:Label ID="lblCategoryTitle" runat="server" style="color:white;"></asp:Label></i>
                            
                            <br />
                        
                            <b>Quiz Title:</b>
                                <i><asp:Label ID="lblQuizTitle" runat="server" style="color:white;"></asp:Label></i>
                        </h4>
                    </div>

                    <br />
                    <br />
                    <a href="QuizQuestionOptionsAdd.aspx" style="text-decoration:none; color:white;">Add New Quiz Question Option</a>
                    <br /><br />

                </div>

                <div  style="width:80%; float:left; height:643px; background-color:lightskyblue; overflow-y:scroll;overflow-x:hidden;">
                    <div id="divQuizQuestionsPanel" runat="server" style="color:white;width:100% ;text-align:center;">
                        <h2>
                            Quiz Question Options Panel
                        </h2>
                    </div>

                    <br />
                    <br />
                    <br />
                    <br />

                    <div id="table_Div" style="position:absolute; left:45%;">

                        <asp:Repeater ID="repeater_QuizQuestionOptionss" runat="server" OnItemDataBound="repeater_QuizQuestionOptionss_ItemDataBound">
                            <ItemTemplate>
                                
                                <table id="QuizQuestionOptionsUsersShow" runat="server" style="border:1px solid; border-spacing:1px inherit; border-collapse:collapse; width:400px;">

                                    <tr style="border-bottom: thin solid black;">
                                        <td>
                                            <asp:HiddenField ID="hfQuizQuestionOptionsID" runat="server" />
                                        </td>
                                        <td>
                                            <asp:HyperLink ID="QuizQuestionOptions_Update" runat="server" NavigateUrl="~/QuizQuestionOptionsUpdate.aspx" style="text-decoration:none; color:darkblue; text-align:right;">Update</asp:HyperLink>
                                        </td>
                                        <td>
                                            <asp:HyperLink ID="QuizQuestionOptions_Delete" runat="server" NavigateUrl="~/QuizQuestionOptionsDelete.aspx" style="text-decoration:none; color:darkblue;">Delete</asp:HyperLink>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>Quiz Question ID:</td>
                                        <td>
                                            <asp:Label ID="lblQuizQuestionId" runat="server"></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>Title:</td>
                                        <td>
                                            <asp:Label ID="lblTitle" runat="server"></asp:Label>
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
