using Medical.Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Lib.Model
{
    public class MedOrganization
    {
        //public int MedOrganizationId { get; set; }
        public string NameOfOrganization { get; set; }

        public List<Patient> Patients = new List<Patient>();
    }
}
