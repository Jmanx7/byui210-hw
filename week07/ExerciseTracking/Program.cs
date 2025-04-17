using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
    static void Main(string[] args)
    {
        List<Activity> activties = new List<Activity> {
            new Running("03 Nov 2022", 30, 3.0),
            new Running("03 Nov 2022", 30, 4.8),
            new Cycling("24 Nov 2022", 20, 19.7),
            new Swimming("06 Dec 2022", 60, 15)
        }
        ;

        for (int i = 0; i < activties.Count(); i++) {
            Console.WriteLine(activties[i].GetSummary());
        }
    }
}
