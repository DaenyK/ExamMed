using exam.menu;
using Medical.Lib.Model;
using MedicalDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace exam
{
    class Program
    {

        static void Main(string[] args)
        {
            MedOrganization m1 = new MedOrganization();
            m1.NameOfOrganization = "Aimedikus";


            MedOrganization m3 = new MedOrganization();
            m1.NameOfOrganization = "RahatClinic";

            MedOrganization m2 = new MedOrganization();
            m1.NameOfOrganization = "IRM";

            List<User> users = new List<User>();
            users.Add(new User("takitoka", "gh4df54", "Kapasheva Dana", m1));

            users.Add(new User("john56", "sgh4d41s4", "Snow John", m2));

            users.Add(new User("hannahbanana", "dgdg45a4", "Hannah Montana", m3));



            XmlSerializer formatter = new XmlSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream("users.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, users);
             //   Console.WriteLine("объект сериализирован");
            }


            
                ServiseProgram.PrintMenu();

                switch (ServiseProgram.GetPunctMenu())
                {
                    case 1:
                        {
                            ServiseProgram.Autorization();
                        }
                        break;
                    case 2:
                        {
                            if (ServiseUser.Registration(ServiseProgram.GetUserInfoForRegist()))
                            {
                                Console.Clear();
                                Console.WriteLine("register ok");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("register error");
                            }
                        }
                        break;
                
            }

        }


    }
}

