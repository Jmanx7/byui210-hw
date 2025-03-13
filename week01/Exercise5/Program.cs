using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program! ");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        int numinput = -1;
        Console.Write("Please enter your favorite number: ");
        numinput = int.Parse(Console.ReadLine());

        return numinput;
    }

    static int SquareNumber(int numinput)
    {
        int squareresult = numinput * numinput;
        return squareresult;
    }

    static void DisplayResult(string name, int squareresult)
    {
        Console.WriteLine($"{name}, the square of your number is {squareresult}.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();

        string username = PromptUserName();
        int usernumber = PromptUserNumber();

        int squarenumber = SquareNumber(usernumber);

        DisplayResult(username, squarenumber);
    }
}