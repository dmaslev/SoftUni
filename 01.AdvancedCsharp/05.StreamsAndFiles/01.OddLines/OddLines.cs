using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("text.txt");
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 == 1)
                {
                    Console.WriteLine("{0}", line);
                }
                lineNumber++;
                line = reader.ReadLine();
            }
        }
    }
}
