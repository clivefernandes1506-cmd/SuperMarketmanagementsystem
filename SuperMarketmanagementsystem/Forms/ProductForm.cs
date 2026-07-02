using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMarketmanagementsystem.Models;
using SuperMarketmanagementsystem.Services;

namespace SuperMarketmanagementsystem.Forms
{
    public partial class ProductForm : Form
    {
        private readonly ProductService _ProductService;
        private readonly CategoryService _CategoryService;
        private readonly SupplierService _SupplierService;
        public ProductForm()
        {
            InitializeComponent();
            _ProductService = new ProductService();
            _CategoryService = new CategoryService();
            _SupplierService = new SupplierService();//Product

        }


        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            Loadproducts();
            LoadCategories();
            LoadSuppliers();



        }
        private void Loadproducts()
        {
            var products = _ProductService.GetAllProducts();
            dgvProducts.DataSource = products;
            dgvProducts.Columns["ProductID"].Visible = false;
            dgvProducts.Columns["CategoryID"].Visible = false;
            dgvProducts.Columns["SupplierID"].Visible = false;
            dgvProducts.Columns["Category"].Visible = false;
            dgvProducts.Columns["Supplier"].Visible = false;
        }
        private void LoadCategories()
        {
            var categories = _CategoryService.GetAllCategories();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
        }

        private void LoadSuppliers()
        {
            var suppliers = _SupplierService.GetAllSuppliers();
            cmbSupplier.DataSource = suppliers;
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierID";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Title = txtProductName.Text,
                Price = decimal.Parse(txtPrice.Text),
                Barcode = Barcode.Text,
                ExpiryDate = dtpExpiryDate.Value,
                CategoryID = Convert.ToInt32(cmbCategory.SelectedValue),
                SupplierID = Convert.ToInt32(cmbSupplier.SelectedValue),
            };
            _ProductService.AddProduct(product);
            Loadproducts();
            ClearForm();
        }
        private void ClearForm()
        {
            txtProductName.Clear();
            txtPrice.Clear();
            txtBarcode.Clear();
            dtpExpiryDate = new DateTimePicker();
            cmbCategory.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
                return;

            var product = new Product
            {
                ProductID = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value),
                Title = txtProductName.Text,
                Price = decimal.Parse(txtPrice.Text),
                Barcode = txtBarcode.Text,
                ExpiryDate = dtpExpiryDate.Value,
                CategoryID = Convert.ToInt32(cmbCategory.SelectedValue),
                SupplierID = Convert.ToInt32(cmbSupplier.SelectedValue)
            };

            _ProductService.UpdateProduct(product);

            Loadproducts();
            ClearForm();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
                return;

            int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);

            var product = _ProductService.GetProductById(productId);

            if (product != null)
            {
                _ProductService.DeleteProduct(product);
                Loadproducts();
                ClearForm();
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            var products = _ProductService.SearchProducts(searchTerm);
            dgvProducts.DataSource = products;


        }
    }
}



