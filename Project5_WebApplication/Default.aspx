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
            <br />
            <asp:Label ID="lbl_username" runat="server" style="z-index: 1; left: 10px; top: 97px; position: absolute; right: 1096px" Text="Username"></asp:Label>
            <asp:TextBox ID="lbl_display_cookie" runat="server" style="z-index: 1; left: 19px; top: 172px; position: absolute"></asp:TextBox>
        <br />
            <br />
            <asp:Button ID="btn_createCookie" runat="server" style="z-index: 1; left: 11px; top: 125px; position: absolute" Text="Login" OnClick="btn_createCookie_Click" />
            <br />
            <br />
            <asp:TextBox ID="tb_username" runat="server" style="z-index: 1; left: 85px; top: 93px; position: absolute"></asp:TextBox>
            <br />
        </form>
        <loadPageControl:LastPageReload ID="LastPageReload1" runat="server" />
    </div>
    <p>Service directory Below</p>
    <embed src="https://www.public.asu.edu/~atiwar22/service_directory1.pdf" width="600" height="500"
        type="application/pdf">
    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;
    </p>

</body>
</html>
