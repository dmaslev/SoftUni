using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.ComapnyHierarchy.Interfaces
{
    internal interface IProject
    {
        string ProjectName { get; }

        DateTime ProjectStartDate { get; }

        string Details { get; }

        ProjectState ProjectState { get; }
    }
}
