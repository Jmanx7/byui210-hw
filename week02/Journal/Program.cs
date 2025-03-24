using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Collections;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

        int selection = 0;

        Console.WriteLine("Welcome to the journal program! ");
        Console.WriteLine("Note: If you've already written some entries, ");
        Console.WriteLine("be sure to load that file before writing more. ");

        do
        { 
            Console.WriteLine("Please select one of the following options. ");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");
            Console.WriteLine("Type the number of the option you'd like to select: ");
            selection = int.Parse(Console.ReadLine());

            // Write
            if (selection == 1)
            {   
                theJournal.AddEntry();
            }

            // Display
            else if (selection == 2)
            {
                theJournal.DisplayAll();
            }

            // Load
            else if (selection == 3)
            {
                theJournal.LoadFromFile();
            }

            // Save
            else if (selection == 4)
            {
                theJournal.SaveToFile();
            }

        } while (selection != 5);
        
        Console.WriteLine("Goodbye! ");
    }
        
}
