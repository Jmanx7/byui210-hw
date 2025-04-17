using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int minutes, double speed)
    {
        SetSpeed(speed);
        SetMinutes(minutes);
        SetDate(date);
    }

    public void SetSpeed(double speed)
    {
        _speed = speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return (GetSpeed() * GetMinutes()) / 60;
    }
    public override double GetDistance()
    {
        return GetSpeed() / _speed;
    }
}
