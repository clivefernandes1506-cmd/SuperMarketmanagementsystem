using System;
using System.Windows.Forms;
using SuperMarketmanagementsystem.Models;
using SuperMarketmanagementsystem.Services;

namespace SuperMarketmanagementsystem.Forms
{
    public partial class SupplierForm : Form
    {
        private readonly SupplierService _SupplierService;

        public SupplierForm()
        {
            InitializeComponent();
            _SupplierService = new SupplierService();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();//Suppkierform
        }

        private void LoadSuppliers()
        {
            var suppliers = _SupplierService.GetAllSuppliers();
            dgvSuppliers.DataSource = suppliers;
            dgvSuppliers.Columns["SupplierID"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Please enter a supplier name.");
                return;
            }

            Supplier supplier = new Supplier
            {
                SupplierName = txtSupplierName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            _SupplierService.AddSupplier(supplier);

            LoadSuppliers();
            ClearForm();

            MessageBox.Show("Supplier added successfully.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.CurrentRow == null)
            {
                MessageBox.Show("Please select a supplier.");
                return;
            }

            int supplierId = Convert.ToInt32(dgvSuppliers.CurrentRow.Cells["SupplierID"].Value);

            Supplier? supplier = _SupplierService.GetSupplierById(supplierId);

            if (supplier != null)
            {
                supplier.SupplierName = txtSupplierName.Text.Trim();
                supplier.Phone = txtPhone.Text.Trim();
                supplier.Email = txtEmail.Text.Trim();

                _SupplierService.UpdateSupplier(supplier);

                LoadSuppliers();
                ClearForm();

                MessageBox.Show("Supplier updated successfully.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.CurrentRow == null)
            {
                MessageBox.Show("Please select a supplier.");
                return;
            }

            int supplierId = Convert.ToInt32(dgvSuppliers.CurrentRow.Cells["SupplierID"].Value);

            Supplier? supplier = _SupplierService.GetSupplierById(supplierId);

            if (supplier != null)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this supplier?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _SupplierService.DeleteSupplier(supplier);

                    LoadSuppliers();
                    ClearForm();

                    MessageBox.Show("Supplier deleted successfully.");
                }
            }
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtSupplierName.Text = dgvSuppliers.Rows[e.RowIndex].Cells["SupplierName"].Value.ToString();
                txtPhone.Text = dgvSuppliers.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                txtEmail.Text = dgvSuppliers.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            }
        }

        private void ClearForm()
        {
            txtSupplierName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();

            txtSupplierName.Focus();
        }
    }
}