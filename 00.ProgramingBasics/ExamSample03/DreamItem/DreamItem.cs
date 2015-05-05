using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DreamItem
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputAsArray = input.Split('\\');
        string month = inputAsArray[0];
        int workDays = 0;
        switch (month)
        {
            case "Jan": 
            case "Mar":
            case "May":
            case "July":
            case "Aug":
            case "Oct":
            case "Dec":
            case "March":
                workDays = 21;
                break;
            case "Feb":
                workDays = 18;
                break;
            default: workDays = 20;
                break;
        }
        decimal earnedMoney = workDays * decimal.Parse(inputAsArray[1]) * decimal.Parse(inputAsArray[2]);
        if (earnedMoney > 700)
        {
            earnedMoney = earnedMoney * 1.1m;
        }
        decimal itemPrice = decimal.Parse(inputAsArray[3]);
        if (earnedMoney >= itemPrice)
        {
            Console.WriteLine("Money left = {0:F2} leva.", earnedMoney - itemPrice);
        }
        else
        {
            Console.WriteLine("Not enough money. {0:F2} leva needed.", itemPrice - earnedMoney);
            
        }
    }
}

