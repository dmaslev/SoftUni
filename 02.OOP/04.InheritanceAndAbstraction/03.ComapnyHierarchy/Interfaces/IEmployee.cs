using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ComapnyHierarchy.Interfaces
{
    interface IEmployee : IPerson
    {
        string Department { get; set; }

        double Salary { get; }
    }
}
