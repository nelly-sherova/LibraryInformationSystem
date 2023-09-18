using LibraryInformationSystem.Models;

namespace LibraryInformationSystem.Interfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategories();
        public Category GetCategory(int id);    
    }
}
