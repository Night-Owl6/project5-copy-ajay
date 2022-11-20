using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace XMLWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : XmlServices
    {
        public List<string> staffXMLUsers(string fileName)
        {
            //initializing the List
            List<string> staffUsersList = new List<string>();

            //string fileLocation = @"C:\Users\gokus\source\repos\Project5_Group36_WebApplication\Project5_WebApplication\App_Data\Staff.xml";
            string fileLocation = fileName;

            if (File.Exists(fileLocation))
            {
                //staffUsersList.Add("FILE FOUND");
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
                    staffUsersList.Add(node.FirstChild.InnerText.ToString());
                }

                //closing file
                file.Close();
            }
            else
            {
                staffUsersList.Add("FILE NOT FOUND");
            }


            //return the string list
            return staffUsersList;
        }

        public bool accountVerification(string fileName, string userName, string passWord)
        {
            //bool
            bool userNameValidation = false;
            bool pwValidation = false;

            //string fileLocation = @"C:\Users\gokus\source\repos\Project5_Group36_WebApplication\Project5_WebApplication\App_Data\Staff.xml";
            string fileLocation = fileName;

            if (File.Exists(fileLocation))
            {
                FileStream fs = new FileStream(fileLocation, FileMode.Open);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(fs);
                XmlNode node = xmlDoc;
                XmlNodeList children = node.ChildNodes;

                foreach (XmlNode child in children.Item(1))
                {
                    //search for username
                    if (userName == child.FirstChild.InnerXml)
                    {
                        userNameValidation = true;

                        if (passWord == child.FirstChild.NextSibling.InnerText)
                        {
                            pwValidation = true;
                            fs.Close();
                            return (userNameValidation && pwValidation);
                        }
                    }
                }

                fs.Close();
                return userNameValidation && pwValidation;
            }
            else
            {
                return false;
            }
        }
    }
}
