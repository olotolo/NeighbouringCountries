public class Country
{
    public string GivenCountry { get; set; } = string.Empty;
    public List<string> NeighbouringCountries { get; set; } = new List<string>();

    public Country(string givenCountry, List<string> neighbouringCountries)
    {
        GivenCountry = givenCountry;
        NeighbouringCountries = neighbouringCountries;
    }
}
