using SuperMarketmanagementsystem.Data;
using SuperMarketmanagementsystem.Models;

namespace SuperMarketmanagementsystem.Services
{
    public class SupplierService
    {
        private readonly SupermarketDbContext _context;
        public SupplierService()
        {
            _context = new SupermarketDbContext();
        }
        public void AddSupplier(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }
        public List<Supplier> GetAllSuppliers()
        {
            return _context.Suppliers.ToList();
        }
        public Supplier? GetSupplierById(int id)
        {
            return _context.Suppliers.Find(id);
        }
        public void UpdateSupplier(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            _context.SaveChanges();
        }
        public void DeleteSupplier(Supplier supplier)
        {
            _context.Suppliers.Remove(supplier);
            _context.SaveChanges();
        }
    }
}// supplier service done



