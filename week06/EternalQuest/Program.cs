using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;


class Program
{
    static void Main(string[] args)
    {

        List<Goal> goals = new List<Goal>();
        string input = "";

        while (input != "6") { 
            Console.WriteLine("Eternal Quest");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Save");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Show Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("The Types of Goals are:");
                    Console.WriteLine(" 1. Simple Goals");
                    Console.WriteLine(" 2. Eternal Goals");
                    Console.WriteLine(" 3. Checklist Goals");
                    Console.WriteLine("Which type of goal would you like to create? ");

                    int inputType = Convert.ToInt32(Console.ReadLine());
                    if (inputType < 0 || inputType > 3)
                    {
                        Console.WriteLine("Invalid Goal Type.");
                    }
                    else
                    {
                        string tempName;
                        int tempPoints;
                        Console.WriteLine("Enter Goal Text");
                        tempName = Console.ReadLine();
                        Console.WriteLine("Enter points value:");
                        tempPoints = Convert.ToInt32(Console.ReadLine());

                        switch (inputType)
                        {
                            case 1:
                                goals.Add(new SimpleGoal(tempPoints, tempName));
                                break;
                            case 2:
                                goals.Add(new EternalGoal(tempPoints, tempName));
                                break;
                            case 3:
                                Console.WriteLine("Enter Goal Length");
                                int tempLength = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Bonus upon completion");
                                int tempBonus = Convert.ToInt32(Console.ReadLine());
                                goals.Add(new ChecklistGoal(tempPoints, tempName,tempLength, tempBonus));
                                break;
                        }
                    }
                    break;
                case "2":
                    Console.WriteLine("Enter File Location");
                    string fileName = Console.ReadLine();
                    
                    using (StreamWriter outputFile = new StreamWriter(fileName)) {
                        outputFile.WriteLine(Goal.GetTotalScore());
                        foreach (Goal goal in goals)
                        {
                            outputFile.WriteLine(goal.Serialize());
                        }
                            
                    }
                    Console.WriteLine("Saved Scores.");
                    break;
                case "3":
                    Console.WriteLine("Enter File Location");
                    string outName = Console.ReadLine();

                    string[] lines = System.IO.File.ReadAllLines(outName);

                    goals.Clear();

                    Goal.SetTotalScore(Convert.ToInt32(lines[0]));

                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split('|');
                        switch (parts[0])
                        {
                            case "SG":
                                goals.Add(new SimpleGoal(Convert.ToInt32(parts[1]), parts[2], Convert.ToBoolean(parts[3])));
                                break;
                            case "EG":
                                goals.Add(new EternalGoal(Convert.ToInt32(parts[1]), parts[2], Convert.ToBoolean(parts[3])));
                                break;
                            case "CG":
                                goals.Add(new ChecklistGoal(Convert.ToInt32(parts[1]), parts[2], Convert.ToBoolean(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5])));
                                break;
                        }
                    }
                    Console.WriteLine("File Loaded.");
                    break;
                case "4":
                    Console.WriteLine("Which goal would you like to record?");
                    int completeID = Convert.ToInt32(Console.ReadLine());
                    completeID--;
                    if (completeID < 0 || completeID > goals.Count())
                    {
                        Console.WriteLine("Invalid ID.");
                    } else
                    {
                        goals[completeID].completeGoal();
                    }
                        
                    break;
                case "5":
                    int completeCounter = 0;
                    foreach (Goal goal in goals)
                    {
                        goal.Display();
                        if (goal.GetComplete()) completeCounter++;
                    }
                    Console.WriteLine(completeCounter.ToString() + " / " + goals.Count().ToString() + " Completed.");
                    Console.WriteLine("You have " + Goal.GetTotalScore() + " points.");
                    break;
                case "6":
                    Console.WriteLine("Thank you for using the program.");
                    break;
                default:
                    Console.WriteLine("Invalid Input. Please try again.");
                    break;
            }
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

        }
    }
}
