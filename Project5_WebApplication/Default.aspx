<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project5_WebApplication.WebForm1" %>
<%@ Register TagPrefix ="loadPageControl" TagName ="LastPageReload" src="LastPageReload.ascx" %>
<%@ Register TagPrefix ="navigationBarControl" TagName ="NavigationBar" src="NavigationBar.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3><navigationBarControl:NavigationBar ID="NavigationBar" runat="server" /></h3>
        </div>
        <div>
            <p>
                Default Page to be completed by Ajay</p>
            <p>
                Description of application</p>
            <p> This is added by me - ajay</p>
        </div>


    </form>
    <div>
        <loadPageControl:LastPageReload ID="LastPageReload1" runat ="server" />
    </div>

</body>
</html>
