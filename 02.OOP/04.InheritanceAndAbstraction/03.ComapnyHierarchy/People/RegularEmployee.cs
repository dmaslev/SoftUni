using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ComapnyHierarchy.People
{
    abstract class RegularEmployee : Employee
    {
        protected RegularEmployee(string id, string firstName, string lastName, string department, double salary)
            : base(id, firstName, lastName, department, salary)
        {
        }
    }
}
