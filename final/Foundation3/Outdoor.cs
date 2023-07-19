class Outdoor : Event
{
    private string weatherForecast;

    public Outdoor(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}Type: Outdoor Gathering\nWeather Forecast: {weatherForecast}\n";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Outdoor Gathering\nTitle: {eventTitle}\nDate: {eventDate.ToShortDateString()}\n";
    }
}