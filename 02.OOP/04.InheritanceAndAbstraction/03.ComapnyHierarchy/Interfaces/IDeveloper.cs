

using System.Collections.Generic;
namespace _03.ComapnyHierarchy.Interfaces
{
    interface IDeveloper
    {
        List<IProject> Projects { get; }

    }
}
