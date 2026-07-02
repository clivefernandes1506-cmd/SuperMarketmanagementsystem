using System;
using System.Windows.Forms;
using SuperMarketmanagementsystem.Models;
using SuperMarketmanagementsystem.Services;

namespace SuperMarketmanagementsystem.Forms
{
    public partial class SalesForm : Form
    {
        private readonly SaleService _saleService;
        private readonly SaleItemService _saleItemService;
        private readonly ProductService _productService;
        private readonly StockService _stockService;

        public SalesForm()//SalesForm
        {
            InitializeComponent();

            _saleService = new SaleService();
            _saleItemService = new SaleItemService();
            _productService = new ProductService();
            _stockService = new StockService();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadSales();
        }

        private void LoadProducts()
        {
            var products = _productService.GetAllProducts();

            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "Title";
            cmbProduct.ValueMember = "ProductID";
        }

        private void LoadSales()
        {
            dgvSales.DataSource = _saleService.GetAllSales();
        }

        private void btnRecordSale_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedValue == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Enter a valid quantity.");
                return;
            }

            int productId = Convert.ToInt32(cmbProduct.SelectedValue);

            Product? product = _productService.GetProductById(productId);

            if (product == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            Stock? stock = _stockService.GetStockByProductId(productId);

            if (stock == null)
            {
                MessageBox.Show("No stock available.");
                return;
            }

            if (stock.Quantity < quantity)
            {
                MessageBox.Show("Not enough stock.");
                return;
            }

            decimal total = product.Price * quantity;

            Sale sale = new Sale
            {
                SaleDate = DateTime.Now,
                TotalAmount = total
            };

            _saleService.AddSale(sale);

            SaleItem saleItem = new SaleItem
            {
                SaleID = sale.SaleID,
                ProductID = product.ProductID,
                Quantity = quantity,
                UnitPrice = product.Price
            };

            _saleItemService.AddSaleItem(saleItem);

            stock.Quantity -= quantity;
            _stockService.UpdateStock(stock);

            MessageBox.Show("Sale recorded successfully.");

            LoadSales();
            btnClear_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbProduct.SelectedIndex = -1;
            txtQuantity.Clear();

            lblPrice.Text = "£0.00";
            lblTotal.Text = "£0.00";
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedValue == null)
                return;

            if (int.TryParse(cmbProduct.SelectedValue.ToString(), out int productId))
            {
                Product? product = _productService.GetProductById(productId);

                if (product != null)
                {
                    lblPrice.Text = product.Price.ToString("C");
                }
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedValue == null)
                return;

            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                lblTotal.Text = "£0.00";
                return;
            }

            if (int.TryParse(cmbProduct.SelectedValue.ToString(), out int productId))
            {
                Product? product = _productService.GetProductById(productId);

                if (product != null)
                {
                    decimal total = product.Price * quantity;
                    lblTotal.Text = total.ToString("C");
                }
            }
        }
    }
}