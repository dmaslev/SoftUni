using _03.ComapnyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ComapnyHierarchy.People
{
    class Developer : RegularEmployee, IDeveloper
    {
        public Developer(string id, string firstName, string lastName, string department, double salary, List<IProject> projects)
            : base(id, firstName, lastName, department, salary)
        {
            this.Projects = projects;
        }

        public Developer(string id, string firstName, string lastName, string department, double salary, IProject project)
            : this(id, firstName, lastName, department, salary, new List<IProject>() { project })
        {
        }

        public List<IProject> Projects { get; private set; }

        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("Role: Developer\n");
            result += string.Format("Projects: ");

            List<string> projectNames = new List<string>();
            foreach (var proj in this.Projects)
            {
                projectNames.Add(proj.ProjectName);
            }

            result += string.Join(", ", projectNames) + "\n";

            return result;
        }
    }
}
