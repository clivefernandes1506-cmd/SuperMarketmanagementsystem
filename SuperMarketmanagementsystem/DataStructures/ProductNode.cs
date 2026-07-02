using SuperMarketmanagementsystem.Models;

namespace SuperMarketmanagementsystem.DataStructures
{
    public class ProductNode
    {
        public Product Product { get; set; }

        public ProductNode? Left { get; set; }

        public ProductNode? Right { get; set; }

        public ProductNode(Product product)
        {
            Product = product;
            Left = null;
            Right = null;
        }
    }
}