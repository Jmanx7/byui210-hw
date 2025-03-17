using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

        int selection = 0;

        Console.WriteLine("Welcome to the journal program! ");
        Console.WriteLine("Please select one of the following options. ");
        Console.WriteLine("1. Write ");
        Console.WriteLine("2. Display ");
        Console.WriteLine("3. Load ");
        Console.WriteLine("4. Save ");
        Console.WriteLine("5. Quit ");
        Console.WriteLine("Type the number of the option you'd like to select: ");
            selection = int.Parse(Console.ReadLine());

            if (selection == 1)
            {   
                PromptGenerator promptGenerator = new PromptGenerator();
                promptGenerator.GetRandomPrompt();
            }
    }
        
}
