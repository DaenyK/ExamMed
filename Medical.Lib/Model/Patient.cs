using Medical.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Lib.Model
{
    public class Patient : IPatient
    {
        public int PationId { get; set; }
        public DateTime DoB { get; set; }

        public string FullName { get; set; }

        public string IIN { get; set; }


        public int UserId { get; set; }

        public int Age()
        {
            return (DateTime.Now.Year - DoB.Year);
        }

        public int MedOrganizationId { get; set; } = 0;
    }
}
