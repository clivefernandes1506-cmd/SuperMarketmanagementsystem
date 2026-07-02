using SuperMarketmanagementsystem.Data;
using SuperMarketmanagementsystem.Models;

namespace SuperMarketmanagementsystem.Services
{
    public class CategoryService
    {
        private readonly SupermarketDbContext _context;
        public CategoryService()
        {
            _context = new SupermarketDbContext();
        }
        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }
        public Category? GetCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }
        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }
        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}