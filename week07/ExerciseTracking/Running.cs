using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance)
    {
        setDistance(distance);
        SetMinutes(minutes);
        SetDate(date);
    }

    public void setDistance(double newDistance)
    {
        _distance = newDistance;
    }

    public override double GetSpeed() {
        return (GetDistance() / GetMinutes()) * 60;
    }
    public override double GetPace() {
        return GetMinutes() / GetDistance();
    }
    public override double GetDistance() {
        return _distance;
    }
}
