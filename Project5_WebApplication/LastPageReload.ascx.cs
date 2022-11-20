using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5_WebApplication
{
    public partial class LastPageReload : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this should be run every time a page is loaded to show the user the last load date
            string pageName = this.Page.Title.ToString();
            string lastLoadTime = DateTime.Now.ToLongTimeString();
            string lastLoadDate = DateTime.Now.ToLongDateString();

            //printing the date/time onto the "patch"
            this.lblPageName.Text = pageName;
            lblPageName.Font.Bold = true;
            this.lblLoadDate.Text = lastLoadDate;
            this.lblLoadTime.Text = lastLoadTime;


        }
    }
}