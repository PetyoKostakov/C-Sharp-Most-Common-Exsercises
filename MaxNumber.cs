using System;

class MaxNumber
{
    static void Main()
    {
        Console.WriteLine("Write first number for Max check: ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Write second number for Max check: ");
        int secondNum = int.Parse(Console.ReadLine());

        int maxNum = firstNum;
        if (secondNum > firstNum)
        {
            maxNum = secondNum;
        }
        Console.WriteLine("The Max number of {0} and {1} is {2}", firstNum, secondNum, maxNum);
    }
}

