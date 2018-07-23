<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>
            Main
        </title>
    </head>

    <body style="background-color:lightslategrey">
        <form id="form1" runat="server">

            <div id="mainD">
            
                <div style="width:20%; float:left; height:650px; background-color:lightslategrey;">
                    <asp:Label runat="server" style="color:white;">Welcome </asp:Label> 
                    <b>
                        <asp:Label ID="lblUserName" runat="server" style="color:white;"></asp:Label>
                    </b>
                
                    <br />
                    <br />
                    <br />
                    <br />

                    <a href="Users.aspx" style="text-decoration:none; color:white;">Users</a>
                    <br /><br />
                
                    <a href="Categories.aspx" style="text-decoration:none; color:white;">Categories</a>
                    <br /><br />
                
                    <a href="Play_SelectCategory.aspx" style="text-decoration:none; color:white;">Play</a>
                    <br /><br />
 <%--               
                    <a href="QuizQuestions.aspx" style="text-decoration:none; color:white;">Quiz Questions</a>
                    <br /><br />
                
                    <a href="QuizQuestionOptions.aspx" style="text-decoration:none; color:white;">Quiz Question Options</a>--%>
                </div>
            
                <div  style="width:80%; float:left; height:643px; background-color:lightskyblue;">
                
                </div>

            </div>
      
        </form>
    </body>
</html>
