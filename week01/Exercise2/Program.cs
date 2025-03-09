using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your grade percentage? ");
        string gradeinput = Console.ReadLine();
        int gradeno = int.Parse(gradeinput);

        string gradelet = "";

        if (gradeno >= 90)
        {
            gradelet = "A";
        }  

        else if (gradeno >= 80)
        {
            gradelet = "B";
        } 

        else if (gradeno >= 70)
        {
            gradelet = "C";
        } 

        else if (gradeno >= 60)
        {
            gradelet = "D";
        } 

        else if (gradeno <60)
        {
            gradelet = "F";
        }

        Console.Write($"Your letter grade is {gradelet}. ");

        if (gradeno >= 70)
        {
            Console.Write("Congratulations on passing the course!");
        }
        else if (gradeno <70)
        {
            Console.Write("Well, maybe you'll pass next time!");
        }
    }
}