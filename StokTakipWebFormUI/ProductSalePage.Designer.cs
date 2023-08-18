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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btn_sell = new Button();
            tb_quantity = new TextBox();
            cb_products = new ComboBox();
            cb_customers = new ComboBox();
            dgv_saleDetails = new DataGridView();
            dtp_dateProductSale = new DateTimePicker();
            label1 = new Label();
            tb_searchByCustomerName = new TextBox();
            label2 = new Label();
            tb_searchByProductName = new TextBox();
            btn_deleteProductSale = new Button();
            btn_updateProductSale = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_export = new Button();
            dtp_start = new DateTimePicker();
            dtp_end = new DateTimePicker();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_saleDetails).BeginInit();
            SuspendLayout();
            // 
            // btn_sell
            // 
            btn_sell.Location = new Point(1303, 452);
            btn_sell.Name = "btn_sell";
            btn_sell.Size = new Size(108, 48);
            btn_sell.TabIndex = 0;
            btn_sell.Text = "Teslim Et";
            btn_sell.UseVisualStyleBackColor = true;
            btn_sell.Click += btn_sell_Click;
            btn_sell.KeyDown += btn_sell_KeyDown;
            // 
            // tb_quantity
            // 
            tb_quantity.Location = new Point(1228, 306);
            tb_quantity.Name = "tb_quantity";
            tb_quantity.PlaceholderText = "Miktar";
            tb_quantity.Size = new Size(242, 27);
            tb_quantity.TabIndex = 1;
            // 
            // cb_products
            // 
            cb_products.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_products.FormattingEnabled = true;
            cb_products.Location = new Point(1228, 114);
            cb_products.Name = "cb_products";
            cb_products.Size = new Size(242, 28);
            cb_products.TabIndex = 2;
            // 
            // cb_customers
            // 
            cb_customers.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_customers.FormattingEnabled = true;
            cb_customers.Location = new Point(1228, 210);
            cb_customers.Name = "cb_customers";
            cb_customers.Size = new Size(242, 28);
            cb_customers.TabIndex = 3;
            // 
            // dgv_saleDetails
            // 
            dgv_saleDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_saleDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_saleDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_saleDetails.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_saleDetails.Location = new Point(12, 70);
            dgv_saleDetails.Name = "dgv_saleDetails";
            dgv_saleDetails.RowHeadersWidth = 51;
            dgv_saleDetails.RowTemplate.Height = 29;
            dgv_saleDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_saleDetails.Size = new Size(1210, 871);
            dgv_saleDetails.TabIndex = 5;
            dgv_saleDetails.CellClick += dgv_saleDetails_CellClick;
            // 
            // dtp_dateProductSale
            // 
            dtp_dateProductSale.Location = new Point(1228, 401);
            dtp_dateProductSale.Name = "dtp_dateProductSale";
            dtp_dateProductSale.Size = new Size(242, 27);
            dtp_dateProductSale.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 14);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 14;
            label1.Text = "Müşteri Adı Arama";
            // 
            // tb_searchByCustomerName
            // 
            tb_searchByCustomerName.Location = new Point(12, 37);
            tb_searchByCustomerName.Name = "tb_searchByCustomerName";
            tb_searchByCustomerName.Size = new Size(209, 27);
            tb_searchByCustomerName.TabIndex = 13;
            tb_searchByCustomerName.TextChanged += tb_searchByCustomerName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 14);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 16;
            label2.Text = "Ürün Adı Arama";
            // 
            // tb_searchByProductName
            // 
            tb_searchByProductName.Location = new Point(253, 37);
            tb_searchByProductName.Name = "tb_searchByProductName";
            tb_searchByProductName.Size = new Size(209, 27);
            tb_searchByProductName.TabIndex = 15;
            tb_searchByProductName.TextChanged += tb_searchByProductName_TextChanged;
            // 
            // btn_deleteProductSale
            // 
            btn_deleteProductSale.Location = new Point(1303, 597);
            btn_deleteProductSale.Name = "btn_deleteProductSale";
            btn_deleteProductSale.Size = new Size(108, 49);
            btn_deleteProductSale.TabIndex = 18;
            btn_deleteProductSale.Text = "Teslimatı Sil";
            btn_deleteProductSale.UseVisualStyleBackColor = true;
            btn_deleteProductSale.Click += btn_deleteProductSale_Click;
            // 
            // btn_updateProductSale
            // 
            btn_updateProductSale.Location = new Point(1303, 524);
            btn_updateProductSale.Name = "btn_updateProductSale";
            btn_updateProductSale.Size = new Size(108, 49);
            btn_updateProductSale.TabIndex = 17;
            btn_updateProductSale.Text = "Teslimatı Güncelle";
            btn_updateProductSale.UseVisualStyleBackColor = true;
            btn_updateProductSale.Click += btn_updateProductSale_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1303, 70);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 19;
            label3.Text = "Ürün Seçiniz.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1311, 169);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 20;
            label4.Text = "Teslim Alan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1275, 262);
            label5.Name = "label5";
            label5.Size = new Size(156, 20);
            label5.TabIndex = 21;
            label5.Text = "Teslim Edilecek Miktar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1303, 357);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 22;
            label6.Text = "Tarih Giriniz";
            // 
            // btn_export
            // 
            btn_export.Location = new Point(1107, 14);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(115, 50);
            btn_export.TabIndex = 23;
            btn_export.Text = "Export";
            btn_export.UseVisualStyleBackColor = true;
            btn_export.Click += btn_export_Click;
            // 
            // dtp_start
            // 
            dtp_start.Location = new Point(512, 35);
            dtp_start.Name = "dtp_start";
            dtp_start.Size = new Size(250, 27);
            dtp_start.TabIndex = 24;
            dtp_start.ValueChanged += dtp_start_ValueChanged;
            // 
            // dtp_end
            // 
            dtp_end.Location = new Point(782, 35);
            dtp_end.Name = "dtp_end";
            dtp_end.Size = new Size(250, 27);
            dtp_end.TabIndex = 25;
            dtp_end.ValueChanged += dtp_end_ValueChanged;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.reflesh_icon;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(1038, 22);
            button1.Name = "button1";
            button1.Size = new Size(41, 42);
            button1.TabIndex = 26;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProductSalePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 953);
            Controls.Add(button1);
            Controls.Add(dtp_end);
            Controls.Add(dtp_start);
            Controls.Add(btn_export);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_deleteProductSale);
            Controls.Add(btn_updateProductSale);
            Controls.Add(label2);
            Controls.Add(tb_searchByProductName);
            Controls.Add(label1);
            Controls.Add(tb_searchByCustomerName);
            Controls.Add(dtp_dateProductSale);
            Controls.Add(dgv_saleDetails);
            Controls.Add(cb_customers);
            Controls.Add(cb_products);
            Controls.Add(tb_quantity);
            Controls.Add(btn_sell);
            KeyPreview = true;
            Name = "ProductSalePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TESLİM EDİLEN ÜRÜNLER";
            Load += ProductSalePage_Load;
            KeyDown += ProductSalePage_KeyDown;
            KeyPress += ProductSalePage_KeyPress;
            ((System.ComponentModel.ISupportInitialize)dgv_saleDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_sell;
        private TextBox tb_quantity;
        private ComboBox cb_products;
        private ComboBox cb_customers;
        private DataGridView dgv_saleDetails;
        private DateTimePicker dtp_dateProductSale;
        private Label label1;
        private TextBox tb_searchByCustomerName;
        private Label label2;
        private TextBox tb_searchByProductName;
        private Button btn_deleteProductSale;
        private Button btn_updateProductSale;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_export;
        private DateTimePicker dtp_start;
        private DateTimePicker dtp_end;
        private Button button1;
    }
}