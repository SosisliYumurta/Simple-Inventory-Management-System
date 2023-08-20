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
            components = new System.ComponentModel.Container();
            btn_products = new Button();
            btn_categories = new Button();
            btn_customers = new Button();
            btn_productSale = new Button();
            dgv_products = new DataGridView();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ms_products1 = new ToolStripMenuItem();
            ms_customers1 = new ToolStripMenuItem();
            ms_categories1 = new ToolStripMenuItem();
            label1 = new Label();
            tb_searchByProductName = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, ms_products1, ms_customers1, ms_categories1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = Properties.Resources.reflesh_icon;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(34, 24);
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // ms_products1
            // 
            ms_products1.Name = "ms_products1";
            ms_products1.Size = new Size(63, 24);
            ms_products1.Text = "ÜRÜN";
            ms_products1.Click += ms_products1_Click;
            // 
            // ms_customers1
            // 
            ms_customers1.Name = "ms_customers1";
            ms_customers1.Size = new Size(48, 24);
            ms_customers1.Text = "KİŞİ";
            ms_customers1.Click += ms_customers1_Click;
            // 
            // ms_categories1
            // 
            ms_categories1.Name = "ms_categories1";
            ms_categories1.Size = new Size(91, 24);
            ms_categories1.Text = "KATEGORİ";
            ms_categories1.Click += ms_categories1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 35);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 7;
            label1.Text = "Ürün Adı Arama";
            // 
            // tb_searchByProductName
            // 
            tb_searchByProductName.Location = new Point(295, 58);
            tb_searchByProductName.Name = "tb_searchByProductName";
            tb_searchByProductName.Size = new Size(209, 27);
            tb_searchByProductName.TabIndex = 6;
            tb_searchByProductName.TextChanged += tb_searchByProductName_TextChanged;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
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
        private ToolStripMenuItem toolStripMenuItem1;
        private Label label1;
        private TextBox tb_searchByProductName;
        private ToolStripMenuItem ms_products1;
        private ToolStripMenuItem ms_customers1;
        private ToolStripMenuItem ms_categories1;
        private System.Windows.Forms.Timer timer1;
    }
}