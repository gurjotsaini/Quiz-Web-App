<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuizQuestionOptionsUpdate.aspx.cs" Inherits="QuizQuestionOptionsUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Update Quiz Question Options</title>
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

                    <a href="QuizQuestionOptions.aspx" style="text-decoration:none; color:white;">Go Back</a>

                </div>
            
                <div style="width: 80%; float: left; height: 643px; background-color: lightskyblue;">
                    <div id="divUpdateQuizQuestionOption" runat="server" style="color:white;width:100% ;text-align:center;"><h2>Update Quiz Question Option</h2></div>

                    <br />
                    <br />

                    <h4 style="text-align:center">
                        <asp:Label ID="lblQuizQuestionId" Text="Quiz Question Id:       " runat="server"></asp:Label>
                        <asp:TextBox ID="tbQuizQuestionId" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvQuizQuestionId" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbQuizQuestionId"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblTitle" Text="Title:    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    " runat="server"></asp:Label>
                        <asp:TextBox ID="tbTitle" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbTitle"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:right">
                        <asp:Button ID="btnUpdateQuizQuestionOptionSubmit" Text="Submit" runat="server" onclick="btnUpdateQuizQuestionOptionSubmit_Click" style=" top:50%; left:50%; margin-right:32%; margin-top:0px; background-color:lightskyblue; border-color:lightskyblue"/>
                    </h4>
                        
                </div>
            </div>
        </form>
    </body>
</html>
