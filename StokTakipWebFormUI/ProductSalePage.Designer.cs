namespace StokTakipWebFormUI
{
    partial class ProductSalePage
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
            btn_sell = new Button();
            tb_quantity = new TextBox();
            cb_products = new ComboBox();
            cb_customers = new ComboBox();
            tb_dateSelled = new TextBox();
            dgv_saleDetails = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_saleDetails).BeginInit();
            SuspendLayout();
            // 
            // btn_sell
            // 
            btn_sell.Location = new Point(866, 229);
            btn_sell.Name = "btn_sell";
            btn_sell.Size = new Size(94, 29);
            btn_sell.TabIndex = 0;
            btn_sell.Text = "button1";
            btn_sell.UseVisualStyleBackColor = true;
            btn_sell.Click += btn_sell_Click;
            // 
            // tb_quantity
            // 
            tb_quantity.Location = new Point(835, 141);
            tb_quantity.Name = "tb_quantity";
            tb_quantity.Size = new Size(164, 27);
            tb_quantity.TabIndex = 1;
            tb_quantity.Text = "Quantity";
            // 
            // cb_products
            // 
            cb_products.FormattingEnabled = true;
            cb_products.Location = new Point(835, 48);
            cb_products.Name = "cb_products";
            cb_products.Size = new Size(164, 28);
            cb_products.TabIndex = 2;
            cb_products.Text = "Products";
            // 
            // cb_customers
            // 
            cb_customers.FormattingEnabled = true;
            cb_customers.Location = new Point(835, 93);
            cb_customers.Name = "cb_customers";
            cb_customers.Size = new Size(164, 28);
            cb_customers.TabIndex = 3;
            cb_customers.Text = "Customers";
            // 
            // tb_dateSelled
            // 
            tb_dateSelled.Location = new Point(835, 185);
            tb_dateSelled.Name = "tb_dateSelled";
            tb_dateSelled.Size = new Size(164, 27);
            tb_dateSelled.TabIndex = 4;
            tb_dateSelled.Text = "Date";
            // 
            // dgv_saleDetails
            // 
            dgv_saleDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_saleDetails.Location = new Point(12, 70);
            dgv_saleDetails.Name = "dgv_saleDetails";
            dgv_saleDetails.RowHeadersWidth = 51;
            dgv_saleDetails.RowTemplate.Height = 29;
            dgv_saleDetails.Size = new Size(785, 437);
            dgv_saleDetails.TabIndex = 5;
            // 
            // ProductSalePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 519);
            Controls.Add(dgv_saleDetails);
            Controls.Add(tb_dateSelled);
            Controls.Add(cb_customers);
            Controls.Add(cb_products);
            Controls.Add(tb_quantity);
            Controls.Add(btn_sell);
            Name = "ProductSalePage";
            Text = "ProductSalePage";
            Load += ProductSalePage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_saleDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_sell;
        private TextBox tb_quantity;
        private ComboBox cb_products;
        private ComboBox cb_customers;
        private TextBox tb_dateSelled;
        private DataGridView dgv_saleDetails;
    }
}