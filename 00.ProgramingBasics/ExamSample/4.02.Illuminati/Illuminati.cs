using System;

class Illuminati
{
    static void Main()
    {
        string message = Console.ReadLine();
        int couunter = 0;
        int result = 0;
        for (int i = 0; i < message.Length; i++)
        {
            if (message[i] == 'A' || message[i] == 'a')
            {
                couunter++;
                result += 65;
            }
            if (message[i] == 'E' || message[i] == 'e')
            {
                couunter++;
                result += 69;
            }
            if (message[i] == 'I' || message[i] == 'i')
            {
                couunter++;
                result += 73;
            }
            if (message[i] == 'O' || message[i] == 'o')
            {
                couunter++;
                result += 79;
            }
            if (message[i] == 'U' || message[i] == 'u')
            {
                couunter++;
                result += 85;
            }
          
        }
        Console.WriteLine(couunter);
        Console.WriteLine(result);
    }
}

