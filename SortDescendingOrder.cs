using System;

class SortDescendingOrder
{
    static void Main()
    {
        Console.Write("Write first number for storting:");
        int firstNum = int.Parse(Console.ReadLine());

        Console.Write("Write second number for storting:");
        int secondNum = int.Parse(Console.ReadLine());

        Console.Write("Write third number for storting:");
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

        int minNum = firstNum;
        if (secondNum < minNum)
        {
            minNum = secondNum;
        }
        if (thirdNum < minNum)
        {
            minNum = thirdNum;
        }

        int midNum = 0;
        if (firstNum > minNum && firstNum < maxNum)
        {
            midNum = firstNum;
        }
        if (secondNum > minNum && secondNum < maxNum)
        {
            midNum = secondNum;
        }
        if (thirdNum > minNum && thirdNum < maxNum)
        {
            midNum = thirdNum;
        }
        Console.WriteLine("The descending order of writen numbers is: {0}, {1}, {2}", minNum, midNum, maxNum);
    }
}

