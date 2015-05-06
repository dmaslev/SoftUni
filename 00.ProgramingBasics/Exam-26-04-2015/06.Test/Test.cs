using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Test
{
    static void Main()
    {
        int counter = 0;
        List<string> words = new List<string>();

        List<string> result = new List<string>();
        string output = string.Empty;
        string first = Console.ReadLine();
        while (first != "START" && first != "start")
        {
            first = Console.ReadLine();
        }
        while (true)
	    {            
	        first = Console.ReadLine();
            if (first != "END" && first != "end")
            {
                if (first == string.Empty)
                {
                    continue;
                }
                else
                {
                    words.Add(first);
                    counter++;

                }
            }
            else
            {
                break;
            }
        
        }
        for (int aa = 0; aa < words.Count; aa++)
        {
            string message = words[aa];
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
                        else if (current > 47 & current < 58)
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

