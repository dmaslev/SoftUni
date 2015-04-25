using System;

class FruitMarket
{
    static void Main()
    {
        string day = Console.ReadLine();
        //double quantity1 = double.Parse(Console.ReadLine());
        //string product1 = Console.ReadLine();
        //double quantity2 = double.Parse(Console.ReadLine());
        //string product2 = Console.ReadLine();
        //double quantity3 = double.Parse(Console.ReadLine());
        //string product3 = Console.ReadLine();
        double vegetablePrice = 0;
        double fruitPrice = 0;

        for (int i = 0; i < 3; i++)
        {
            double quantity = double.Parse(Console.ReadLine());
            string product = Console.ReadLine();
            if (product =="banana"  )
            {
                if (day =="Thursday")
                {
                    fruitPrice += (quantity * 1.80) * 0.7;

                }
                else
                {
                    fruitPrice += quantity * 1.80;

                }
            }
            if (product == "orange")
            {
                fruitPrice += quantity * 1.60;
            }
            if (product=="apple")
            {
                fruitPrice += quantity * 0.86;

            }
            if (product =="tomato")
            {
                vegetablePrice += quantity * 3.20;
            }
            if (product =="cucumber")
            {
                vegetablePrice += quantity * 2.75;
            }
        }
        switch (day)
        {
            case "Friday": fruitPrice = fruitPrice * 0.90;
                vegetablePrice = vegetablePrice * 0.90;
                break;
            case "Sunday": fruitPrice = fruitPrice * 0.95;
                vegetablePrice = vegetablePrice * 0.95;
                break;
            case "Tuesday": fruitPrice = fruitPrice * 0.80;
                break;
            case "Wednesday": vegetablePrice = vegetablePrice * 0.90;
                break;
            
            default:
                break;
        }
        Console.WriteLine("{0:F2}", vegetablePrice+ fruitPrice);
        
    }
}

