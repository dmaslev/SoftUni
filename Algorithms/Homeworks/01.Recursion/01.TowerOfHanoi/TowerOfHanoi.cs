using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class TowerOfHanoi
{
    private static int steps = 0;
    private static Stack<int> source;
    private static readonly Stack<int> Destination = new Stack<int>();
    private static readonly Stack<int> Spare = new Stack<int>();

    public static void Main()
    {
        Console.Write("Enter numbers of disks: ");
        int numberOfDisks = int.Parse(Console.ReadLine());
        source = new Stack<int>(Enumerable.Range(1, numberOfDisks).Reverse());
        MoveDisks(numberOfDisks, source, Destination, Spare);
    }

    private static void MoveDisks(int bottomDisk, Stack<int> sourceRod, Stack<int> destinationRod, Stack<int> spareRod)
    {
        if (bottomDisk == 1)
        {
            steps++;
            destinationRod.Push(sourceRod.Pop());
            Console.WriteLine("Step #{0}: Moved disk {1}", steps, bottomDisk);
            PrintRods();
        }
        else
        {
            MoveDisks(bottomDisk - 1, sourceRod, spareRod, destinationRod);
            steps++;
            destinationRod.Push(sourceRod.Pop());
            Console.WriteLine("Step #{0}: Moved disk {1}", steps, bottomDisk);
            PrintRods();
            MoveDisks(bottomDisk - 1, spareRod, destinationRod, sourceRod);
        }
    }

    private static void PrintRods()
    {
        Console.WriteLine("Source: {0}", string.Join(", ", source.Reverse()));
        Console.WriteLine("Destination: {0}", string.Join(", ", Destination.Reverse()));
        Console.WriteLine("Spare: {0}\n", string.Join(", ", Spare.Reverse()));
    }
}