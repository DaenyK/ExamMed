using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using Medical.Lib.Model;

namespace MedicalDB
{
    public class ServiceXMLDoc
    {
        public ServiceXMLDoc()
        {

        }
        public ServiceXMLDoc(string pathDocument)
        {
            this.pathDocument = pathDocument;
        }
        private string pathDocument { get; set; }
        public XmlDocument GetDocument()
        {
            XmlDocument doc = new XmlDocument();

            if (!string.IsNullOrEmpty(pathDocument))
            {
                FileInfo file = new FileInfo(pathDocument);
                if (file.Exists)
                {
                    doc.Load(pathDocument);
                    if (doc.HasChildNodes) //или if(doc.DocumentElement!=null)
                        return doc;
                    else
                    {
                        XmlElement root = doc.CreateElement("user");
                        doc.AppendChild(root);
                        doc.Save(pathDocument);
                        return doc;
                    }
                }
                else
                {
                    using (Stream stream = file.Create())
                    {
                        XmlElement root = doc.CreateElement("user");
                        doc.AppendChild(root);
                    }
                    doc.Save(pathDocument);
                    return doc;
                }
            }
            else { throw new FileNotFoundException(); }
        }

        public void CreateUser(User user)
        {
            string guidUser = Guid.NewGuid().ToString();
            pathDocument = pathDocument + @"\" + guidUser + ".xml";

            XmlDocument doc = GetDocument();
            XmlElement xUser = doc.CreateElement("user");

            XmlElement xFullName = doc.CreateElement("fullName");
            xFullName.InnerText = user.FullName;
            xUser.AppendChild(xFullName);

            XmlElement xLogin = doc.CreateElement("login");
            xLogin.InnerText = user.login;
            xUser.AppendChild(xLogin);

            XmlElement xPassword = doc.CreateElement("password");
            xPassword.InnerText = user.password;
            xUser.AppendChild(xPassword);

            XmlElement xIIN = doc.CreateElement("iin");
            xIIN.InnerText = user.IIN;
            xUser.AppendChild(xIIN);


            XmlElement xNameOfOrganization= doc.CreateElement("organization");
            xIIN.InnerText = user.MedOrganization.NameOfOrganization;
            xUser.AppendChild(xNameOfOrganization);


            doc.DocumentElement.AppendChild(xUser);
            doc.Save(pathDocument);



        }
    }
}




