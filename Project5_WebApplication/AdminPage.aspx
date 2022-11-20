<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Project5_WebApplication.Staff" %>
<%@ Register TagPrefix ="loadPageControl" TagName ="LastPageReload" src="LastPageReload.ascx" %>
<%@ Register TagPrefix ="navigationBarControl" TagName ="NavigationBar" src="NavigationBar.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Page</title>
     <!--  <link rel ="stylesheet" href ="AdminPage.css" /> -->
</head>
    <body>
        <form id="AdminGUI" runat="server"  style="width:550px; border:groove; padding-left:10px; background-color: lightblue">
            <div>
               <h3> <navigationBarControl:NavigationBar ID="NavigationBar" runat="server" /></h3>
            </div>

            Application Admins will be able to use this GUI to read, add, and remove users from the Staff.xml page

            <br />
            <br />
            <strong>

            <asp:Label ID="lblStaffGuiUser" runat="server" Text="Enter Username"></asp:Label>
            </strong>
            </strong>&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbStaffUser" runat="server"></asp:TextBox>
        <br />
        <br />
            <strong>
        <asp:Label ID="lblStaffGuiPW" runat="server" Text="Enter Password"></asp:Label>
            </strong>&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbStaffPW" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAddToStaffXML" runat="server" Text="ADD" OnClick="btnAddToStaffXML_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRemoveFromStaffXML" runat="server" Text="REMOVE" OnClick="btnRemoveFromStaffXML_Click" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnReadStaffXML" runat="server" OnClick="btnReadStaffXML_Click" Text="READ" />
        <br />

        <p> Reading from XML: <asp:Label ID="lblXMLResult" runat="server" Text="RESULT"></asp:Label></p>
            <p> 
                <asp:Label ID="lblActionResult" runat="server" Text="User Added/Removed"></asp:Label>
            </p>
            <asp:ListBox ID="listBoxStaffMembers" runat="server" Height="84px" Width="528px" OnSelectedIndexChanged="listBoxStaffMembers_SelectedIndexChanged"></asp:ListBox>

            <br />

            <br />

            ---------File Path----<br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        </form>
    </body>
    <loadPageControl:LastPageReload ID="LastPageReload1" runat ="server" />
</html>
