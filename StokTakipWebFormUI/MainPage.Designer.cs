namespace StokTakipWebFormUI
{
    partial class MainPage
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
            btn_products = new Button();
            btn_categories = new Button();
            btn_customers = new Button();
            btn_productSale = new Button();
            dgv_products = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            SuspendLayout();
            // 
            // btn_products
            // 
            btn_products.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_products.Location = new Point(855, 225);
            btn_products.Name = "btn_products";
            btn_products.Size = new Size(166, 47);
            btn_products.TabIndex = 0;
            btn_products.Text = "ÜRÜNLER";
            btn_products.UseVisualStyleBackColor = true;
            btn_products.Click += btn_products_Click;
            // 
            // btn_categories
            // 
            btn_categories.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_categories.Location = new Point(855, 12);
            btn_categories.Name = "btn_categories";
            btn_categories.Size = new Size(166, 47);
            btn_categories.TabIndex = 1;
            btn_categories.Text = "KATEGORİLER";
            btn_categories.UseVisualStyleBackColor = true;
            btn_categories.Click += btn_categories_Click;
            // 
            // btn_customers
            // 
            btn_customers.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_customers.Location = new Point(855, 153);
            btn_customers.Name = "btn_customers";
            btn_customers.Size = new Size(166, 46);
            btn_customers.TabIndex = 2;
            btn_customers.Text = "MÜŞTERİLER";
            btn_customers.UseVisualStyleBackColor = true;
            btn_customers.Click += btn_customers_Click;
            // 
            // btn_productSale
            // 
            btn_productSale.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_productSale.Location = new Point(855, 82);
            btn_productSale.Name = "btn_productSale";
            btn_productSale.Size = new Size(166, 46);
            btn_productSale.TabIndex = 3;
            btn_productSale.Text = "VERİLEN ÜRÜNLER";
            btn_productSale.UseVisualStyleBackColor = true;
            btn_productSale.Click += btn_productSale_Click;
            // 
            // dgv_products
            // 
            dgv_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_products.Location = new Point(12, 12);
            dgv_products.Name = "dgv_products";
            dgv_products.RowHeadersWidth = 51;
            dgv_products.RowTemplate.Height = 29;
            dgv_products.Size = new Size(837, 527);
            dgv_products.TabIndex = 4;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 549);
            Controls.Add(dgv_products);
            Controls.Add(btn_productSale);
            Controls.Add(btn_customers);
            Controls.Add(btn_categories);
            Controls.Add(btn_products);
            Name = "MainPage";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            Load += MainPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_products;
        private Button btn_categories;
        private Button btn_customers;
        private Button btn_productSale;
        private DataGridView dgv_products;
    }
}