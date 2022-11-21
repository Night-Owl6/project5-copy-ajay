using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5_WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Print the number of sessions that are open and display on the top of the page
            Response.Write("Number of sessions open: " + Application["session_count"].ToString());

            //Setting expiry date for the UserProfile cookies
            Response.Cookies["UserProfile"].Expires = DateTime.Now.AddDays(-1);

        }

        protected void btn_memberPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberPage.aspx");
        }

        protected void btn_staffPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffLogin.aspx");
        }

        protected void btn_adminPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage.aspx");
        }

        protected void btn_createCookie_Click(object sender, EventArgs e)
        {
            // Creating and storing UserProfile cookies 

            Response.Cookies["UserProfile"][tb_username.Text] = tb_username.Text;

            //Fetching coookies 

            if (Request.Cookies["UserProfile"].Value.ToString() != null)
            {
                lbl_display_cookie.Text += Request.Cookies["UserProfile"].Value.ToString() + " | ";
            }
        }
    }
}
