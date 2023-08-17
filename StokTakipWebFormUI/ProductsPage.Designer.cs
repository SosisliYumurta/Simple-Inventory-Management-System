namespace StokTakipWebFormUI
{
    partial class ProductsPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgw_productsList = new DataGridView();
            cb_searchByCategoryName = new ComboBox();
            tb_searchByProductName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_productAdd = new Button();
            tb_productName = new TextBox();
            cb_categoryName = new ComboBox();
            tb_stockQuantity = new TextBox();
            tb_unitPrice = new TextBox();
            dtp_dateAdded = new DateTimePicker();
            button1 = new Button();
            btn_deleteProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)dgw_productsList).BeginInit();
            SuspendLayout();
            // 
            // dgw_productsList
            // 
            dgw_productsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_productsList.Location = new Point(12, 105);
            dgw_productsList.Name = "dgw_productsList";
            dgw_productsList.RowHeadersWidth = 51;
            dgw_productsList.RowTemplate.Height = 29;
            dgw_productsList.Size = new Size(774, 470);
            dgw_productsList.TabIndex = 0;
            dgw_productsList.CellClick += dgw_productsList_CellClick;
            // 
            // cb_searchByCategoryName
            // 
            cb_searchByCategoryName.FormattingEnabled = true;
            cb_searchByCategoryName.Location = new Point(384, 72);
            cb_searchByCategoryName.Name = "cb_searchByCategoryName";
            cb_searchByCategoryName.Size = new Size(204, 28);
            cb_searchByCategoryName.TabIndex = 1;
            cb_searchByCategoryName.Visible = false;
            cb_searchByCategoryName.SelectedIndexChanged += cb_searchByCategoryName_SelectedIndexChanged;
            // 
            // tb_searchByProductName
            // 
            tb_searchByProductName.Location = new Point(12, 72);
            tb_searchByProductName.Name = "tb_searchByProductName";
            tb_searchByProductName.Size = new Size(209, 27);
            tb_searchByProductName.TabIndex = 2;
            tb_searchByProductName.TextChanged += tb_searchByProductName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 49);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 3;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 49);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "Category";
            label2.Visible = false;
            // 
            // btn_productAdd
            // 
            btn_productAdd.Location = new Point(853, 358);
            btn_productAdd.Name = "btn_productAdd";
            btn_productAdd.Size = new Size(108, 49);
            btn_productAdd.TabIndex = 5;
            btn_productAdd.Text = "Ürünü Ekle";
            btn_productAdd.UseVisualStyleBackColor = true;
            btn_productAdd.Click += btn_productAdd_Click;
            // 
            // tb_productName
            // 
            tb_productName.Location = new Point(792, 105);
            tb_productName.Name = "tb_productName";
            tb_productName.PlaceholderText = "Ürün İsmi";
            tb_productName.Size = new Size(242, 27);
            tb_productName.TabIndex = 6;
            // 
            // cb_categoryName
            // 
            cb_categoryName.FormattingEnabled = true;
            cb_categoryName.Location = new Point(792, 161);
            cb_categoryName.Name = "cb_categoryName";
            cb_categoryName.Size = new Size(242, 28);
            cb_categoryName.TabIndex = 7;
            cb_categoryName.Text = "Kategoriler";
            // 
            // tb_stockQuantity
            // 
            tb_stockQuantity.Location = new Point(792, 213);
            tb_stockQuantity.Name = "tb_stockQuantity";
            tb_stockQuantity.PlaceholderText = "Miktar";
            tb_stockQuantity.Size = new Size(242, 27);
            tb_stockQuantity.TabIndex = 8;
            // 
            // tb_unitPrice
            // 
            tb_unitPrice.Location = new Point(792, 264);
            tb_unitPrice.Name = "tb_unitPrice";
            tb_unitPrice.PlaceholderText = "Birim Fiyatı";
            tb_unitPrice.Size = new Size(242, 27);
            tb_unitPrice.TabIndex = 10;
            // 
            // dtp_dateAdded
            // 
            dtp_dateAdded.Location = new Point(792, 310);
            dtp_dateAdded.Name = "dtp_dateAdded";
            dtp_dateAdded.Size = new Size(242, 27);
            dtp_dateAdded.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(853, 423);
            button1.Name = "button1";
            button1.Size = new Size(108, 49);
            button1.TabIndex = 12;
            button1.Text = "Ürünü Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_deleteProduct
            // 
            btn_deleteProduct.Location = new Point(853, 489);
            btn_deleteProduct.Name = "btn_deleteProduct";
            btn_deleteProduct.Size = new Size(108, 49);
            btn_deleteProduct.TabIndex = 13;
            btn_deleteProduct.Text = "Ürünü Sil";
            btn_deleteProduct.UseVisualStyleBackColor = true;
            btn_deleteProduct.Click += btn_deleteProduct_Click;
            // 
            // ProductsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 587);
            Controls.Add(btn_deleteProduct);
            Controls.Add(button1);
            Controls.Add(dtp_dateAdded);
            Controls.Add(tb_unitPrice);
            Controls.Add(tb_stockQuantity);
            Controls.Add(cb_categoryName);
            Controls.Add(tb_productName);
            Controls.Add(btn_productAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_searchByProductName);
            Controls.Add(cb_searchByCategoryName);
            Controls.Add(dgw_productsList);
            Name = "ProductsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgw_productsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgw_productsList;
        private ComboBox cb_searchByCategoryName;
        private TextBox tb_searchByProductName;
        private Label label1;
        private Label label2;
        private Button btn_productAdd;
        private TextBox tb_productName;
        private ComboBox cb_categoryName;
        private TextBox tb_stockQuantity;
        private TextBox tb_unitPrice;
        private DateTimePicker dtp_dateAdded;
        private Button button1;
        private Button btn_deleteProduct;
    }
}