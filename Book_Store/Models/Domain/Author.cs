using System.ComponentModel.DataAnnotations;

namespace Book_Store.Models.Domain
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string AuthorName { get; set; }
    }
}
