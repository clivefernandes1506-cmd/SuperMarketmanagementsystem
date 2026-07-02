namespace SuperMarketmanagementsystem.Models
{
    public class SaleItem
    {
        public int SaleItemID { get; set; }

        public int SaleID { get; set; }

        public Sale? Sale { get; set; }

        public int ProductID { get; set; }

        public Product? Product { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }
    }
}//saleitem cs done