using System;

namespace _03.AsynchronousTimer
{
    class AsynchronousTimer
    {
        static void Main()
        {
           
            AsyncTimer printNumber = new AsyncTimer(PrintNumberOnConsole, 33, 500);
            printNumber.Execute();
        }

        

        private static void PrintNumberOnConsole(int n)
        {
            Console.WriteLine(n);
        }
    }
}
