<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberPage.aspx.cs" Inherits="Project5_WebApplication.MemberPage" %>
<%@ Register TagPrefix ="loadPageControl" TagName ="LastPageReload" src="LastPageReload.ascx" %>
<%@ Register TagPrefix ="navigationBarControl" TagName ="NavigationBar" src="NavigationBar.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Member Page</title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <h3><navigationBarControl:NavigationBar ID="NavigationBar" runat="server" /></h3>
        </div>
        <div>
            Member Page will be created by Pramith.</div>
    </form>
    <div>
        <loadPageControl:LastPageReload ID="LastPageReload1" runat ="server" />
    </div>
</body>
</html>
