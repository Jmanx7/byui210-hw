using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicno = randomGenerator.Next(1,10);

        int guess = -1;

        do
        {
            Console.Write("What's your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicno)
            {
                Console.Write("Lower! ");
            }

            else if (guess < magicno)
            {
                Console.Write("Higher! ");
            }
        } while (guess != magicno); 

        Console.Write("You got it! ");
    }
}