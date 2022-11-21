<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project5_WebApplication.WebForm1" %>

<%@ Register TagPrefix="loadPageControl" TagName="LastPageReload" Src="LastPageReload.ascx" %>
<%@ Register TagPrefix="navigationBarControl" TagName="NavigationBar" Src="NavigationBar.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default Page</title>
</head>
<body>
    <div>
        <form id="form1" runat="server">
            <div>
                <asp:Button ID="btn_memberPage" runat="server" Text="Member Page" Height="60px" Width="160px" OnClick="btn_memberPage_Click" BackColor="#66CCFF" Font-Bold="True" Font-Size="Medium" />
                <asp:Button ID="btn_staffPage" runat="server" Text="Staff Page" Height="60px" Width="160px" OnClick="btn_staffPage_Click" BackColor="#66CCFF" Font-Bold="True" Font-Size="Medium" />
                <asp:Button ID="btn_adminPage" runat="server" Text="Adming Page" Height="60px" Width="160px" OnClick="btn_adminPage_Click" BackColor="#66CCFF" Font-Bold="True" Font-Size="Medium" />
            </div>


        </form>
        <br />
        <loadPageControl:LastPageReload ID="LastPageReload1" runat="server" />
    </div>

    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;
    </p>

</body>
</html>
