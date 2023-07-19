class Lecture : Event
{
    private string speakerName;
    private int capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        speakerName = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}Type: Lecture\nSpeaker: {speakerName}\nCapacity: {capacity}\n";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Lecture\nTitle: {eventTitle}\nDate: {eventDate.ToShortDateString()}\n";
    }
}