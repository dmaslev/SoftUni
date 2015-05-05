using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayToApplyAtSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            DateTime end = new DateTime(2015,04, 28);
            int daysLeft = end.Day - DateTime.Now.Day;
            Console.WriteLine("{0}, you have only {1} days to apply for the spring semester at Software University!", name, Convert.ToString(daysLeft, 2));
        }
    }
}
