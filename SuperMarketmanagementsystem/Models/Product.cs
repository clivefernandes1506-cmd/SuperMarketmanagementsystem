namespace SuperMarketmanagementsystem.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Barcode { get; set; } = string.Empty;



        public decimal Price { get; set; }

        public DateTime ExpiryDate { get; set; }

       

        public int CategoryID { get; set; }

        public Category? Category { get; set; }

        public int SupplierID { get; set; }

        public Supplier? Supplier { get; set; }
        
    }
}// pr cs done