using System;
using System.Collections.Generic;
using System.Linq;

public class Item
{
    public int Weight { get; set; }

    public int Price { get; set; }
}

public class Baba
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        if (input == "END")
        {
            Console.WriteLine(0);
            return;
        }

        var items = new List<Item>();
        while (input != "END")
        {
            var itemInfo = input.Split();
            int count = int.Parse(itemInfo[1]);
            int price = int.Parse(itemInfo[2]);

            items.Add(new Item { Weight = price, Price = count });

            input = Console.ReadLine();
        }

        var itemsTaken = FillKnapsack(items, n - 1);
        Console.WriteLine(itemsTaken.Sum(i => i.Price));
    }

    public static Item[] FillKnapsack(List<Item> items, int capacity)
    {
        var maxPrice = new int[items.Count, capacity + 1];
        var isItemTaken = new bool[items.Count, capacity + 1];

        for (int c = 0; c <= capacity; c++)
        {
            if (items[0].Weight <= c)
            {
                maxPrice[0, c] = items[0].Price;
                isItemTaken[0, c] = true;
            }
        }

        for (int i = 1; i < items.Count; i++)
        {
            for (int c = 0; c <= capacity; c++)
            {
                maxPrice[i, c] = maxPrice[i - 1, c];

                var remainingCapacity = c - items[i].Weight;
                if (remainingCapacity >= 0 &&
                    maxPrice[i - 1, remainingCapacity] + items[i].Price > maxPrice[i - 1, c])
                {
                    maxPrice[i, c] = maxPrice[i - 1, remainingCapacity] + items[i].Price;
                    isItemTaken[i, c] = true;
                }
            }
        }

        var itemsTaken = new List<Item>();
        int itemIndex = items.Count - 1;
        while (itemIndex >= 0)
        {
            if (isItemTaken[itemIndex, capacity])
            {
                itemsTaken.Add(items[itemIndex]);
                capacity -= items[itemIndex].Weight;
            }

            itemIndex--;
        }

        itemsTaken.Reverse();

        return itemsTaken.ToArray();
    }
}