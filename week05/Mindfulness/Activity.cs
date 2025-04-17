using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class Activity {
    private int _length;
    private int _totalLength;

    public void AddLengthTotal(int len)
    {
        _totalLength += len;
    }
    public int GetLengthTotal()
    {
        return _totalLength;
    }

    public void SetLength()
    {
        Console.WriteLine("how long would you like to do this activity?");
        _length = Convert.ToInt32(Console.ReadLine());
    }
    public int GetLength()
    {
        return _length;
    }
    //spinning animation
    public void WaitSpinner(int seconds)
    {
        List<String> characters = new List<String> {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\"
        };
        //display spinning animation for specified duration
        for (int i = 0; i < seconds; i++) {
            for (int i2 = 0; i2 < characters.Count; i2++)
            {
                Console.Write("\b" + characters[i2]);
                //should last 1 second
                Thread.Sleep(125);
            }
            Console.Write("\b");
        }
    }

    public void Countdown(int seconds)
    {

        for (int i = 0; i < seconds; i++)
        {
            Console.Write("\b" + (seconds-i).ToString());
            Thread.Sleep(1000);
           
        }
        Console.Write("\b \b");
    }
}