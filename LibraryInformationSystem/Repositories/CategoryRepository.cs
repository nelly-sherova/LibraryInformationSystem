using LibraryInformationSystem.Data;
using LibraryInformationSystem.Interfaces;
using LibraryInformationSystem.Models;

namespace LibraryInformationSystem.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly DataContext dataContext;
        public CategoryRepository(DataContext dataContext) 
        {
            this.dataContext = dataContext;                    
        }

        public IEnumerable<Category> GetCategories()
        {
            var categories = dataContext.Categories.OrderBy(c => c.Id).ToList();
            if (categories != null)
            {
                return categories;
            }
            else return null;
        }

        public Category GetCategory(int id)
        {
            var category = dataContext.Categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                return category;
            }
            return null;
        }
    }
}
