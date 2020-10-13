namespace Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public Country? HomeCountry { get; set; }

        public Player(int id, string username, string emailAddress)
        {
            Id = id;
            Username = username;
            EmailAddress = emailAddress;
        }
    }
}
