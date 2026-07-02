using SuperMarketmanagementsystem.Models;

namespace SuperMarketmanagementsystem.DataStructures
{
    public class BinarySearchTree
    {
        private ProductNode? root;

        public BinarySearchTree()
        {
            root = null;
        }

        // Insert a product into the tree
        public void Insert(Product product)
        {
            root = InsertRecursive(root, product);
        }

        private ProductNode InsertRecursive(ProductNode? current, Product product)
        {
            if (current == null)
            {
                return new ProductNode(product);
            }

            int comparison = string.Compare(product.Title, current.Product.Title, true);

            if (comparison < 0)
            {
                current.Left = InsertRecursive(current.Left, product);
            }
            else if (comparison > 0)
            {
                current.Right = InsertRecursive(current.Right, product);
            }

            // If titles are the same, do nothing (prevents duplicates)
            return current;
        }

        // Search for a product by title
        public Product? Search(string title)
        {
            return SearchRecursive(root, title);
        }

        private Product? SearchRecursive(ProductNode? current, string title)
        {
            if (current == null)
            {
                return null;
            }

            int comparison = string.Compare(title, current.Product.Title, true);

            if (comparison == 0)
            {
                return current.Product;
            }

            if (comparison < 0)
            {
                return SearchRecursive(current.Left, title);
            }

            return SearchRecursive(current.Right, title);
        }

        // Return all products in alphabetical order
        public List<Product> InOrderTraversal()
        {
            List<Product> products = new List<Product>();

            InOrderRecursive(root, products);

            return products;
        }

        private void InOrderRecursive(ProductNode? current, List<Product> products)
        {
            if (current == null)
            {
                return;
            }

            InOrderRecursive(current.Left, products);

            products.Add(current.Product);

            InOrderRecursive(current.Right, products);
        }
    }
}