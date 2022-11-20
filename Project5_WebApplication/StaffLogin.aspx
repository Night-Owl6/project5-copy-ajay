<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffLogin.aspx.cs" Inherits="Project5_WebApplication.StaffPage" %>
<%@ Register TagPrefix ="loadPageControl" TagName ="LastPageReload" src="LastPageReload.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Login Page</title>
    <style type="text/css">
        .auto-style1 {
            width: 250px;
            background-color: lightblue;
            padding-left: 15px;
            padding-right: 15px;
            border:groove;
        }

    </style>
</head>
<body>
        <form id="StaffGUI" runat="server" class="auto-style1" >


            Sign in for access to the Staff Page<br />
            <strong>
            <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
            </strong>&nbsp;&nbsp;&nbsp;<br />
            <asp:TextBox ID="tbUserName" runat="server"></asp:TextBox>
            <br />
            <strong>
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            </strong>&nbsp;&nbsp;&nbsp;
            <br />
            <asp:TextBox ID="tbPassWord" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSignIn" runat="server" Text="Sign In" OnClick="btnSignIn_Click" />


            &nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="Persistent" runat="server" Text="Keep me signed in" />


            <br />
            <br />
            Login Status:
            <asp:Label ID="lblLogInResult" runat="server" Text="STATUS"></asp:Label>


        </form>

    <loadPageControl:LastPageReload ID="LastPageReload1" runat ="server" />
</body>
</html>
