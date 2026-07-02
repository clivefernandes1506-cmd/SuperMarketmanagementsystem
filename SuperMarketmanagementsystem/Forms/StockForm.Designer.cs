namespace SuperMarketmanagementsystem.Forms
{
    partial class StockForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            btnAdd = new Button();
            button2 = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dgvStock = new DataGridView();
            label2 = new Label();
            cmbProduct = new ComboBox();
            txtQuantity = new TextBox();

            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();

           
            label1.AutoSize = true;
            label1.Location = new Point(22, 58);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 0;
            label1.Text = "Product";

            
            btnAdd.Location = new Point(411, 58);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;

           
            button2.Location = new Point(962, 130);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;

            
            btnDelete.Location = new Point(760, 58);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;

            
            btnUpdate.Location = new Point(579, 58);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(159, 46);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;

            
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(12, 357);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 82;
            dgvStock.Size = new Size(1725, 422);
            dgvStock.TabIndex = 6;
            dgvStock.CellClick += dgvStock_CellClick;

            
            label2.AutoSize = true;
            label2.Location = new Point(22, 106);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 7;
            label2.Text = "Quantity";

            
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(124, 58);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(194, 40);
            cmbProduct.TabIndex = 8;

           
            txtQuantity.Location = new Point(134, 106);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 39);
            txtQuantity.TabIndex = 9;

           
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1749, 785);
            Controls.Add(txtQuantity);
            Controls.Add(cmbProduct);
            Controls.Add(label2);
            Controls.Add(dgvStock);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(button2);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Name = "StockForm";
            Text = "StockForm";

            Load += StockForm_Load;

            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Button button2;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dgvStock;
        private Label label2;
        private ComboBox cmbProduct;
        private TextBox txtQuantity;
    }
}