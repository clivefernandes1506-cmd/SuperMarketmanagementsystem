using Microsoft.EntityFrameworkCore;
using SuperMarketmanagementsystem.Data;
using SuperMarketmanagementsystem.DataStructures;
using SuperMarketmanagementsystem.Models;

namespace SuperMarketmanagementsystem.Services
{
    public class ProductService
    {
        private readonly SupermarketDbContext _context;
        private readonly BinarySearchTree _productTree;

        public ProductService()
        {
            _context = new SupermarketDbContext();
            _productTree = new BinarySearchTree();

            LoadProductsIntoTree();
        }

        private void LoadProductsIntoTree()
        {
            var products = _context.Products
                                   .Include(p => p.Category)
                                   .Include(p => p.Supplier)
                                   .ToList();

            foreach (var product in products)
            {
                _productTree.Insert(product);
            }
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            _productTree.Insert(product);
        }
        public List<Product> GetAllProducts()
        {
            return _context.Products
                           .Include(p => p.Category)
                           .Include(p => p.Supplier)
                           .ToList();
        }
        public Product? GetProductByTitle(string title)
        {
            return _productTree.Search(title);
        }
        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
          
        }
        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
            
        }

        public Product? GetProductById(int id)
        {
            return _context.Products
                           .Include(p => p.Category)
                           .Include(p => p.Supplier)
                           .FirstOrDefault(p => p.ProductID == id);
        }
        public List<Product> SearchProducts(string searchTerm)
        {
            var products = GetAllProducts();

            return products.Where(p =>
                p.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}

