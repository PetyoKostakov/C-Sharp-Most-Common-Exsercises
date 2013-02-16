using System;

class DiferentUserInput
{
    static void Main()
    {
        Console.WriteLine("What type of varieable do you want ?");
        Console.Write("For int write 1, for double write 2, for String write 3:");
        byte choise = byte.Parse(Console.ReadLine());

        switch (choise)
        {
            case 1:
                Console.Write("Write a int vaiable: ");
                int intVar = int.Parse(Console.ReadLine());
                Console.WriteLine("Your variable was increased with 1 and the value is now: {0}", intVar + 1);
                break;
            case 2:
                Console.WriteLine("Write a double vaiable: ");
                double doubleVar = double.Parse(Console.ReadLine());
                Console.WriteLine("Your variable was increased with 1 and the value is now: {0}", doubleVar + 1);
                break;
            case 3:
                Console.WriteLine("Write a String vaiable: ");
                string stringVar = Console.ReadLine();
                Console.WriteLine("The \"*\" was apended to your variable and the variable is now: {0}{1}", stringVar,"*");
                break;
        }
    }
}

