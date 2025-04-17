using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Added Statistics Menu to view total time spent on activites
internal class Program
{
    static void Main(string[] args) { 
        string input = "";
        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();
        while (input != "5") { 
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1: Start breathing activity");
            Console.WriteLine("2: Start reflecting activity");
            Console.WriteLine("3: Start listing activity");
            Console.WriteLine("4: Activity Statistics");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Select a choice from the menu:");

            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    breathing.StartActivity();
                    break;
                case "2":
                    reflection.StartActivity();
                    break;
                case "3":
                    listing.StartActivity();
                    break;
                case "4":
                    Console.WriteLine("Statistics:");
                    Console.WriteLine("Breathing Activity: " + breathing.GetLengthTotal().ToString() + " Seconds Completed.");
                    Console.WriteLine("Reflection Activity: " + reflection.GetLengthTotal().ToString() + " Seconds Completed.");
                    Console.WriteLine("Listing Activity: " + listing.GetLengthTotal().ToString() + " Seconds Completed.");
                    Console.WriteLine("Total: " + (breathing.GetLengthTotal()+ reflection.GetLengthTotal()+ listing.GetLengthTotal()).ToString() + " Seconds Completed.");
                    break;
                case "5":
                    Console.WriteLine("Thank you for using the program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please Retry.");
                    break;
            }
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
