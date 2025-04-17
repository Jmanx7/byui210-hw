using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SimpleGoal : Goal
{

    public SimpleGoal(int points, string name) : base(points, name)
    {
    }
    public SimpleGoal(int points, string name, Boolean goal) : base(points, name)
    {
        SetComplete(goal);
    }

    public override void completeGoal()
    {
        if (!GetComplete()) { 
            AddTotalScore(GetPoints());
            SetComplete(true);
            Console.WriteLine("Goal completed!");
        } else
        {
            Console.WriteLine("Goal already completed!");
        }
    }

    public override string Serialize()
    {
        return "SG|" + GetPoints() + "|" + GetName() + "|" + GetComplete();
    }
}
