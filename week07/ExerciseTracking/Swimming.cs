using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
    {
        setLaps(laps);
        SetMinutes(minutes);
        SetDate(date);
    }

    public void setLaps(int laps)
    {
        _laps = laps;
    }
    public int GetLaps()
    {
        return _laps;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
    public override double GetDistance()
    {
        return GetLaps() * 50 / 1000.0 * 0.62;
    }

}
