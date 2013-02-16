using System;

class FromNumToText
{
    static void Main()
    {

        Console.WriteLine("Enter a positive integer: ");
        int num = int.Parse(Console.ReadLine());

        int hundreds = 0;
        int decs = 0;
        int ones = 0;

        if (num >= 100)
        {
            hundreds = (num / 100) % 10;
            if (num > 120)
            {
                decs = (num / 10) % 10;
                ones = num % 10;
            }
            else
            {
                ones = num % 100;
            }
            
        }
        if (num > 20 && num <= 99)
        {
            decs = (num / 10) % 10;
            ones = num % 10;
        }
        if (num <= 20)
        {
            ones = num;
        }


        switch (hundreds)
        {
            case 1:
                Console.Write("One hundred");
                break;
            case 2:
                Console.Write("Two hundred");
                break;
            case 3:
                Console.Write("Three hundred");
                break;
            case 4:
                Console.Write("Four hundred");
                break;
            case 5:
                Console.Write("Five hundred");
                break;
            case 6:
                Console.Write("Six hundred");
                break;
            case 7:
                Console.Write("Seven hundred");
                break;
            case 8:
                Console.Write("Eight hundred");
                break;
            case 9:
                Console.Write("Nine hundred");
                break;
        }
        if (num >= 100)
        {
            Console.Write(" ");
        }
        if (ones == 0 && num > 100)
        {
            Console.Write("and ");
        }

        switch (decs)
        {
            case 2:
                Console.Write("Twenty");
                break;
            case 3:
                Console.Write("Thirty");
                break;
            case 4:
                Console.Write("Fourty");
                break;
            case 5:
                Console.Write("Fifty");
                break;
            case 6:
                Console.Write("Sixty");
                break;
            case 7:
                Console.Write("Seventy");
                break;
            case 8:
                Console.Write("Eighty");
                break;
            case 9:
                Console.Write("Ninety");
                break;
        }
        if (num > 20 && decs == 0 && ones != 0)
        {
            Console.Write("and ");
        }
        else
        {
            if (num > 20 && ones != 0)
            {
                Console.Write("-");
            }
        }
        if (ones == 0)
        {
            Console.WriteLine("");
        }

        switch (ones)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            case 10:
                Console.WriteLine("Ten");
                break;
            case 11:
                Console.WriteLine("Eleven");
                break;
            case 12:
                Console.WriteLine("Twelve");
                break;
            case 13:
                Console.WriteLine("Thirteen");
                break;
            case 14:
                Console.WriteLine("Fourteen");
                break;
            case 15:
                Console.WriteLine("Fifteen");
                break;
            case 16:
                Console.WriteLine("Sixteen");
                break;
            case 17:
                Console.WriteLine("Seventeen");
                break;
            case 18:
                Console.WriteLine("Eighteen");
                break;
            case 19:
                Console.WriteLine("Nineteen");
                break;
            case 20:
                Console.WriteLine("Twenty");
                break;
        }




    }
}

