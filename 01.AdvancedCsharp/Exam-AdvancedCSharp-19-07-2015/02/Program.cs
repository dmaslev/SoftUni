using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"\s+");
            input = regex.Replace(input, " ");
            string[] arr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            BigInteger[] numbers = Array.ConvertAll(arr, BigInteger.Parse);
            int currentIndex = 0;
            string command = Console.ReadLine();
            while (command != "stop")
            {
                string[] symbols = command.Split();
                int offset = int.Parse(symbols[0]);
                string operation = symbols[1];
                int opperand = int.Parse(symbols[2]);

                currentIndex += offset;
                if (currentIndex < 0)
                {
                    currentIndex = numbers.Length + currentIndex % numbers.Length;
                }
                if (currentIndex >= numbers.Length)
                {
                    currentIndex = currentIndex % numbers.Length;
                }

                Blala(numbers, currentIndex, opperand, operation);

                command = Console.ReadLine();
            }
            Console.Write("[");
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write("{0}, ", numbers[i]);
            }

            Console.WriteLine("{0}]", numbers[numbers.Length - 1]);
        }

        private static void Blala(BigInteger[] numbers, int currentIndex, int opperand, string operation)
        {
            if (operation == "&")
            {
                numbers[currentIndex] &= opperand;

            }
            if (operation == "|")
            {
                numbers[currentIndex] |= opperand;
            }
            if (operation == "^")
            {
                numbers[currentIndex] ^= opperand;
            }
            if (operation == "+")
            {
                numbers[currentIndex] += opperand;
            }
            if (operation == "-")
            {
                numbers[currentIndex] -= opperand;
                if (numbers[currentIndex] < 0)
                {
                    numbers[currentIndex] = 0;
                }
            }
            if (operation == "*")
            {
                numbers[currentIndex] *= opperand;
            }
            if (operation == "/")
            {
                numbers[currentIndex] /= opperand;
            }

            return;
        }
    }
}
