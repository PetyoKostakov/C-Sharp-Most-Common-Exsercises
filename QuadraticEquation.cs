using System;

class QuadricEquation
{
    static void Main()
    {
        int a;
        do
        {
            Console.WriteLine("Въведете число за \"a\": ");
            a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("стойността на \"а\" трябва да бъде различна от 0! Моля въведете валидна стойност.");
            }
        } while (a == 0);
        Console.WriteLine("Въведете число за \"b\": ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Въведете число за \"c\": ");
        int c = int.Parse(Console.ReadLine());

        double D = (double)Math.Pow(b, 2) - (4 * a * c);
        Console.WriteLine(D);
        double x1 = (((-1) * b) + Math.Sqrt(D)) / (2 * a);
        double x2 = (((-1) * b) - Math.Sqrt(D)) / (2 * a);

        if (D < 0)
        {
            Console.WriteLine("Уравнението няма реални корени!");
        }
        else
        {
            Console.WriteLine("Дискриминантата на квадратното уравнение е: {0}\n Корените на квадратното уравнение са: х1 = {1} и x2 = {2}", D, x1, x2);
        }
    }
}

