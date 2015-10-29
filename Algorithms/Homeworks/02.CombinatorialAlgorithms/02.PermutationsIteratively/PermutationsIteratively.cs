namespace _02.PermutationsIteratively
{
    using System;
    using System.Linq;

    class PermutationsIteratively
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var numbersArray = Enumerable.Range(1, n).ToArray();
            var controlArray = Enumerable.Range(0, n + 1).ToArray();
            int index = 1;
            int j;
            int countOfPermutations = 1;
            Console.WriteLine(string.Join(", ", numbersArray));

            while (index < n)
            {
                controlArray[index]--;
                j = index % 2 * controlArray[index];
                Swap(ref numbersArray[j], ref numbersArray[index]);

                index = 1;
                while (controlArray[index] == 0)
                {
                    controlArray[index] = index;
                    ++index;
                }

                countOfPermutations++;
                Console.WriteLine(string.Join(", ", numbersArray));
            }

            Console.WriteLine($"Total permutations: {countOfPermutations}");
        }

        private static void Swap(ref int v1, ref int v2)
        {
            v1 ^= v2;
            v2 ^= v1;
            v1 ^= v2;
        }
    }
}