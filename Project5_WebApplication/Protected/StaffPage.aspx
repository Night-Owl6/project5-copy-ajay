<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffPage.aspx.cs" Inherits="Project5_WebApplication.StaffPage1" %>
<%@ Register TagPrefix ="loadPageControl" TagName ="LastPageReload" src="../LastPageReload.ascx" %>
<%@ Register TagPrefix ="navigationBarControl" TagName ="NavigationBar" src="../NavigationBar.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Page</title>
</head>
<body>
    <form id="StaffGui" runat="server" style="width:550px; border:groove; padding-left:10px; background-color: lightblue">
        <div>
            <h3><navigationBarControl:NavigationBar ID="NavigationBar" runat="server" /></h3>
        </div>
        <div>
            Congrats! You have entered the Staff Page with your credentials!
            <br />
            Current User: <%Response.Write(Context.User.Identity.Name); %>
            <br />
            <br />
            <asp:Button ID="btnSignOut" runat="server" OnClick="btnSignOut_Click" Text="Sign Out" />
        </div>
    </form>
</body>
    <loadPageControl:LastPageReload ID="LastPageReload1" runat ="server" />
</html>
