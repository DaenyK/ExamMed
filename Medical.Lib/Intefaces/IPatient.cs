using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Lib.Interfaces
{
    public interface IPatient
    {
        int UserId { get; set; }
        string FullName { get; set; }
        DateTime DoB { get; set; }
        string IIN { get; set; }
        int Age();
    }
}
