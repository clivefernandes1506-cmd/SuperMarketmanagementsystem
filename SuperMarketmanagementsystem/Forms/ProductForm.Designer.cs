namespace SuperMarketmanagementsystem.Forms
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            label4 = new Label();
            cmbCategory = new ComboBox();
            label5 = new Label();
            cmbSupplier = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            label6 = new Label();
            txtSearch = new TextBox();
            dgvProducts = new DataGridView();
            Barcode = new Label();
            txtBarcode = new TextBox();
            blExpiryDate = new Label();
            dtpExpiryDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(175, 32);
            label1.TabIndex = 0;
            label1.Text = "Product name :";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(181, 39);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(200, 39);
            txtProductName.TabIndex = 2;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(77, 32);
            label2.TabIndex = 3;
            label2.Text = "Price :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 153);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 4;
            label3.Text = "Stock :";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(83, 98);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 39);
            txtPrice.TabIndex = 5;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(83, 153);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(200, 39);
            txtStock.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 211);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 7;
            label4.Text = "Category :";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(128, 211);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(242, 40);
            cmbCategory.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 280);
            label5.Name = "label5";
            label5.Size = new Size(114, 32);
            label5.TabIndex = 9;
            label5.Text = "Supplier ;";
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(120, 280);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(242, 40);
            cmbSupplier.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 350);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(168, 350);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(324, 350);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(480, 350);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 46);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 423);
            label6.Name = "label6";
            label6.Size = new Size(186, 32);
            label6.TabIndex = 15;
            label6.Text = "Search Product :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(192, 420);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 39);
            txtSearch.TabIndex = 16;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(6, 511);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 82;
            dgvProducts.Size = new Size(1753, 473);
            dgvProducts.TabIndex = 17;
            // 
            // Barcode
            // 
            Barcode.AutoSize = true;
            Barcode.Location = new Point(387, 46);
            Barcode.Name = "Barcode";
            Barcode.Size = new Size(112, 32);
            Barcode.TabIndex = 18;
            Barcode.Text = "Barcode :";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(493, 39);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(200, 39);
            txtBarcode.TabIndex = 19;
            // 
            // blExpiryDate
            // 
            blExpiryDate.AutoSize = true;
            blExpiryDate.Location = new Point(387, 101);
            blExpiryDate.Name = "blExpiryDate";
            blExpiryDate.Size = new Size(146, 32);
            blExpiryDate.TabIndex = 21;
            blExpiryDate.Text = "Expiry Date :";
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.Location = new Point(530, 98);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Size = new Size(400, 39);
            dtpExpiryDate.TabIndex = 22;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1764, 996);
            Controls.Add(dtpExpiryDate);
            Controls.Add(blExpiryDate);
            Controls.Add(txtBarcode);
            Controls.Add(Barcode);
            Controls.Add(dgvProducts);
            Controls.Add(txtSearch);
            Controls.Add(label6);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbSupplier);
            Controls.Add(label5);
            Controls.Add(cmbCategory);
            Controls.Add(label4);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductName;
        private Label label2;
        private Label label3;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Label label4;
        private ComboBox cmbCategory;
        private Label label5;
        private ComboBox cmbSupplier;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private Label label6;
        private TextBox txtSearch;
        private DataGridView dgvProducts;
        private Label Barcode;
        private TextBox txtBarcode;
        private Label blExpiryDate;
        private DateTimePicker dtpExpiryDate;
    }
}//Commiting