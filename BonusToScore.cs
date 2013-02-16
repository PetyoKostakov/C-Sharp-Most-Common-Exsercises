using System;


class BonusToScore
{
    static void Main()
    {
        Console.Write("Write score from 1 to 9 to add a bonus: ");
        int score;
        int.TryParse(Console.ReadLine(), out score);
        int bonusScore = score;

        switch (score)
        {
            case 1:
            case 2:
            case 3:
                bonusScore *= 10;
                break;
            case 4:
            case 5:
            case 6:
                bonusScore *= 100;
                break;
            case 7:
            case 8:
            case 9:
                bonusScore *= 1000;
                break;
            default:
                Console.WriteLine("The writen is incorect!");
                break;
        }
        if(score >= 1 && score <=9)
        {
            Console.WriteLine("The score {0} with bonus is {1}", score, bonusScore);
        }
        
    }
}

