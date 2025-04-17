using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ListingActivity : Activity{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
    public void StartActivity() {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        SetLength();

        Console.WriteLine("\nGreat ready to list items in");
        Countdown(5);

        Console.WriteLine("Begin.");
        DateTime endTime = DateTime.Now.AddSeconds(GetLength());
        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            count++;
        }
        Console.WriteLine("You listed " + count.ToString() + " items!\n");

        Console.WriteLine("Well Done!");
        AddLengthTotal(GetLength());
        Console.WriteLine("You have just completed " + GetLength().ToString() + " seconds of the Listing Activity\n");
    }
}