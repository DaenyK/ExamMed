using Medical.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Lib.Model
{
    public class User :IUser
    {
        public User() { }
       public  User(string login, string password, string fullname, MedOrganization MedOrganization)
        {
            this.login = login;
            this.password = password;
            FullName = fullname;
            this.MedOrganization = MedOrganization;
        }

        public DateTime CreatDate { get; set; }

        public DateTime DoB { get; set; }

        public string FullName { get; set; }

        public string IIN { get; set; }

        public bool IsBlock { get; set; }

        public string login { get; set; }

        public string password { get; set; }

        public int role { get; set; }


        public int UserId { get; set; }

        public string WhoCreate { get; set; }

        public int Age()
        {
            return (DateTime.Now.Year - DoB.Year);
        }

        public void BlockUser(bool status)
        {
            //not realise
        }
        public MedOrganization MedOrganization { get; set; }

    }
}
