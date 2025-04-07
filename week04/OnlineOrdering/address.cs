public class Address
{
    private string _street;
    private string _city;
    private string _county;
    private string _country;

    public Address(string street, string city, string county, string country)
    {
        _street = street;
        _city = city;
        _county = county;
        _country = country;
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_county}\n{_country}";
    }

    public bool IsInKenya()
    {
        return _country.Trim().ToLower() == "kenya";
    }
}
