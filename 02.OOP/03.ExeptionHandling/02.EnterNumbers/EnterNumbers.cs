using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            int start = 0;

            for (int i = 0; i < 10; )
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    ReadNumber(start, number);
                    start = number;
                    i++;

                }
                catch (Exception)
                {
                    Console.WriteLine("Try again");
                    //throw;
                }
            }
        }

        private static void ReadNumber(int start, int number)
        {
            if (number <= start || number >= 101)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
