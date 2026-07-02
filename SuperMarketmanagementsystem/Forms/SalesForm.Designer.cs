namespace SuperMarketmanagementsystem.Forms
{
    partial class SalesForm
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
            lblProduct = new Label();
            cmbProduct = new ComboBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblPriceText = new Label();
            lblPrice = new Label();
            lblTotalText = new Label();
            lblTotal = new Label();
            btnRecordSale = new Button();
            btnClear = new Button();
            dgvSales = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dgvSales)).BeginInit();
            SuspendLayout();

            
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(40, 40);
            lblProduct.Text = "Product";

            
            cmbProduct.Location = new Point(180, 35);
            cmbProduct.Size = new Size(250, 40);

            
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(40, 100);
            lblQuantity.Text = "Quantity";

            
            txtQuantity.Location = new Point(180, 95);
            txtQuantity.Size = new Size(250, 39);

            
            lblPriceText.AutoSize = true;
            lblPriceText.Location = new Point(40, 160);
            lblPriceText.Text = "Price";

            
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(180, 160);
            lblPrice.Text = "£0.00";

            
            lblTotalText.AutoSize = true;
            lblTotalText.Location = new Point(40, 210);
            lblTotalText.Text = "Total";

            
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(180, 210);
            lblTotal.Text = "£0.00";

            
            btnRecordSale.Location = new Point(500, 40);
            btnRecordSale.Size = new Size(180, 50);
            btnRecordSale.Text = "Record Sale";
            btnRecordSale.UseVisualStyleBackColor = true;
            btnRecordSale.Click += btnRecordSale_Click;

            
            btnClear.Location = new Point(500, 110);
            btnClear.Size = new Size(180, 50);
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;

           
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(20, 280);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersWidth = 82;
            dgvSales.Size = new Size(900, 350);

            
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 660);
            Controls.Add(lblProduct);
            Controls.Add(cmbProduct);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(lblPriceText);
            Controls.Add(lblPrice);
            Controls.Add(lblTotalText);
            Controls.Add(lblTotal);
            Controls.Add(btnRecordSale);
            Controls.Add(btnClear);
            Controls.Add(dgvSales);
            Name = "SalesForm";
            Text = "Sales Form";
            Load += SalesForm_Load;

            ((System.ComponentModel.ISupportInitialize)(dgvSales)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduct;
        private ComboBox cmbProduct;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Label lblPriceText;
        private Label lblPrice;
        private Label lblTotalText;
        private Label lblTotal;
        private Button btnRecordSale;
        private Button btnClear;
        private DataGridView dgvSales;
    }
}