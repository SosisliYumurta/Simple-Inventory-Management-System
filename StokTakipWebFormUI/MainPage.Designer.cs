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
            btn_productSale = new Button();
            dgv_products = new DataGridView();
            menuStrip1 = new MenuStrip();
            ms_products1 = new ToolStripMenuItem();
            ms_customers1 = new ToolStripMenuItem();
            ms_categories1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            label1 = new Label();
            tb_searchByProductName = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_productSale
            // 
            btn_productSale.BackColor = Color.Transparent;
            btn_productSale.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_productSale.Image = Properties.Resources.Shipped;
            btn_productSale.ImageAlign = ContentAlignment.MiddleLeft;
            btn_productSale.Location = new Point(17, 59);
            btn_productSale.Name = "btn_productSale";
            btn_productSale.Size = new Size(230, 50);
            btn_productSale.TabIndex = 3;
            btn_productSale.Text = "VERİLEN ÜRÜNLER";
            btn_productSale.TextAlign = ContentAlignment.MiddleRight;
            btn_productSale.UseVisualStyleBackColor = false;
            btn_productSale.Click += btn_productSale_Click;
            // 
            // dgv_products
            // 
            dgv_products.AllowUserToAddRows = false;
            dgv_products.AllowUserToDeleteRows = false;
            dgv_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_products.Location = new Point(17, 115);
            dgv_products.Name = "dgv_products";
            dgv_products.ReadOnly = true;
            dgv_products.RowHeadersWidth = 51;
            dgv_products.RowTemplate.Height = 29;
            dgv_products.Size = new Size(1871, 880);
            dgv_products.TabIndex = 4;
            dgv_products.CellDoubleClick += dgv_products_CellDoubleClick;
            dgv_products.CellFormatting += dgv_products_CellFormatting;
            dgv_products.ColumnHeaderMouseClick += dgv_products_ColumnHeaderMouseClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ms_products1, ms_customers1, ms_categories1, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1902, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "HAKKINDA";
            // 
            // ms_products1
            // 
            ms_products1.Image = Properties.Resources.Box;
            ms_products1.Name = "ms_products1";
            ms_products1.Size = new Size(83, 24);
            ms_products1.Text = "ÜRÜN";
            ms_products1.Click += ms_products1_Click;
            // 
            // ms_customers1
            // 
            ms_customers1.Image = Properties.Resources.User_Male;
            ms_customers1.Name = "ms_customers1";
            ms_customers1.Size = new Size(68, 24);
            ms_customers1.Text = "KİŞİ";
            ms_customers1.Click += ms_customers1_Click;
            // 
            // ms_categories1
            // 
            ms_categories1.Image = Properties.Resources.category;
            ms_categories1.Name = "ms_categories1";
            ms_categories1.Size = new Size(111, 24);
            ms_categories1.Text = "KATEGORİ";
            ms_categories1.Click += ms_categories1_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = Properties.Resources.reflesh_icon;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(89, 24);
            toolStripMenuItem1.Text = "YENİLE";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(403, 59);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 7;
            label1.Text = "Ürün Adı Arama";
            label1.Click += label1_Click;
            // 
            // tb_searchByProductName
            // 
            tb_searchByProductName.Location = new Point(355, 82);
            tb_searchByProductName.Name = "tb_searchByProductName";
            tb_searchByProductName.Size = new Size(209, 27);
            tb_searchByProductName.TabIndex = 4;
            tb_searchByProductName.TextChanged += tb_searchByProductName_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.KARDÖKMAK_LOGO_;
            pictureBox1.Location = new Point(1614, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Search;
            pictureBox2.Location = new Point(322, 82);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(tb_searchByProductName);
            Controls.Add(dgv_products);
            Controls.Add(btn_productSale);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainPage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ANA SAYFA";
            WindowState = FormWindowState.Maximized;
            Load += MainPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_productSale;
        private DataGridView dgv_products;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label label1;
        private TextBox tb_searchByProductName;
        private ToolStripMenuItem ms_products1;
        private ToolStripMenuItem ms_customers1;
        private ToolStripMenuItem ms_categories1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}