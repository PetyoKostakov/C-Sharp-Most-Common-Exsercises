using System;

class PositiveSum
{
    static void Main()
    {
        Console.WriteLine("Whrite first positive or negative number");
        int firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Whrite second positive or negative number");
        int secondNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Whrite third positive or negative number");
        int thirdNum = int.Parse(Console.ReadLine());

        if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
        {
            Console.WriteLine("The numbers are equals to 0!");
        }
        else
        {
            int counter = 0;

            if (firstNum < 0)
            {
                counter++;
            }

            if (secondNum < 0)
            {
                counter++;
            }

            if (thirdNum < 0)
            {
                counter++;
            }

            if (counter == 1 || counter == 3)
            {
                Console.WriteLine("The product of numbers is with negative sign");
            }
            else
            {
                Console.WriteLine("The product of numbers is with positive sign");
            }
        }
    }
}

