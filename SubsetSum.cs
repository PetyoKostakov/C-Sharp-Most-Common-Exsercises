using System;
using System.Collections;

class SubsetSum
{
    static void Main()
    {
        Console.Write("Write how much numbers do you want to check:");
        int countOfNumbers = int.Parse(Console.ReadLine());     
        int number, arrayLength;             
        ArrayList numbers = new ArrayList();    
        ArrayList sum = new ArrayList();        

        Console.WriteLine("Въведете {0} числа, различни от 0.", countOfNumbers);
        int i = 1;
        
        do
        {
            Console.Write("Число {0}: ", i);
            if (int.TryParse(Console.ReadLine(), out number) && (number != 0))
            {
                i++;
                arrayLength = numbers.Count;
                numbers.Add(number);
                sum.Add(number.ToString());

                for (int j = 0; j < arrayLength; j++)
                {
                    numbers.Add((int)numbers[j] + number);
                    sum.Add((string)sum[j] + " + " + number.ToString());
                }
            }
        } while (i <= countOfNumbers);

        Console.WriteLine("The numbers which subset sum is 0 are: ");
        bool flag = false;

        for (i = 0; i < sum.Count; i++)
        {
            if ((int)numbers[i] == 0)
            {
                flag = true;
                Console.WriteLine("{0} = {1}", (string)sum[i], (int)numbers[i]);
            }
        }
        if (!flag)
        {
            Console.WriteLine("There is no numbers which subset sum is 0!");
        }
    }
}