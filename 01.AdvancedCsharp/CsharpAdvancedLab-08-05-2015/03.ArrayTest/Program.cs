namespace Arrays
{
    using System;
    using System.Linq;

    public class ArraysMain
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();
            //changed to stop
            while (!command.Equals("stop"))
            {
                //changed from cw() to command
                string line = command.Trim();
                int[] args = new int[2];
                // moved before if
                string[] stringParams = line.Split(ArgumentsDelimiter);

                //added this line, chamge substract to subtract
                command = stringParams[0];
                if (command.Contains("add") ||
                    command.Contains("subtract") ||
                    command.Contains("multiply"))
                {
                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);

                    //removed
                    //PerformAction(array, command, args);
                }

                PerformAction(array, command, args);

                PrintArray(array);
                //removed
                //Console.WriteLine('\n');

                command = Console.ReadLine();
            }
        }
        //change array name 
        static void PerformAction(long[] array, string action, int[] args)
        {
            //useless
            //long[] array = arr.Clone() as long[];
            //addded -1
            int pos = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            //added 
            long temp = array[array.Length - 1];

            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            //added
            array[0] = temp;

        }

        private static void ArrayShiftLeft(long[] array)
        {
            //added
            long temp = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            //added
            array[array.Length - 1] = temp;

        }

        private static void PrintArray(long[] array)
        {
            //changed 
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
