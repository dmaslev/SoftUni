using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    class Trainer : Person
    {
        public void CreateCOurse(string course)
        {
            Console.WriteLine("{0} course was created", course);
        }
    }
}
