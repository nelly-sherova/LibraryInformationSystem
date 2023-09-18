using LibraryInformationSystem.Models;

namespace LibraryInformationSystem.Interfaces
{
    public interface IBookRepository
    {
        public ICollection<Book> GetBooks();
        public Book GetBook(int id);
        public ICollection<Book> GetBookByCategory(int categoryId);


    }
}
