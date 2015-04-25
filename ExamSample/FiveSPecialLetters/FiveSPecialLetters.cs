using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FiveSPecialLetters
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        string[] chars =  { "a", "b", "c", "d", "e" };
        int[] charWeight = { 5, -12, 47, 7, -32 };
        int count = 0;
        int letter = 0;


        for (int ch1 = 0; ch1 < 5; ch1++)
        {
            for (int ch2 = 0; ch2 < 5; ch2++)
            {
                for (int ch3 = 0; ch3 < 5; ch3++)
                {
                    for (int ch4 = 0; ch4 < 5; ch4++)
                    {
                        for (int ch5 = 0; ch5 < 5; ch5++)
                        {
                            string word = chars[ch1] + chars[ch2] + chars[ch3] + chars[ch4] + chars[ch5];
                            string word2 = string.Empty;
                            for (int i = 0; i < 5; i++)
                            {
                                if (!word2.Contains(word[i]))
                                {
                                    word2 = word2 + word[i];
                                }
                                
                            }
                            long currentWeight = 0;

                            for (int k = 0; k < word2.Length; k++)
                            {

                                switch (word2[k])
                                {
                                    case 'a': letter = charWeight[0];
                                        break;
                                    case 'b': letter = charWeight[1];
                                        break;
                                    case 'c': letter = charWeight[2];
                                        break;
                                    case 'd': letter = charWeight[3];
                                        break;
                                    case 'e': letter = charWeight[4];
                                        break;
                                    default:
                                        break;
                                }
                                currentWeight += (k + 1) * letter;

                            }
                            if (currentWeight >= start && currentWeight <= end)
                            {
                                Console.Write(word + " ");
                                count++;
                            }
                        }
                    }
                }
            }
        }
        if (count==0)
        {
            Console.WriteLine("No");
        }
    }
}

