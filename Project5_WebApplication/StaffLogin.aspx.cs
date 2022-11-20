using System;
using System.IO;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace Project5_WebApplication
{
    public partial class StaffPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tbPassWord.TextMode = TextBoxMode.Password;
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            //invoke the XML read and user/pass validation web service
            XmlServiceProxy.XmlServicesClient proxy = new XmlServiceProxy.XmlServicesClient();

            //put the file name in the web.config appSettings element later
            string fileLocation = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\Staff.xml");

            //uncomment this section if running the app locally, if running the app on Webstrar use value above.
            //string fileLocation = @"d:\sites\content\website36\Page9\App_Data\Staff.xml";

            //get the user name and password
            string userName = tbUserName.Text.ToString();
            string passWord = tbPassWord.Text.ToString();
            bool loginStatus = false;
            //bool persistant = Persistent.Checked;

            if (string.IsNullOrEmpty(tbUserName.Text) || string.IsNullOrEmpty(tbPassWord.Text))
            {
                lblLogInResult.Text = "Error: empty string detected in either username or password";
            }
            else
            {
                //lblLogInResult.Text = "Logging you in...";
                loginStatus = proxy.accountVerification(fileLocation, userName, passWord);
                lblLogInResult.Text = loginStatus.ToString();
            }

            if (proxy.accountVerification(fileLocation, userName, passWord))
                FormsAuthentication.RedirectFromLoginPage(userName, Persistent.Checked);
            else
                lblLogInResult.Text = "Invalid Login entered";

            //if(Forms.)
            //lblLogInResult.Text = loginStatus.ToString();
        }
    }
}