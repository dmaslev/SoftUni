using _03.ComapnyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ComapnyHierarchy.People
{
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        public SalesEmployee(string id, string firstName, string lastName, string department, double salary, List<ISale> sales)
            : base(id, firstName, lastName, department, salary)
        {
            this.Sales = sales;
        }

        public SalesEmployee(string id, string firstName, string lastName, string department, double salary, ISale sale)
            : this(id, firstName, lastName, department, salary, new List<ISale>() { sale })
        {
        }

        public List<ISale> Sales { get; private set; }

        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("Role: Sales Employee\n");
            result += string.Format("Sales made: {0}\n", this.Sales.Count);
            return result;
        }
    }
}
