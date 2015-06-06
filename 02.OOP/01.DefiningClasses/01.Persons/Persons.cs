using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
    class Persons
    {
        static void Main()
        {
           
            Person pesho = new Person("pesho", 15);
            //Person pesh0 = new Person("pesho", 15, "af");
            //Person pesh1 = new Person("pesho", -15, "af@");
            Person pesh12 = new Person("pesho", 25, "af@ab.t");



            Console.WriteLine(pesh12);
            
        }
    }
}
