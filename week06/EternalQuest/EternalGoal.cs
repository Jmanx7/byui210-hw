using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EternalGoal : Goal
{
    public EternalGoal(int points, string name) : base(points, name)
    {
    }
    public EternalGoal(int points, string name, Boolean goal) : base(points, name)
    {
        SetComplete(goal);
    }
    public override void completeGoal()
    {
        AddTotalScore(GetPoints());
        Console.WriteLine("Goal completed!");
    }

    public override string Serialize()
    {
        return "EG|" + GetPoints() + "|" + GetName() + "|" + GetComplete();
    }
}