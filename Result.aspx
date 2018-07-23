<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Result.aspx.cs" Inherits="Result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Result</title>
    </head>
    <body style="background-color: lightslategrey">
        <form id="form1" runat="server">

            <div id="mainD">

                <div style="width: 20%; float: left; height: 650px; background-color: lightslategrey;">
                    <asp:Label runat="server" Style="color: white;">Welcome </asp:Label>
                    <b>
                        <asp:Label ID="lblUserName" runat="server" Style="color: white;"></asp:Label>
                    </b>

                    <br />
                    <br />
                    <br />
                    <br />

                </div>

                <div style="width: 80%; float: left; height: 643px; background-color: lightskyblue;">

                    <div id="divPlay_SelectQuizy" runat="server" style="color: white; width: 100%; text-align: center;">
                        <h2>Your Result</h2>
                    </div>

                    <br />
                    <br />

                    <div id="div1" runat="server" style="color: white; width: 100%; text-align: center;">
                        <h3>
                            Correct Answers:
                        </h3>
                        <asp:Label ID="lblCorrectAnswers" runat="server"></asp:Label>
                        <h3>
                            Wrong Answers:
                        </h3>
                        <asp:Label ID="lblWrongAnswers" runat="server"></asp:Label>
                    </div>
                </div>

            </div>

        </form>
    </body>
</html>
