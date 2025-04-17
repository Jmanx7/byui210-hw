using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class ReflectionActivity : Activity{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questsions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
    private string GetRandomQuestion()
    {
        Random rnd = new Random();
        int index = rnd.Next(_questsions.Count);
        return _questsions[index];
    }

    public void StartActivity() { 
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
        SetLength();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(GetRandomPrompt()+"\n");
 

        Console.WriteLine("When you have something in mind, press enter to continue.\n");
        Console.ReadLine();

        for (int i = 0; i < GetLength(); i++) { 
            Console.WriteLine(GetRandomQuestion());
            WaitSpinner(5);
        }

        Console.WriteLine("Well Done!");
        AddLengthTotal(5 * GetLength());
        Console.WriteLine("You have just completed " + (5*GetLength()).ToString() +" seconds of the Reflecting Activity\n");
    }
}