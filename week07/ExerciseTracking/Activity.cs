using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Activity {
    private string _date;
    private int _minutes;

    public void SetMinutes(int minutes)
    {
        _minutes = minutes;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
    public string GetDate()
    {
        return _date;  
    }

    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract double GetDistance();
    public string GetSummary()
    {
        string _tmp = "";
        _tmp += GetDate();
        _tmp += " Running (" + GetMinutes().ToString();
        _tmp += " min) - Distance " + GetDistance().ToString();
        _tmp += " Miles, Speed " + GetSpeed().ToString();
        _tmp += " mph, Pace: " + GetPace().ToString() + " min per Mile";
        return _tmp;
    }
}
