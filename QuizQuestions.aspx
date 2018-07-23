<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuizQuestions.aspx.cs" Inherits="QuizQuestions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Quiz Questions</title>
    </head>
    
    <body style="background-color:lightslategrey">
        <form id="form1" runat="server">
            <div id="mainD"">
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
                    <a href="QuizQuestionsAdd.aspx" style="text-decoration:none; color:white;">Add New Quiz Question</a>
                    <br /><br />

                </div>

                <div  style="width:80%; float:left; height:643px; background-color:lightskyblue; overflow-y:scroll;overflow-x:hidden;">
                    <div id="divQuizQuestionsPanel" runat="server" style="color:white;width:100% ;text-align:center;">
                        <h2>
                            Quiz Questions Panel
                        </h2>
                    </div>

                    <br />
                    <br />
                    <br />
                    <br />

                    <div id="table_Div" style="position:absolute; left:45%;">

                        <asp:Repeater ID="repeater_QuizQuestions" runat="server" OnItemDataBound="repeater_QuizQuestions_ItemDataBound">
                            <ItemTemplate>
                                
                                <table id="QuizQuestionsUsersShow" runat="server" style="border:1px solid; border-spacing:1px inherit; border-collapse:collapse; width:400px;">

                                    <tr style="border-bottom: thin solid black;">
                                        <td>
                                            <asp:HiddenField ID="hfQuizQuestionsID" runat="server" />
                                        </td>
                                        <td>
                                            <asp:HyperLink ID="hlQuizQuestionsTitle" runat="server" NavigateUrl="~/QuizQuestionOptions.aspx"  style="text-decoration:none; color:darkblue; text-align:right;"></asp:HyperLink>
                                        </td>
                                    </tr>

                                    <tr style="border-bottom: thin solid black;">
                                        <td></td>
                                        <td>
                                            <asp:HyperLink ID="QuizQuestions_Update" runat="server" NavigateUrl="~/QuizQuestionsUpdate.aspx" style="text-decoration:none; color:darkblue; text-align:right;">Update</asp:HyperLink>
                                        </td>
                                        <td>
                                            <asp:HyperLink ID="QuizQuestions_Delete" runat="server" NavigateUrl="~/QuizQuestionsDelete.aspx" style="text-decoration:none; color:darkblue;">Delete</asp:HyperLink>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>Quiz Id:</td>
                                        <td>
                                            <asp:Label ID="lblQuizId" runat="server"></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>No Of Options:</td>
                                        <td>
                                            <asp:Label ID="lblNoOfOptions" runat="server"></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>Correct Option:</td>
                                        <td>
                                            <asp:Label ID="lblCorrectOption" runat="server"></asp:Label>
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
