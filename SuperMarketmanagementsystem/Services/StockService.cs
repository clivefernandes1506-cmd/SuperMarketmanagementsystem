using Microsoft.EntityFrameworkCore;
using SuperMarketmanagementsystem.Data;
using SuperMarketmanagementsystem.Models;

public class StockService
{
    private readonly SupermarketDbContext _context;

    public StockService()
    {
        _context = new SupermarketDbContext();
    }

    public void AddStock(Stock stock)
    {
        _context.Stocks.Add(stock);
        _context.SaveChanges();
    }

    // UPDATED
    public List<Stock> GetAllStocks()
    {
        return _context.Stocks
                       .Include(s => s.Product)
                       .ToList();
    }

    public Stock? GetStockById(int id)
    {
        return _context.Stocks.Find(id);
    }

    public void UpdateStock(Stock stock)
    {
        _context.Stocks.Update(stock);
        _context.SaveChanges();
    }

    public void DeleteStock(Stock stock)
    {
        _context.Stocks.Remove(stock);
        _context.SaveChanges();
    }

    public Stock? GetStockByProductId(int productId)
    {
        return _context.Stocks.FirstOrDefault(s => s.ProductID == productId);
    }
}