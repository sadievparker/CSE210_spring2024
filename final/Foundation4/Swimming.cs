public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50 / 1000) * 0.62;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / Minutes) * 60;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return (double)Minutes / distance;
    }

    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Swimming ({Minutes} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
