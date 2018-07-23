<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuizUpdate.aspx.cs" Inherits="QuizUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Update Quiz</title>
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

                    <a href="Quizes.aspx" style="text-decoration:none; color:white;">Go Back</a>

                </div>
            
                <div style="width: 80%; float: left; height: 643px; background-color: lightskyblue;">
                    <div id="divUpdateQuiz" runat="server" style="color:white;width:100% ;text-align:center;"><h2>Update Quiz</h2></div>

                    <br />
                    <br />

                    <h4 style="text-align:center">
                        <asp:Label ID="lblCategoryId" Text="Category Id:    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    " runat="server"></asp:Label>
                        <asp:TextBox ID="tbCategoryId" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvCategoryId" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbCategoryId"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblTitle" Text="Title:    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   " runat="server"></asp:Label>
                        <asp:TextBox ID="tbTitle" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbTitle"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblQuizDesc" Text="Quiz Description:    &nbsp;    " runat="server"></asp:Label>
                        <asp:TextBox ID="tbQuizDesc" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvQuizDesc" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbQuizDesc"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblIsTimeBased" Text="Is Time Based:    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    " runat="server"></asp:Label>
                        <asp:TextBox ID="tbIsTimeBased" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvIsTimeBased" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbIsTimeBased"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblNoOfQuestions" Text="No Of Questions:    &nbsp;&nbsp;    " runat="server"></asp:Label>
                        <asp:TextBox ID="tbNoOfQuestions" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvNoOfQuestions" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbNoOfQuestions"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblIsPublished" Text="Is Published:    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    " runat="server"></asp:Label>
                        <asp:TextBox ID="tbIsPublished" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvIsPublished" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbIsPublished"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:center">
                        <asp:Label ID="lblActive" Text="Active:    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    " runat="server"></asp:Label>
                        <asp:TextBox ID="tbActive" runat="server" style="width:250px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvActive" runat="server" ErrorMessage="Please fill this field!!" ControlToValidate="tbActive"></asp:RequiredFieldValidator>
                    </h4>

                    <h4 style="text-align:right">
                        <asp:Button ID="btnUpdateQuizSubmit" Text="Update" runat="server" onclick="btnUpdateQuizSubmit_Click" style=" top:50%; left:50%; margin-right:32%; margin-top:0px; background-color:lightskyblue; border-color:lightskyblue"/>
                    </h4>
                        
                </div>
            </div>
        </form>
    </body>
</html>
