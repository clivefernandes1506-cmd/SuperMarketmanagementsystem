using SuperMarketmanagementsystem.Data;
using SuperMarketmanagementsystem.Models;

namespace SuperMarketmanagementsystem.Services
{
    public class SaleItemService
    {
        private readonly SupermarketDbContext _context;

        public SaleItemService()
        {
            _context = new SupermarketDbContext();
        }

        public void AddSaleItem(SaleItem saleItem)
        {
            _context.SaleItems.Add(saleItem);
            _context.SaveChanges();
        }

        public List<SaleItem> GetAllSaleItems()
        {
            return _context.SaleItems.ToList();
        }
    }
}