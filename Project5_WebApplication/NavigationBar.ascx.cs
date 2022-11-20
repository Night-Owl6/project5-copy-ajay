using System;

namespace Project5_WebApplication
{
    public partial class NavigationBar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void linkDefaultPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void lbStaffPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Protected/StaffPage.aspx");
        }

        protected void linkAdminPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminPage.aspx");
        }

        protected void linkMemberPage_Click(object sender, EventArgs e)
        {
            //add code here for member page
            Response.Redirect("~/MemberPage.aspx");
        }
    }
}