class Event
{
    public string eventTitle;
    private string eventDescription;
    public DateTime eventDate;
    private TimeSpan eventTime;
    private Address eventAddress;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        eventTitle = title;
        eventDescription = description;
        eventDate = date;
        eventTime = time;
        eventAddress = address;
    }

    public string GetStandardDetails()
    {
        return $"Event: {eventTitle}\nDescription: {eventDescription}\nDate: {eventDate.ToShortDateString()}\nTime: {eventTime}\nAddress: {eventAddress}\n";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Event Type: Generic Event\nTitle: {eventTitle}\nDate: {eventDate.ToShortDateString()}\n";
    }
}