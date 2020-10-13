using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        public Country HomeCountry { get; set; }
    }
}
