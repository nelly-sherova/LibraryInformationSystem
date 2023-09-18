using LibraryInformationSystem.Data;
using LibraryInformationSystem.Interfaces;
using LibraryInformationSystem.Models;

namespace LibraryInformationSystem.Repositories
{
    public class BookRepository : IBookRepository
    {
        private DataContext dataContext; 
        public BookRepository(DataContext dbContext)
        {
            this.dataContext = dbContext;   
        }

        public Book GetBook(int id)
        {
           var book = dataContext.Books.Where(b => b.Id == id).FirstOrDefault();
           if (book == null)
            {
                return book;
            }
            return null;

        }

        public ICollection<Book> GetBooks()
        {
            var books = dataContext.Books.OrderBy(b => b.Id).ToList();
            if (books != null)
            {
                return books;
            }
            
           return null;
        }

        public ICollection<Book> GetBookByCategory(int id)
        {
            var bookCategories = dataContext.BookCategories.Where(bc => bc.CategoryId == id).ToList();
            if (bookCategories != null ) 
            {
                List<int> ids = new List<int>();
                foreach (var bookCategory in bookCategories)
                {
                    ids.Add(bookCategory.BookId);
                }
                var books = new List<Book>();
                foreach (var i in ids)
                {
                    books.AddRange(dataContext.Books.Where(b => b.Id == i).ToList());
                }
                if (books != null)
                    return books;

            }
            return null;

        }
    }
}
