namespace ClassLibrary
{
    public class Country
    {
        public string Name { get; set; }
        public string Alpha2Code { get; set; }

        private Country(string name, string alpha2Code)
        {
            Name = name;
            Alpha2Code = alpha2Code;
        }

        public static readonly Country Slovenia = new Country("Slovenia", "SI");
        public static readonly Country Croatia = new Country("Poland", "PL");
    }

}
