class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}Type: Reception\nRSVP Email: {rsvpEmail}\n";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Reception\nTitle: {eventTitle}\nDate: {eventDate.ToShortDateString()}\n";
    }
}