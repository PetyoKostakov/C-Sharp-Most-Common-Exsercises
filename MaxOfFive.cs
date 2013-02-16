using System;

class MaxOfFive
{
    static void Main()
    {
        {
            int maxNum = 0;

            for (int i = 1; i < 6; i++)
            {
                Console.Write("Enter digit {0} to find the Max of 5 numbers: ",i);
                int number = int.Parse(Console.ReadLine());

                if (number > maxNum)
                {
                    maxNum = number;
                }
            }
            Console.WriteLine("The greatest number is: {0}", maxNum);
        }
    }
}

