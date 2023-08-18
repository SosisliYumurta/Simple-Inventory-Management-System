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
            menuStrip1 = new MenuStrip();
            menu_strip_tools = new ToolStripMenuItem();
            ms_products = new ToolStripMenuItem();
            ms_customers = new ToolStripMenuItem();
            ms_categories = new ToolStripMenuItem();
            ms_productsSales = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            label1 = new Label();
            tb_searchByProductName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_products
            // 
            btn_products.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_products.Location = new Point(823, 407);
            btn_products.Name = "btn_products";
            btn_products.Size = new Size(166, 47);
            btn_products.TabIndex = 0;
            btn_products.Text = "ÜRÜNLER";
            btn_products.UseVisualStyleBackColor = true;
            btn_products.Visible = false;
            btn_products.Click += btn_products_Click;
            // 
            // btn_categories
            // 
            btn_categories.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_categories.Location = new Point(855, 205);
            btn_categories.Name = "btn_categories";
            btn_categories.Size = new Size(166, 47);
            btn_categories.TabIndex = 1;
            btn_categories.Text = "KATEGORİLER";
            btn_categories.UseVisualStyleBackColor = true;
            btn_categories.Visible = false;
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
            btn_customers.Visible = false;
            btn_customers.Click += btn_customers_Click;
            // 
            // btn_productSale
            // 
            btn_productSale.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_productSale.Location = new Point(12, 39);
            btn_productSale.Name = "btn_productSale";
            btn_productSale.Size = new Size(166, 46);
            btn_productSale.TabIndex = 3;
            btn_productSale.Text = "VERİLEN ÜRÜNLER";
            btn_productSale.UseVisualStyleBackColor = true;
            btn_productSale.Click += btn_productSale_Click;
            // 
            // dgv_products
            // 
            dgv_products.AllowUserToAddRows = false;
            dgv_products.AllowUserToDeleteRows = false;
            dgv_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_products.Location = new Point(12, 87);
            dgv_products.Name = "dgv_products";
            dgv_products.ReadOnly = true;
            dgv_products.RowHeadersWidth = 51;
            dgv_products.RowTemplate.Height = 29;
            dgv_products.Size = new Size(1878, 878);
            dgv_products.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu_strip_tools, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu_strip_tools
            // 
            menu_strip_tools.DropDownItems.AddRange(new ToolStripItem[] { ms_products, ms_customers, ms_categories, ms_productsSales });
            menu_strip_tools.Name = "menu_strip_tools";
            menu_strip_tools.Size = new Size(87, 24);
            menu_strip_tools.Text = "İŞLEMLER";
            // 
            // ms_products
            // 
            ms_products.Name = "ms_products";
            ms_products.Size = new Size(261, 26);
            ms_products.Text = "ÜRÜNLER";
            ms_products.Click += ms_products_Click;
            // 
            // ms_customers
            // 
            ms_customers.Name = "ms_customers";
            ms_customers.Size = new Size(261, 26);
            ms_customers.Text = "MÜŞTERİLER";
            ms_customers.Click += ms_customers_Click;
            // 
            // ms_categories
            // 
            ms_categories.Name = "ms_categories";
            ms_categories.Size = new Size(261, 26);
            ms_categories.Text = "KATEGORİLER";
            ms_categories.Click += ms_categories_Click;
            // 
            // ms_productsSales
            // 
            ms_productsSales.Name = "ms_productsSales";
            ms_productsSales.Size = new Size(261, 26);
            ms_productsSales.Text = "TESLİM EDİLEN ÜRÜNLER";
            ms_productsSales.Click += ms_productsSales_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = Properties.Resources.reflesh_icon;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(34, 24);
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 26);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 7;
            label1.Text = "Ürün Adı Arama";
            // 
            // tb_searchByProductName
            // 
            tb_searchByProductName.Location = new Point(299, 49);
            tb_searchByProductName.Name = "tb_searchByProductName";
            tb_searchByProductName.Size = new Size(209, 27);
            tb_searchByProductName.TabIndex = 6;
            tb_searchByProductName.TextChanged += tb_searchByProductName_TextChanged;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label1);
            Controls.Add(tb_searchByProductName);
            Controls.Add(dgv_products);
            Controls.Add(btn_productSale);
            Controls.Add(btn_customers);
            Controls.Add(btn_categories);
            Controls.Add(btn_products);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainPage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ANA SAYFA";
            Load += MainPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_products;
        private Button btn_categories;
        private Button btn_customers;
        private Button btn_productSale;
        private DataGridView dgv_products;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu_strip_tools;
        private ToolStripMenuItem ms_products;
        private ToolStripMenuItem ms_customers;
        private ToolStripMenuItem ms_categories;
        private ToolStripMenuItem ms_productsSales;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label label1;
        private TextBox tb_searchByProductName;
    }
}