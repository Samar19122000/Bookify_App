using System.ComponentModel.DataAnnotations;

namespace BooksApp.Models
{
    public class Book
    {
        public int Id { get; set; }
       
        [MaxLength (500)]
        public string Title { get; set; }

        public DateTime PublishedOn { get; set; }

        public int? AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
