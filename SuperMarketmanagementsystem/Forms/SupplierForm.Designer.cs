namespace SuperMarketmanagementsystem.Forms
{
    partial class SupplierForm
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
            txtSupplierName = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvSuppliers = new DataGridView();
            label2 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();

            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();

            
            label1.AutoSize = true;
            label1.Location = new Point(41, 73);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 0;
            label1.Text = "Supplier Name";

            
            txtSupplierName.Location = new Point(211, 73);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(200, 39);
            txtSupplierName.TabIndex = 1;

            
            label2.AutoSize = true;
            label2.Location = new Point(41, 135);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 2;
            label2.Text = "Phone";

            
            txtPhone.Location = new Point(211, 135);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 39);
            txtPhone.TabIndex = 3;

            
            label3.AutoSize = true;
            label3.Location = new Point(41, 197);
            label3.Name = "label3";
            label3.Size = new Size(69, 32);
            label3.TabIndex = 4;
            label3.Text = "Email";

           
            txtEmail.Location = new Point(211, 197);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 39);
            txtEmail.TabIndex = 5;

            
            btnAdd.Location = new Point(446, 73);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;

            
            btnUpdate.Location = new Point(602, 73);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;

           
            btnDelete.Location = new Point(758, 73);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 46);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;

            
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(12, 443);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 82;
            dgvSuppliers.Size = new Size(1812, 428);
            dgvSuppliers.TabIndex = 9;
            dgvSuppliers.CellClick += dgvSuppliers_CellClick;

           
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1836, 883);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(dgvSuppliers);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSupplierName);
            Controls.Add(label1);
            Name = "SupplierForm";
            Text = "SupplierForm";
            Load += SupplierForm_Load;

            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;

        private TextBox txtSupplierName;
        private TextBox txtPhone;
        private TextBox txtEmail;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;

        private DataGridView dgvSuppliers;
    }
}