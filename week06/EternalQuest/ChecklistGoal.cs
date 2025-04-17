using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ChecklistGoal : Goal
{
    private int _count = 0;
    int _bonusThreshold = 0;
    int _bonusAmount;
    public ChecklistGoal(int points, string name, int threshold, int amount) : base(points, name)
    {
        _bonusThreshold = threshold;
        _bonusAmount = amount;
    }
    public ChecklistGoal(int points, string name, Boolean goal, int threshold, int amount) : base(points, name)
    {
        _bonusThreshold = threshold;
        _bonusAmount = amount;
        SetComplete(goal);
    }

    public override void completeGoal()
    {
        if (!GetComplete()) { 
            AddTotalScore(GetPoints());
            _count++;
            if (_count >= _bonusThreshold)
            {
                Console.WriteLine("Goal fully achieved!");
                AddTotalScore(_bonusAmount);
                _count = 0;
                SetComplete(true);
            } else
            {
                Console.WriteLine("Goal partially completed!");
            }
        } else
        {
            Console.WriteLine("Goal already completed!");
        }
    }

    public override string Serialize()
    {
        return "CG|" + GetPoints() + "|" + GetName() + "|" + GetComplete() + "|"+ _bonusThreshold + "|" + _bonusAmount;
    }
}
