using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("hexadecimal = ");
        string hexadecimal = Console.ReadLine();
        long result = 0;
        int step = 0;

        for (int i = hexadecimal.Length; i > 0; i--)
        {
            int num = 0;
            switch (hexadecimal[i-1])
            {                   
                case '1': num = 1;  break;
                case '2': num = 2; break;
                case '3': num = 3; break;
                case '4': num = 4; break;
                case '5': num = 5; break;
                case '6': num = 6; break;
                case '7': num = 7; break;
                case '8': num = 8; break;
                case '9': num = 9; break;
                case 'A': 
                case 'a':
                    num = 10; break;
                case 'B':
                case 'b':
                    num = 11; break;
                case 'C':
                case 'c':
                    num = 12; break;
                case 'D':
                case 'd':
                    num = 13; break;
                case 'E':
                case 'e':
                    num = 14; break;
                case 'F':
                case 'f':
                    num = 15; break;                
                default:
                    break;                    
            }
            result += num * (long)Math.Pow(16, step);
            step++;
            
        }
        Console.WriteLine(result);
    }
}

