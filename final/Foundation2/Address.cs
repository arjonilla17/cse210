public class Address{
    private string _address;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address, string city, string state, string country)
    {
        this._address = address;
        this._city = city;
        this._state = state;
        this._country = country;
    }

    public bool IsInUSA()
    {
        return _country == "USA";
    }

    public string GetAddressInfo()
    {
        return $"{_address}, {_city}, {_state}, {_country}";
    }
}






