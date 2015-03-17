using System;

class BitsExchange
{
    static void Main()
    {
        long num = long .Parse(Console.ReadLine()); 
        int p =  int.Parse(Console.ReadLine()); 
        int q =  int.Parse(Console.ReadLine());
        int k =  int.Parse(Console.ReadLine());  
        if ((p + k) > 32 || p < 0 || q <0 || q + k >32)
        {
            Console.WriteLine("Out of range");
        }
        else if (p + k < q || q + k < p)
        {
            Console.WriteLine("overlapping");
        }
        else
        {
            // Creating array with length k and filling it with 1 (for k = 3 kArray = {1, 1, 1})
            int[] kArray = new int[k];
            for (int i = 0; i < k; i++)
            {
                kArray[i] = 1;
            }
            int mask = 0;
            for (int i = 0; i < kArray.Length; i++)
            {
                mask += kArray[i] * Convert.ToInt32(Math.Pow(10, kArray.Length - i - 1));
            }
            string mask2 = Convert.ToString(mask);
            mask = Convert.ToInt32(mask2, 2);
            long pBits = num & (mask << p);
            long qBits = num & (mask << q);

            //Zanulqvane na bitovete

            num = num & ~ (mask << p | mask << q);

            // Prisvoqvane na pBits i qBits 
            long result = 0;
            if (p < q)
            {
                 result = num | (pBits << q - p) | (qBits >> q - p);

            }
            else
            {
                result = num | (pBits >> p - q) | (qBits << p - q);
            }
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
            Console.WriteLine(result);


            
        }
        
    }
}

