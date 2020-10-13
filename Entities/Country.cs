namespace Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alpha2Code { get; set; }

        public Country(string name, string alpha2Code)
        {
            Name = name;
            Alpha2Code = alpha2Code;
        }
    }

}
