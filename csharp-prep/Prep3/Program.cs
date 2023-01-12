using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 10);
        int shoot = 0;
        while (shoot != number)
        {
        Console.Write("Try Guess the Number:  ");
        shoot = int.Parse(Console.ReadLine());
        if (shoot == number)
        {
            Console.Write("You guessed it!  ");
        }
        if (shoot > number)
        {
            Console.Write("Lower! ");
        }
        if (shoot < number)
        {
            Console.Write("Higher! ");
        }
        }
    }
}