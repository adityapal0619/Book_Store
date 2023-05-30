using System.ComponentModel.DataAnnotations;

namespace Book_Store.Models.Domain
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
