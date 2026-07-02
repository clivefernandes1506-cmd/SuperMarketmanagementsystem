using System;
using System.Windows.Forms;
using SuperMarketmanagementsystem.Models;
using SuperMarketmanagementsystem.Services;

namespace SuperMarketmanagementsystem.Forms
{
    public partial class CategoryForm : Form
    {
        private readonly CategoryService _categoryService;

        public CategoryForm()
        {
            InitializeComponent();
            _categoryService = new CategoryService();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            var categories = _categoryService.GetAllCategories();

            dgvCategories.DataSource = null;
            dgvCategories.DataSource = categories;

            dgvCategories.Columns["CategoryID"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter a category name.");//will show msg when want to put in details
                return;
            }

            Category category = new Category
            {
                CategoryName = txtCategoryName.Text.Trim()
            };

            _categoryService.AddCategory(category);

            LoadCategories();
            ClearForm();

            MessageBox.Show("Category added successfully.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            int categoryId = Convert.ToInt32(dgvCategories.CurrentRow.Cells["CategoryID"].Value);

            Category? category = _categoryService.GetCategoryById(categoryId);

            if (category != null)
            {
                category.CategoryName = txtCategoryName.Text.Trim();

                _categoryService.UpdateCategory(category);

                LoadCategories();
                ClearForm();

                MessageBox.Show("Category updated successfully.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            int categoryId = Convert.ToInt32(dgvCategories.CurrentRow.Cells["CategoryID"].Value);

            Category? category = _categoryService.GetCategoryById(categoryId);

            if (category != null)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this category?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _categoryService.DeleteCategory(category);

                    LoadCategories();
                    ClearForm();

                    MessageBox.Show("Category deleted successfully.");
                }
            }
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)// data grid view 
        {
            if (e.RowIndex >= 0)
            {
                txtCategoryName.Text =
                    dgvCategories.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
            }
        }

        private void ClearForm()
        {
            txtCategoryName.Clear();
            txtCategoryName.Focus();
        }
    }
}