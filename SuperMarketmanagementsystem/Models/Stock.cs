namespace SuperMarketmanagementsystem.Models
{
    public class Stock
    {
        public int StockID { get; set; }

        public int ProductID { get; set; }

        public Product? Product { get; set; }

        public int Quantity { get; set; }
    }
}