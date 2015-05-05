using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintDeckCards
{
    static void Main()
    {
        char[] suits = { (char)5, (char)4, (char)3, (char)6 };
        
        
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i <11)
                {
                    Console.Write(i + "" + suits[j] + " ");

                }
                else
                {
                    switch (i)
                    {
                        case 11: 
                            Console.Write((char)74 + "" + suits[j] + " ");
                            break;
                        case 12: 
                            Console.Write((char)81 + "" + suits[j] + " ");

                            break;
                        case 13: 
                            Console.Write((char)75 + "" + suits[j] + " ");
                            break;
                        case 14: 
                            Console.Write((char)65 + "" + suits[j] + " ");
                            break;
                        default:
                            break;
                    }
                }
            }

            Console.WriteLine();
        }
    }
}

