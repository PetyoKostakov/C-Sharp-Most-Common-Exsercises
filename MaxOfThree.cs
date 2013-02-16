using System;

class MaxOfThree
{
    static void Main()
    {
        Console.WriteLine("Whrite first number");
        int firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Whrite second number");
        int secondNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Whrite third number");
        int thirdNum = int.Parse(Console.ReadLine());

        int maxNum = firstNum;
        if (secondNum > maxNum)
        {
            maxNum = secondNum;
        }
        if (thirdNum > maxNum)
        {
            maxNum = thirdNum;
        }

        Console.WriteLine("The Max number of {0}, {1} and {2} is: {3}", firstNum, secondNum, thirdNum, maxNum);
    }
}

