using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class EditBookModel : PageModel
    {
        public ApplicationDbContext _db;
        [BindProperty]
        public Book Book { get; set; }
        public EditBookModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet(int Id)
        {
            Book = await _db.Books.FindAsync(Id);

        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var ExistingBook = await _db.Books.FindAsync(Book.Id);
                ExistingBook.Name = Book.Name;
                ExistingBook.Author = Book.Author;
                ExistingBook.ISBN = Book.ISBN;
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
        
    }
}
