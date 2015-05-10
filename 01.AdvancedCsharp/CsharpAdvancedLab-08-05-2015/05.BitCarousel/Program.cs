namespace Debugging_BitCarousel
{
    using System;

    class BitCarousel_broken
    {
        static void Main()
        {
            byte number = byte.Parse(Console.ReadLine());
            byte rotations = byte.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string direction = Console.ReadLine();

                if (direction == "right")
                {
                    //changed to <<5
                    int rightMostBit = number & 1;
                    number >>= 1;
                    number |= (byte)(rightMostBit << 5);
                    //added this to remove all bits after 6th cell
                    number &= 63;
                }
                else if (direction == "left")
                {
                    //changed to >>5
                    int leftMostBit = (number >> 5) & 1;
                    number <<= 1;
                    number |= (byte)leftMostBit;
                    //added this to remove all bits after 6th cell
                    number &= 63;
                }
            }

            Console.WriteLine(number);
        }
    }
}
