using BookListRazor.Pages.BookList;
using System.ComponentModel.DataAnnotations;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Author { get; set; }
        public string ISBN { get; set; }
        // whenever you are adding a new property you should add new migration
    }
}
