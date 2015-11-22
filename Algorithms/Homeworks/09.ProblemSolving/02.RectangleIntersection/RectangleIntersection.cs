namespace _02.RectangleIntersection
{
    using System;
    using System.Linq;

    class RectangleIntersection
    {
        static byte[,] field;
        static void Main()
        {
            int intersectionArea = 0;
            field = new byte[2001, 2001];
            int recCount = int.Parse(Console.ReadLine());
            short[] currentRecParams;
            int maxx;
            int miny;
            int maxy;
            int minx;
            for (int i = 0; i < recCount; i++)
            {
                currentRecParams = Console.ReadLine().Split().Select(short.Parse).ToArray();
                minx = currentRecParams[0];
                maxx = currentRecParams[1];
                miny = currentRecParams[2];
                maxy = currentRecParams[3];

                for (int row = miny; row < maxy; row++)
                {
                    for (int col = minx; col < maxx; col++)
                    {
                        field[row+1000, col+1000]++;
                    }
                }
            }

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row,col] > 1)
                    {
                        ++intersectionArea;
                    }
                }
            }

            Console.WriteLine(intersectionArea);
        }
    }
}
