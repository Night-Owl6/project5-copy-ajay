using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Project5_WebApplication
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //used to keep the text hidden when Admin is creating password for staff member
            tbStaffPW.TextMode = TextBoxMode.Password;
        }

        protected void btnAddToStaffXML_Click(object sender, EventArgs e)
        {
            //information to add to the Staff.xml page
            string userToAdd = tbStaffUser.Text;
            string pwToAdd = tbStaffPW.Text;
            
            //XML file path on server
            string fileLocation = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\Staff.xml");

            //uncomment this section if running the app locally, if running the app on Webstrar use value above.
            //location below is based on my LOCAL drive due to this not being a web service, the path in the READ button method uses the web servers address
            //string fileLocation = @"Z:\Page9\App_Data\Staff.xml";

            //used for debugging
            Label1.Text = fileLocation;

            //checks text boxes to make sure they are not empty
            if (string.IsNullOrEmpty(tbStaffUser.Text) || string.IsNullOrEmpty(tbStaffPW.Text))
            {
                lblXMLResult.Text = "ERROR: Invalid or empty string detected in the username or password input!";
            }
            else
            {

                try
                {
                    //if file exists then create a new child node to store the username and passwords in Staff.xml file
                    if (File.Exists(fileLocation))
                    {
                        //xml functions
                        XmlDocument doc = new XmlDocument();
                        doc.Load(fileLocation);

                        //getting root node
                        XmlNode rootNode = doc.SelectSingleNode("StaffMembers");

                        //creating member element and appending to the root node
                        XmlElement member = doc.CreateElement("Member");
                        rootNode.AppendChild(member);

                        //creating the child elements (username and password) within the new Member element
                        XmlElement userName = doc.CreateElement("UserName");
                        userName.InnerText = userToAdd.ToString();
                        member.AppendChild(userName);

                        XmlElement passWord = doc.CreateElement("PassWord");
                        passWord.InnerText = pwToAdd.ToString();
                        member.AppendChild(passWord);

                        //save changes made to the file
                        doc.Save(fileLocation);

                        //feedback
                        lblActionResult.Text = string.Format("User {0} has bee added to the staff list with privs", userToAdd);

                        //this allows for user to remove multiple users from a list and see a refreshed list of users
                        btnReadStaffXML_Click(this, e);
                    }
                    else
                    {
                        lblXMLResult.Text = "FILE NOT FOUND";
                    }
                }
                catch (Exception ex)
                {
                    lblXMLResult.Text = ex.ToString();
                }
            }

        }

        protected void btnRemoveFromStaffXML_Click(object sender, EventArgs e)
        {
            lblXMLResult.Text = string.Format("List Item at index {0} has been selected for removal", listBoxStaffMembers.SelectedIndex);
            int nodeToRemove = listBoxStaffMembers.SelectedIndex;

            //xmlfile path on Webstrar server
            string fileLocation = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\Staff.xml");


            //uncomment this section if running the app locally, if running the app on Webstrar use value above.
            //location below is based on my LOCAL drive due to this not being a web service, the path in the READ button method uses the web servers address
            //string fileLocation = @"Z:\Page9\App_Data\Staff.xml";

            //used for debugging
            //Label1.Text = fileLocation;

            //makes sure the file exists and the user selected an item from the listbox
            if (File.Exists(fileLocation) && listBoxStaffMembers.Items.Count > 0 && listBoxStaffMembers.SelectedIndex >= 0)
            {
                //opening the file
                //FileStream file = new FileStream(fileLocation, FileMode.Open);

                //load the XML doc
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(fileLocation);
                
                //XmlNodeList childNodes = xmlDoc.ChildNodes;
                XmlNode rootNode = xmlDoc.SelectSingleNode("StaffMembers");

                var currentNode = rootNode.ChildNodes[nodeToRemove];

                //remove the child node
                rootNode.RemoveChild(currentNode);

                //save XML File
                xmlDoc.Save(fileLocation);
                //file.Close();


                //
                lblActionResult.Text = string.Format("{0} has been removed from the staff list", listBoxStaffMembers.SelectedValue.ToString());
                //the read function is called here to refresh the listbox items 
                //this allows for user to remove multiple users from a list
                btnReadStaffXML_Click(this, e);
            }
            else
            {
                lblXMLResult.Text = "Error: Either listbox is empty of no user to remove was selected.";
            }



        }

        protected void btnReadStaffXML_Click(object sender, EventArgs e)
        {
            //clear the list box
            listBoxStaffMembers.Items.Clear();

            //put the file name in the web.config appSettings element later
            string fileLocation = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\Staff.xml");

            //uncomment this section if running the app locally, if running the app on Webstrar use value above.
            //string fileLocation = @"d:\sites\content\website36\Page9\App_Data\Staff.xml";

            //used to print the file path (will be disabled in final project)
            Label1.Text = fileLocation;
            

            //call the web service and store the results in the a string list
            //List<string> staffUserList = new List<string>();
            //staffUserList = proxy.staffXMLUsers(fileLocation);
            try
            {
                //using web service that is stored in page 10 of the webstrar server
                XmlServiceProxy.XmlServicesClient proxy = new XmlServiceProxy.XmlServicesClient();

                var staffUserList = proxy.staffXMLUsers(fileLocation);

                if (staffUserList[0] == "FILE NOT FOUND")
                {
                    lblXMLResult.Text = staffUserList[0].ToString();
                }
                else
                {
                    lblXMLResult.Text = string.Format("Staff XML file found with {0} users", staffUserList.Length);
                }

                foreach (var user in staffUserList)
                {
                    listBoxStaffMembers.Items.Add("User: " + user);
                }
            }
            catch (Exception ex)
            {
                listBoxStaffMembers.Items.Add(ex.ToString());
            }


        }

        protected void listBoxStaffMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //do nothin for now
        }
    }
}


/*
 *             string fileLocation = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\Staff.xml");



            if (File.Exists(fileLocation))
            {
                lblXMLResult.Text = "File found!";

                FileStream file = new FileStream(fileLocation, FileMode.Open);

                //
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(file);
                XmlNodeList childNodes = xmlDoc.ChildNodes;

            }
            else
            {
                lblXMLResult.Text = "File NOT found!";
            }
*/

/*
 *             if (File.Exists(fileLocation))
            {
                //clear the listBox before reading and updating it
                listBoxStaffMembers.Items.Clear();

                //feedback that a file was found
                lblXMLResult.Text = "File found!";
                //opening the file
                FileStream file = new FileStream(fileLocation, FileMode.Open);
                
                //
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(file);
                XmlNodeList childNodes = xmlDoc.ChildNodes;

                //loop for each of the nodes in the staff XML page and display the user names
                foreach (XmlNode node in childNodes.Item(1))
                {
                    //listBoxStaffMembers.Items.Add("User: " + node.FirstChild.InnerText + "\tPassWord: " + node.FirstChild.NextSibling.InnerText );
                    listBoxStaffMembers.Items.Add("User Name: " + node.FirstChild.InnerText);
                }

                file.Close();
            }
            else
            {
                //feedback that file was NOT found
                lblXMLResult.Text = "File NOT found!";
            }*/