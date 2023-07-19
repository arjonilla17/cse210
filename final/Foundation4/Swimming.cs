class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50.0 / 1000.0; // Distance in kilometers
    }

    public override double GetSpeed()
    {
        return laps * 50.0 / 1000.0 * 0.62 / (double)minutes * 60; // Speed in mph
    }

    public override double GetPace()
    {
        return minutes / (laps * 50.0 / 1000.0); // Pace in minutes per kilometer
    }
}
