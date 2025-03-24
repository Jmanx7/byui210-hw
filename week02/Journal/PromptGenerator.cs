using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the highlight of your day? ",
        "What's something new you learned today? ",
        "What's something you regret doing today? ",
        "What's something you're looking forward to in the near future? ",
        "What did you do that you're proud of today? ",
        "What challenge did you face today? ",
        "Who did you spend time with today? "
    };
    
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int randIndex = rnd.Next(_prompts.Count);
        string randomprompt = _prompts[randIndex];
        Console.WriteLine($"{randomprompt}");
        //Entry Entry = new Entry();
        //Entry._promptText = randomprompt;
        return randomprompt;
    }
    // used for help with random function https://www.techiedelight.com/access-random-item-in-list-in-csharp/
}