class Adress
{
    private string _streetAdress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Adress()
    {
        _streetAdress = "Unkown";
        _city = "N/A";
        _stateProvince = "N/A";
        _country = "N/A";
    }

    public Adress(string street, string city, string stateProvice, string country)
    {
        _streetAdress = street;
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
        return $"{_streetAdress}\n{_city}\n{_stateProvince}\n{_country}";
    }
}