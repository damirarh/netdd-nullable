using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Country
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alpha2Code { get; set; }
    }

}
