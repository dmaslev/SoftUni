using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EncryptedMatrix
{
    static void Main()
    {
        string message = Console.ReadLine();
        string dash = Console.ReadLine();
        string number = string.Empty;
        for (int i = 0; i < message.Length; i++)
        {
            int currentChar = message[i] % 10;
            number = number + currentChar;
        }
        string encryptedNumber = string.Empty;
        if (message.Length == 1)
        {
            encryptedNumber = "" + message[0] % 10;
            Console.WriteLine(encryptedNumber);
        }
        else
        {


            for (int i = 0; i < number.Length; i++)
            {
                int current = int.Parse(number[i].ToString());
                if (current % 2 == 0)
                {
                    current = current * current;

                }
                else
                {
                    if (i == 0)
                    {
                        current = current + int.Parse(number[i + 1].ToString());
                    }
                    else if (i == number.Length - 1)
                    {
                        current = current + int.Parse(number[i - 1].ToString());
                    }
                    else
                    {
                        current = current + int.Parse(number[i - 1].ToString()) + int.Parse(number[i + 1].ToString());
                    }
                }
                encryptedNumber = encryptedNumber + current;
            }
            if (dash == "\\")
            {
                for (int row = 0; row < encryptedNumber.Length; row++)
                {
                    for (int col = 0; col < encryptedNumber.Length; col++)
                    {
                        if (row == col)
                        {
                            Console.Write(encryptedNumber[row] + " ");
                        }
                        else
                        {
                            Console.Write(0 + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int row = 0; row < encryptedNumber.Length; row++)
                {
                    for (int col = 0; col < encryptedNumber.Length; col++)
                    {
                        if (row + col == encryptedNumber.Length - 1)
                        {
                            Console.Write(encryptedNumber[encryptedNumber.Length - 1 - row] + " ");
                        }
                        else
                        {
                            Console.Write(0 + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

