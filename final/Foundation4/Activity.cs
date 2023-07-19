// Base Activity class
abstract class Activity
{
    private DateTime date;
    public int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string activityType = GetType().Name;
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        string unit = (this is Swimming) ? "km" : "miles";

        return $"{date.ToString("dd MMM yyyy")} {activityType} ({minutes} min): Distance {distance:F1} {unit}, Speed {speed:F1} {(unit == "km" ? "kph" : "mph")}, Pace: {pace:F1} {(unit == "km" ? "min per km" : "min per mile")}";
    }
}