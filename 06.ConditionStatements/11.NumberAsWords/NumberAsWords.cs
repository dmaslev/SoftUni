using System;

class NumberAsWords
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        switch (num/100)
        {
            case 0: break;
            case 1: Console.Write("One hundred"); break;
            case 2: Console.Write("Two hundred"); break;
            case 3: Console.Write("Three hundred"); break;
            case 4: Console.Write("Four hundred"); break;
            case 5: Console.Write("Five hundred"); break;
            case 6: Console.Write("Six hundred"); break;
            case 7: Console.Write("Seven hundred"); break;
            case 8: Console.Write("Eight hundred"); break;
            case 9: Console.Write("Nine hundred"); break;
            default:
                break;
        }
        if (num%100 > 0 && num/100 > 0)
        {
            Console.Write(" and ");
        }
            if (num % 100< 20)
            {
                switch (num%100)
                {
                    case 1: Console.Write("One"); break;
                    case 2: Console.Write("Two"); break;
                    case 3: Console.Write("Three"); break;
                    case 4: Console.Write("Four"); break;
                    case 5: Console.Write("Five"); break;
                    case 6: Console.Write("Six"); break;
                    case 7: Console.Write("Seven"); break;
                    case 8: Console.Write("Eight"); break;
                    case 9: Console.Write("Nine"); break;
                    case 10: Console.Write("Ten"); break;
                    case 11: Console.Write("Eleven"); break;
                    case 12: Console.Write("Twelve"); break;
                    case 13: Console.Write("Thirteen"); break;
                    case 14: Console.Write("Fourteen"); break;
                    case 15: Console.Write("Fiveteen"); break;
                    case 16: Console.Write("Sixteen"); break;
                    case 17: Console.Write("Seventeen"); break;
                    case 18: Console.Write("Eighteen"); break;
                    case 19: Console.Write("Nineteen"); break;

                    default:
                        break;
                }
            }
            else
            {
                if (num%10==0)
                {
                    switch (num/10%10)
                    {
                        case 2: Console.Write("Twenty"); break;
                        case 3: Console.Write("Thirty"); break;
                        case 4: Console.Write("Fourty"); break;
                        case 5: Console.Write("Fifty"); break;
                        case 6: Console.Write("Sixty"); break;
                        case 7: Console.Write("Seventy"); break;
                        case 8: Console.Write("Eighty"); break;
                        case 9: Console.Write("Ninety"); break;

                        default:
                            break;
                    }
                }
                else
                {
                    switch (num / 10 % 10)
                    {
                        case 2: Console.Write("Twenty"); break;
                        case 3: Console.Write("Thirty"); break;
                        case 4: Console.Write("Fourty"); break;
                        case 5: Console.Write("Fifty"); break;
                        case 6: Console.Write("Sixty"); break;
                        case 7: Console.Write("Seventy"); break;
                        case 8: Console.Write("Eighty"); break;
                        case 9: Console.Write("Ninety"); break;

                        default:
                            break;
                    }

                    switch (num%10)
                    {
                        case 1: Console.Write(" One"); break;
                        case 2: Console.Write(" Two"); break;
                        case 3: Console.Write(" Three"); break;
                        case 4: Console.Write(" Four"); break;
                        case 5: Console.Write(" Five"); break;
                        case 6: Console.Write(" Six"); break;
                        case 7: Console.Write(" Seven"); break;
                        case 8: Console.Write(" Eight"); break;
                        case 9: Console.Write(" Nine"); break;
                        default:
                            break;
                    }
                }
            
        }
        Console.WriteLine();
    }
}

