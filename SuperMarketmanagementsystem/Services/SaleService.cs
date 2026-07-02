using SuperMarketmanagementsystem.Data;
using SuperMarketmanagementsystem.Models;

namespace SuperMarketmanagementsystem.Services
{
    public class SaleService
    {
        private readonly SupermarketDbContext _context;

        public SaleService()
        {
            _context = new SupermarketDbContext();
        }

        public void AddSale(Sale sale)
        {
            _context.Sales.Add(sale);
            _context.SaveChanges();
        }

        public List<Sale> GetAllSales()
        {
            return _context.Sales.ToList();
        }

        public Sale? GetSaleById(int id)
        {
            return _context.Sales.Find(id);
        }

        public void UpdateSale(Sale sale)
        {
            _context.Sales.Update(sale);
            _context.SaveChanges();
        }

        public void DeleteSale(Sale sale)
        {
            _context.Sales.Remove(sale);
            _context.SaveChanges();
        }
    }
}