using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numinput = -1;

        Console.WriteLine("Please input a list of numbers. When done, input a 0. ");

        do
        {
            Console.Write("Input a number. ");
            numinput = int.Parse(Console.ReadLine());
            if (numinput != 0)
            {
                numbers.Add(numinput);
            }

        } while (numinput != 0);

        int total = 0;
        foreach (int number in numbers)
        {
            total = total + number;
        }

        int numberofnumbers = numbers.Count;
        int numbermean = total / numberofnumbers;

        int highest = -1;
        foreach (int number in numbers)
        {
            if (number > highest)
            {
                highest = number;
            }
        }

        Console.Write($"The sum is {total}. ");
        Console.Write($"The average is {numbermean}. ");
        Console.Write($"The largest number is {highest}. ");

    }
}