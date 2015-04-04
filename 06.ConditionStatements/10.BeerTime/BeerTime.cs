using System;

class BeerTime
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string date = "01/01/2015" + " " + input;
        DateTime convertedDate = DateTime.Parse(date);
        DateTime startbeer = new DateTime(2015, 01, 01, 3, 0, 0);
        DateTime endbeer = new DateTime(2015, 01, 01, 13, 0, 0);
        if (convertedDate >= startbeer && convertedDate < endbeer)
        {
            Console.WriteLine("non-beer time");
        }
        else
        {
            Console.WriteLine("beer time");
        }
	
		 
	
    }
}

