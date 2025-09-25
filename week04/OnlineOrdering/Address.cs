class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address()
    {
        _streetAddress = "Unkown";
        _city = "N/A";
        _stateProvince = "N/A";
        _country = "N/A";
    }

    public Address(string street, string city, string stateProvice, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateProvince = stateProvice;
        _country = country;
    }

    public bool CheckUS()
    {
        if (_country.ToLower() == "usa" || _country.ToLower() == "us")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string DisplayAdress()
    {
        return $"{_streetAddress}\n{_city}\n{_stateProvince}\n{_country}";
    }
}