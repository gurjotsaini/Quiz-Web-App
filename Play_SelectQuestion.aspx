<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Play_SelectQuestion.aspx.cs" Inherits="Play_SelectQuestion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Play: SelectQuestion</title>
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

                    <div id="divPlay_SelectQuwstion" runat="server" style="color: white; width: 100%; text-align: center;">
                        <h2>Play: SelectQuestion</h2>
                    </div>

                    <br />
                    <br />

                    <div id="div1" runat="server" style="color: white; width: 100%; text-align: center;">
                        <asp:Label ID="lblShowQuestion" runat="server"></asp:Label>
                        <br />
                        <br />
                        <asp:CheckBoxList ID="cblPlay_SelectQuestion" runat="server" OnSelectedIndexChanged="cblPlay_SelectQuestion_SelectedIndexChanged"></asp:CheckBoxList>
                        <br />
                        <br />
                        <asp:Button ID="btnPrevious" runat="server" Text="<" OnClick="btnPrevious_Click" Style="background-color: lightskyblue; border-color: lightskyblue" />
                        <asp:Button ID="btnNext" runat="server" Text=">" OnClick="btnNext_Click" Style="background-color: lightskyblue; border-color: lightskyblue" />
                        <br />
                        <br />
                        <asp:Button ID="btnSelectQuestion" runat="server" Text="Submit" OnClick="btnSelectQuestion_Click" Style="background-color: lightskyblue; border-color: lightskyblue" />
                    </div>
                </div>

            </div>

        </form>
    </body>
</html>
