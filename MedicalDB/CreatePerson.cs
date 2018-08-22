using InviteUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Medical.Lib.Model
{
    public static class CreatePerson
    {

        public static void CreateNewPerson()
        {
            ServiceUser serviceUser = new ServiceUser();
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("base");

            foreach (results item in serviceUser.InvokeUser())
            {
                //имя
                XmlElement name = doc.CreateElement("name");
                XmlElement fName = doc.CreateElement("fName");
                XmlElement lName = doc.CreateElement("lName");
                fName.InnerText = item.name.first;
                lName.InnerText = item.name.last;
                name.AppendChild(fName);
                name.AppendChild(lName);
                root.AppendChild(name);



                XmlElement login = doc.CreateElement("login");
                login.InnerText = item.name.first + Guid.NewGuid();
                root.AppendChild(login);

                XmlElement password = doc.CreateElement("password");
                password.InnerText = item.name.last + Guid.NewGuid();
                root.AppendChild(login);


            }
            doc.AppendChild(root);
            doc.Save(@"C:\Users\КапашеваД\Documents\Visual Studio 2015\Projects\exam\database.xml");






        }
    }
}