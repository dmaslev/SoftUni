using _03.ComapnyHierarchy.Interfaces;
using _03.ComapnyHierarchy.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ComapnyHierarchy
{
    class ComapnyHierarchy
    {
        static void Main()
        {
            SalesEmployee retailer = new SalesEmployee("12", "Podlizurko", "Dreben", "Marketing", 500, new Sale("iPod", 340));

            Employee[] employees = 
            {
                retailer,
                new Manager("28882", "Shefa", "Na firmata", "Marketing", 5500, retailer),
                new Developer("534", "Pesho", "Goshev", "Production", 2300, new Project("Project")),
                new SalesEmployee("342", "Ivan", "Grigorov", "Accounting", 1200, new Sale("Nishto", 0)), 
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
