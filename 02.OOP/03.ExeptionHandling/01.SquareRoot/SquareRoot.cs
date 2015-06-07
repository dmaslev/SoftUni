using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            //uint a = uint.Parse(Console.ReadLine());
            try
            {
                uint number = uint.Parse(Console.ReadLine());
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine(squareRoot);

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
            
        }
    }
}
