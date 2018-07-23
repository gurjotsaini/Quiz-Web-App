<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuizQuestionsAdd.aspx.cs" Inherits="QuizQuestionsAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Add Quiz Questions</title>
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

                    <a href="QuizQuestions.aspx" style="text-decoration:none; color:white;">Go Back</a>

                </div>
            
                <div style="width: 80%; float: left; height: 643px; background-color: lightskyblue;">
                    <div id="divAddQuizes" runat="server" style="color:white;width:100% ;text-align:center;"><h2>Add Quizes</h2></div>

                    <br />
                    <br />

                    <h4 style="text-align:center">
                        <asp:Label ID="lblQuizId" Text="Quiz Id:    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    " runat="server"></asp:Label>
                        <asp:TextBox ID="tbQuizId" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvQuizId" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbQuizId"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblQuesTitle" Text="Question Title:       " runat="server"></asp:Label>
                        <asp:TextBox ID="tbQuesTitle" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvQuesTitle" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbQuesTitle"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblNoOfOptions" Text="No Of Options:        " runat="server"></asp:Label>
                        <asp:TextBox ID="tbNoOfOptions" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvNoOfOptions" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbNoOfOptions"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblCorrectOption" Text="Correct Option:        " runat="server"></asp:Label>
                        <asp:TextBox ID="tbCorrectOption" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvCorrectOption" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbCorrectOption"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:right">
                        <asp:Button ID="btnQuizQuestionSubmit" Text="Submit" runat="server" onclick="btnQuizQuestionSubmit_Click" style=" top:50%; left:50%; margin-right:32%; margin-top:0px; background-color:lightskyblue; border-color:lightskyblue"/>
                    </h4>
                        
                </div>
            </div>
        </form>
    </body>
</html>
