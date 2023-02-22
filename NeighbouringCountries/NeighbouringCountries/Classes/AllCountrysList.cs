 public class AllCountrysList
{
    public List<Country> Countrys = new List<Country>
    {
        new Country("Deutschland", new List<string>{"Dänemark", "Polen", "Tschechien", "Österreich", "Schweiz", "Frankreich", "Luxemburg", "Belgien", "Niederlande" }),
        new Country("Norwegen", new List<string>{"Schweden", "Finnland", "Russland"}),
        new Country("Schweden", new List<string>{"Norwegen", "Finnland"}),
        new Country("Finnland", new List<string>{"Norwegen", "Schweden", "Russland"}),
        new Country("Albanien", new List<string>{"Griechenland", "Kosovo", "Mazedonien", "Montenegro", "Serbien"}),


        /*
        new Country("Norwegen", new List<string>{}),
        */
    };
}

