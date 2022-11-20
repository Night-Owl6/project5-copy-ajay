<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NavigationBar.ascx.cs" Inherits="Project5_WebApplication.NavigationBar" %>
<style type="text/css">
    .auto-style1 {
        width: 508px;
        height: 25px;
    }
</style>
&nbsp;&nbsp;<asp:LinkButton ID="linkDefaultPage" runat="server" OnClick="linkDefaultPage_Click">Default Page</asp:LinkButton>
    &nbsp;
<asp:LinkButton ID="linkMemberPage" runat="server" OnClick="linkMemberPage_Click">Member Page</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
<asp:LinkButton ID="lbStaffPage" runat="server" OnClick="lbStaffPage_Click">Staff Page</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
<asp:LinkButton ID="linkAdminPage" runat="server" OnClick="linkAdminPage_Click">Admin Page</asp:LinkButton>
&nbsp;
