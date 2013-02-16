using System;

class NFactDivKFact
{
    static void Main()
    {
        Console.Write("n = ");
        decimal N = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        decimal K = int.Parse(Console.ReadLine());

        decimal factorialN = 1;
        do
        {
            factorialN *= N;
            N--;
        }
        while (N > 0);

        decimal factorialK = 1;

        do
        {
            factorialK *= K;
            K--;
        }
        while (K > 0);

        decimal res = factorialN / factorialK;

        Console.WriteLine("n! = " + factorialN);
        Console.WriteLine("k! = " + factorialK);
        Console.WriteLine("n!/k! = " + res);
    }
}

