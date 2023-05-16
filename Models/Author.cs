using System.ComponentModel.DataAnnotations;

namespace BooksApp.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required , MaxLength(100)]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
