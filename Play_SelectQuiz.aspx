<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Play_SelectQuiz.aspx.cs" Inherits="Play_SelectQuiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Play: Select Quiz</title>
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
                    <h2>Play: SelectQuiz</h2>
                </div>

                <br />
                <br />

                <div id="div1" runat="server" style="color: white; width: 100%; text-align: center;">
                    <asp:ListBox ID="lbPlay_SelectQuiz" runat="server" OnSelectedIndexChanged="lbPlay_SelectQuiz_SelectedIndexChanged"></asp:ListBox>
                    <br />
                    <br />
                    <asp:Button ID="btnSelectQuiz" runat="server" Text="Select" OnClick="btnSelectQuiz_Click" Style="background-color: lightskyblue; border-color: lightskyblue" />
                </div>
            </div>

        </div>

    </form>
</body>
</html>
