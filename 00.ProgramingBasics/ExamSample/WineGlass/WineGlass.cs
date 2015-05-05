using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WineGlass
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string top = new string('*', num - 2);
        string firstLine = "\\" + top + "/";
        Console.WriteLine(firstLine);

        for (int i = 1; i < num /2; i++)
        {
            string dots = new string('.', i);
            string middle = new string('*', num - 2 - 2 * i);
            string second = dots + "\\" + middle + "/" + dots;
            Console.WriteLine(second);
 
        }
        if (num>=12)
        {
            for (int i = 0; i < num / 2 - 2; i++)
            {
                string stem = new string('.', (num - 2) / 2);
                Console.WriteLine(stem + "||" + stem);

            }
            string bottom = new string('-', num);
            Console.WriteLine(bottom);
            Console.WriteLine(bottom);

        }
        else
        {
            for (int i = 0; i < num/2 -1 ; i++)
            {
                string stem = new string('.', (num - 2) / 2);
                Console.WriteLine(stem + "||" + stem);
                
            }
            string bottom = new string('-', num);
            Console.WriteLine(bottom);
            
        }



        

    }
}

