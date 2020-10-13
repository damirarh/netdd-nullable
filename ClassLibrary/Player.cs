namespace ClassLibrary
{
    public class Player
    {
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public Country? HomeCountry { get; set; }

        public Player(string username, string emailAddress, Country homeCountry)
        {
            Username = username;
            EmailAddress = emailAddress;
            HomeCountry = homeCountry;
        }

        public Player(string username, string emailAddress)
        {
            Username = username;
            EmailAddress = emailAddress;
        }
    }
}
