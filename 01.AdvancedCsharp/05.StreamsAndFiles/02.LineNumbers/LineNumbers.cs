using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader("text.txt");
        using (reader)
        {
            int lineNumber = 0;
            StreamWriter write = new StreamWriter("written.txt");
            using (write)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    write.WriteLine("{0}. {1}", lineNumber, line);
                    lineNumber++;
                    line = reader.ReadLine();

                }
            }
        }
    }
}

