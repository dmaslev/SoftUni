using _03.ComapnyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ComapnyHierarchy
{
    class Employee : Person, IEmployee
    {
        private double salary;
        private string department;

        public Employee(string id, string firstName, string lastName,  string department, double salary)
            : base(id, firstName, lastName)
        {
            this.Department = department;
            this.Salary = salary;

        }
        public string Department { get; set; }

        public double Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("salary", "Salary cannot be negative.");
                }

                this.salary = value;
            }
        }
    }
}
