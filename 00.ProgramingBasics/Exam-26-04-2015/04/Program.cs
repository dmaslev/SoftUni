using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main()
        {
            int counter = 0;
            List<string> result = new List<string>();
            string output = string.Empty;
            string first = Console.ReadLine();
            while (first != "START" && first != "start"  )
            {
                first = Console.ReadLine();
            }
            while (true)
            {
                string message = Console.ReadLine();
                if (message != "END" && message != "end")
                {
                    if (message == string.Empty)
                    {
                        continue;
                    }
                    counter++;
                    for (int i = 0; i < message.Length; i++)
                    {
                        char current = message[i];
                        if (current > 64 && current < 78)
                        {
                            output = (char)(current + 13) + output;
                        }
                        else if (current > 77 && current < 91)
                        {
                            output = (char)(current - 13) + output;
                        }
                        else if (current > 96 && current < 110)
                        {
                            output = (char)(current + 13) + output;
                        }
                        else if (current > 109 && current < 123)
                        {
                            output = (char)(current - 13) + output;
                        }
                        else if (current > 47 & current < 72)
                        {
                            output = current + output;
                        }
                        else
                        {
                            char c = ' ';
                            switch (current)
                            {
                                case ' ': c = '+'; break;
                                case ',': c = '%'; break;
                                case '.': c = '&'; break;
                                case '?': c = '#'; break;
                                case '!': c = '$'; break;
                                default:
                                    break;
                            }
                            output = c + output;
                        }
                    }
                    result.Add(output);
                    output = string.Empty;
                }
                else
                {
                    break;
                }
            }          
            if (counter > 0)
            {
                Console.WriteLine("Total number of messages: {0}", counter);
                foreach (var mes in result)
                {
                    Console.WriteLine(mes);
                }
            }
            else
            {
                Console.WriteLine("No messages sent.");
            }
            
        }
    }
}
