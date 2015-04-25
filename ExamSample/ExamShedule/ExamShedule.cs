using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExamShedule
{
    static void Main()
    {
        int startHour = int.Parse(Console.ReadLine());
        int startMinute = int.Parse(Console.ReadLine());
        string partDay = Console.ReadLine();
        int examHour = int.Parse(Console.ReadLine());
        int exmaMinute = int.Parse(Console.ReadLine());

        


        if (partDay =="PM")
        {
            startHour += 12;
        }

        DateTime date = new DateTime(2015, 03, 28, startHour, startMinute, 0);
        DateTime endExam = date.AddHours(examHour).AddMinutes(exmaMinute);
        
      
        
        Console.WriteLine(endExam.ToString("hh:mm:tt"));

       

    }
}

