using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class MagicDates
{
    static void Main()
    {
        
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int weight = int.Parse(Console.ReadLine());
        int counter = 0;

       

        DateTime startDate = new DateTime(startYear, 1, 1);
        DateTime endDate = new DateTime(endYear, 12, 31);
        DateTime currentDate = startDate;

        
        while (currentDate <= endDate)
        {
            int currentWeight = 0;

            string d = currentDate.Day.ToString() + currentDate.Month.ToString() + currentDate.Year.ToString();
            for (int i = 0; i < d.Length; i++)
            {
                int startDigit = int.Parse(d[i].ToString());
                for (int k = i+1; k < d.Length; k++)
                {
                    int currentDigit = int.Parse(d[k].ToString());
                    currentWeight += startDigit * currentDigit;
                }
                
            }
            

            if (currentWeight == weight)
            {

                Console.WriteLine(currentDate.ToString("dd-MM-yyy"));
                counter++;
            }
            
            currentDate = currentDate.AddDays(1);
        }
        if (counter==0)
        {
            Console.WriteLine("No");
        }
    }
}

