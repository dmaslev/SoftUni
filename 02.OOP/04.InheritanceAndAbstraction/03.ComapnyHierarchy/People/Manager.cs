using _03.ComapnyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ComapnyHierarchy.People
{
    class Manager : Employee, IManager
    {
        public Manager(string id, string firstName, string lastName, string department, double salary, List<IEmployee> employeesManaged)
            : base(id, firstName, lastName, department, salary)
        {
            this.EmployeesManaged = employeesManaged;
        }

        public Manager(string id, string firstName, string lastName, string department, double salary, IEmployee employeeManaged)
            : this(id, firstName, lastName, department, salary, new List<IEmployee> { employeeManaged })
        {
        }

        public List<IEmployee> EmployeesManaged { get; private set; }

        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("Role: Manager\n");
            result += string.Format("Employees managed: ");

            List<string> employeeNames = new List<string>();
            foreach (var employee in this.EmployeesManaged)
            {
                employeeNames.Add(string.Format("{0} {1}", employee.FirstName, employee.LastName));
            }

            result += string.Join(", ", employeeNames) + "\n";

            return result;
        }
    }
}
