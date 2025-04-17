using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BreathingActivity : Activity{

    public void StartActivity() {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        SetLength();

        Console.WriteLine("When you are ready, press enter to continue.\n");
        Console.ReadLine();

        for (int i = 0; i < GetLength(); i++)
        {
            Console.WriteLine("Breathe In...");
            Countdown(5);
            Console.WriteLine("Breathe out...");
            Countdown(5);
            Console.WriteLine("");
        }

        Console.WriteLine("Well Done!");
        AddLengthTotal(GetLength()*10);
        Console.WriteLine("You have just completed " + (10 * GetLength()).ToString() + " seconds of the Breathing Activity\n");
    }
}