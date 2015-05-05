using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ZeroSubset
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        bool resultFound = false;

        if (a + b + c + d +e ==0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            resultFound = true;
        }
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            resultFound = true;
        }
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
            resultFound = true;
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
            resultFound = true;
        }
        if (a + b + d + e == 0) 
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
            resultFound = true;
        }
        if (a + c + d + e == 0) 
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
            resultFound = true;
        }
        if (a + b + c == 0) 
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
            resultFound = true;
        }
        if (a + b + d == 0) 
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
            resultFound = true;
        }
        if (a + b + e == 0) 
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
            resultFound = true;
        }
        if (a + c + d == 0) 
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
            resultFound = true;
        }
        if (a + c + e == 0) 
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
            resultFound = true;
        }
        if (a + d + e == 0) 
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
            resultFound = true;
        }
        if (a + b == 0) 
        {
            
            Console.WriteLine("{0} + {1} = 0", a, b);
            resultFound = true;
        }
        if (a + c == 0) 
        {
            Console.WriteLine("{0} + {1} = 0", a, c);
            resultFound = true;
        }
        if (a + d == 0) 
        {
            Console.WriteLine("{0} + {1} = 0", a, d);
            resultFound = true;
        }
        if (a + e == 0) 
        {
            Console.WriteLine("{0} + {1} = 0", a, e);
            resultFound = true;
        }
        if (b + c + d + e == 0) 
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
            resultFound = true;
        }
        if (b + c + d == 0) 
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
            resultFound = true;
        }
        if (b + c + e == 0) 
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
            resultFound = true;
        }
        if (b + d + e == 0) 
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
            resultFound = true;
        }
        if (b + c == 0) 
        {
            Console.WriteLine("{0} + {1} = 0", b, c);
            resultFound = true;
        }
        if (b + d == 0) 
        {
            Console.WriteLine("{0} + {1} = 0", b, d);
            resultFound = true;
        }
        if (b + e == 0) 
        {
            Console.WriteLine("{0} + {1} = 0", b, e);
            resultFound = true;
        }
        if (c + d + e == 0) 
        {
            Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
            resultFound = true;
        }
        if (c + d == 0) 
        {
            Console.WriteLine("{0} + {1} = 0", c, d);
            resultFound = true;
        }
        if (c + e == 0) 
        {
            Console.WriteLine("{0} + {1} = 0", c, e);
            resultFound = true;
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", d, e);
            resultFound = true;
        }
        if (!resultFound)
	{
		 Console.WriteLine("no zero subset found");
	}

    }
}

