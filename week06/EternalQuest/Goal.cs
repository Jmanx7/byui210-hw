using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Goal
{
    public static int _totalPoints;

    int _points;
    string _name;
    Boolean _complete = false;

    public Goal(int points, string name)
    {
        SetPoints(points);
        SetName(name);
    }

    static public int GetTotalScore()
    {
        return _totalPoints;
    }
    static public void AddTotalScore( int add) {
        _totalPoints += (add);
    }
    static public void SetTotalScore(int add)
    {
        _totalPoints = (add);
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }

    public Boolean GetComplete()
    {
        return _complete;
    }
    public void SetComplete(Boolean _bool)
    {
        _complete = _bool;
    }

    public void Display()
    {
        string complete = "* [ ] ";
        if (GetComplete()) complete = "* [X] ";
        Console.WriteLine(complete + GetName() + " (" + GetPoints() + " Points)");
    }

    public abstract void completeGoal();
    public abstract string Serialize();
}
