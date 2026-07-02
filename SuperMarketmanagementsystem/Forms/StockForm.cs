using System;
using System.Windows.Forms;
using SuperMarketmanagementsystem.Models;
using SuperMarketmanagementsystem.Services;

namespace SuperMarketmanagementsystem.Forms
{
    public partial class StockForm : Form
    {
        private readonly StockService _stockService;
        private readonly ProductService _productService;

        public StockForm()
        {
            InitializeComponent();

            _stockService = new StockService();
            _productService = new ProductService();
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadStock();
        }

        private void LoadProducts()
        {
            var products = _productService.GetAllProducts();

            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "Title";
            cmbProduct.ValueMember = "ProductID";
        }

        private void LoadStock()
        {
            var stockList = _stockService.GetAllStocks()
                .Select(s => new
                {
                    StockID = s.StockID,
                    ProductID = s.ProductID,
                    Product = s.Product != null ? s.Product.Title : "",
                    Quantity = s.Quantity
                })
                .ToList();

            dgvStock.DataSource = null;
            dgvStock.DataSource = stockList;

            dgvStock.Columns["StockID"].Visible = false;
            dgvStock.Columns["ProductID"].Visible = false;

            foreach (Stock stock in _stockService.GetAllStocks())
            {
                if (stock.Quantity <= 10)
                {
                    MessageBox.Show("Low stock for " + stock.Product?.Title);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedValue == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            Stock? existingStock = _stockService.GetStockByProductId(
                Convert.ToInt32(cmbProduct.SelectedValue));

            if (existingStock != null)
            {
                MessageBox.Show("Stock already exists for this product.");
                return;
            }

            Stock stock = new Stock
            {
                ProductID = Convert.ToInt32(cmbProduct.SelectedValue),
                Quantity = quantity
            };

            _stockService.AddStock(stock);

            MessageBox.Show("Stock added successfully.");

            LoadStock();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStock.CurrentRow == null)
            {
                MessageBox.Show("Select a stock record.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            int stockId = Convert.ToInt32(dgvStock.CurrentRow.Cells["StockID"].Value);

            Stock? stock = _stockService.GetStockById(stockId);

            if (stock != null)
            {
                stock.ProductID = Convert.ToInt32(cmbProduct.SelectedValue);
                stock.Quantity = quantity;

                _stockService.UpdateStock(stock);

                MessageBox.Show("Stock updated successfully.");

                LoadStock();
                ClearForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStock.CurrentRow == null)
            {
                MessageBox.Show("Select a stock record.");
                return;
            }

            int stockId = Convert.ToInt32(dgvStock.CurrentRow.Cells["StockID"].Value);

            Stock? stock = _stockService.GetStockById(stockId);

            if (stock != null)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this stock?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _stockService.DeleteStock(stock);

                    MessageBox.Show("Stock deleted successfully.");

                    LoadStock();
                    ClearForm();
                }
            }
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cmbProduct.SelectedValue =
                    dgvStock.Rows[e.RowIndex].Cells["ProductID"].Value;

                txtQuantity.Text =
                    dgvStock.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            }
        }

        private void ClearForm()
        {
            cmbProduct.SelectedIndex = -1;
            txtQuantity.Clear();
        }
    }
}