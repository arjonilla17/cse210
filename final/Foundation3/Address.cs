class Address
{
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }

    public Address(string street, string city, string state)
    {
        Street = street;
        City = city;
        State = state;
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {State}";
    }
}

