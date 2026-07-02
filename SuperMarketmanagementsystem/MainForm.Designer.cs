namespace SuperMarketmanagementsystem.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnProducts = new Button();
            btnCategories = new Button();
            btnSuppliers = new Button();
            btnStock = new Button();
            btnSales = new Button();
            btnExit = new Button();
            SuspendLayout();

            
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(180, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(486, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Supermarket System";

            
            btnProducts.Location = new Point(250, 140);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(250, 50);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;

           
            btnCategories.Location = new Point(250, 210);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(250, 50);
            btnCategories.TabIndex = 2;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;

            
            btnSuppliers.Location = new Point(250, 280);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(250, 50);
            btnSuppliers.TabIndex = 3;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;

            
            btnStock.Location = new Point(250, 350);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(250, 50);
            btnStock.TabIndex = 4;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;

            
            btnSales.Location = new Point(250, 420);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(250, 50);
            btnSales.TabIndex = 5;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;

            
            btnExit.Location = new Point(250, 490);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(250, 50);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;

            
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 620);
            Controls.Add(lblTitle);
            Controls.Add(btnProducts);
            Controls.Add(btnCategories);
            Controls.Add(btnSuppliers);
            Controls.Add(btnStock);
            Controls.Add(btnSales);
            Controls.Add(btnExit);
            Name = "MainForm";
            Text = "Supermarket Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnProducts;
        private Button btnCategories;
        private Button btnSuppliers;
        private Button btnStock;
        private Button btnSales;
        private Button btnExit;
    }
}