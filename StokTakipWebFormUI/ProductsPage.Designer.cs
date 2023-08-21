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
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            btn_reflesh = new Button();
            dtp_end = new DateTimePicker();
            dtp_start = new DateTimePicker();
            label9 = new Label();
            lbl_totalPrice = new Label();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgw_productsList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgw_productsList
            // 
            dgw_productsList.AllowUserToAddRows = false;
            dgw_productsList.AllowUserToDeleteRows = false;
            dgw_productsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_productsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_productsList.Location = new Point(3, 55);
            dgw_productsList.Margin = new Padding(3, 2, 3, 2);
            dgw_productsList.Name = "dgw_productsList";
            dgw_productsList.ReadOnly = true;
            dgw_productsList.RowHeadersWidth = 51;
            dgw_productsList.RowTemplate.Height = 29;
            dgw_productsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_productsList.Size = new Size(1059, 568);
            dgw_productsList.TabIndex = 0;
            dgw_productsList.UseWaitCursor = true;
            dgw_productsList.CellClick += dgw_productsList_CellClick;
            dgw_productsList.ColumnHeaderMouseClick += dgw_productsList_ColumnHeaderMouseClick;
            // 
            // cb_searchByCategoryName
            // 
            cb_searchByCategoryName.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_searchByCategoryName.FormattingEnabled = true;
            cb_searchByCategoryName.Location = new Point(234, 31);
            cb_searchByCategoryName.Margin = new Padding(3, 2, 3, 2);
            cb_searchByCategoryName.Name = "cb_searchByCategoryName";
            cb_searchByCategoryName.Size = new Size(179, 23);
            cb_searchByCategoryName.TabIndex = 2;
            cb_searchByCategoryName.UseWaitCursor = true;
            cb_searchByCategoryName.SelectedIndexChanged += cb_searchByCategoryName_SelectedIndexChanged;
            // 
            // tb_searchByProductName
            // 
            tb_searchByProductName.Location = new Point(32, 31);
            tb_searchByProductName.Margin = new Padding(3, 2, 3, 2);
            tb_searchByProductName.Name = "tb_searchByProductName";
            tb_searchByProductName.Size = new Size(183, 23);
            tb_searchByProductName.TabIndex = 1;
            tb_searchByProductName.UseWaitCursor = true;
            tb_searchByProductName.TextChanged += tb_searchByProductName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 12);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 3;
            label1.Text = "Ürün Adı Arama";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 12);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "Category";
            label2.UseWaitCursor = true;
            // 
            // btn_productAdd
            // 
            btn_productAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btn_productAdd.Image = Properties.Resources.Plus;
            btn_productAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btn_productAdd.Location = new Point(1108, 317);
            btn_productAdd.Margin = new Padding(3, 2, 3, 2);
            btn_productAdd.Name = "btn_productAdd";
            btn_productAdd.Size = new Size(147, 44);
            btn_productAdd.TabIndex = 11;
            btn_productAdd.Text = "Ürünü Ekle";
            btn_productAdd.TextAlign = ContentAlignment.MiddleRight;
            btn_productAdd.UseVisualStyleBackColor = true;
            btn_productAdd.UseWaitCursor = true;
            btn_productAdd.Click += btn_productAdd_Click;
            // 
            // tb_productName
            // 
            tb_productName.Location = new Point(1076, 77);
            tb_productName.Margin = new Padding(3, 2, 3, 2);
            tb_productName.Name = "tb_productName";
            tb_productName.PlaceholderText = "Ürün İsmi";
            tb_productName.Size = new Size(212, 23);
            tb_productName.TabIndex = 6;
            tb_productName.UseWaitCursor = true;
            // 
            // cb_categoryName
            // 
            cb_categoryName.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_categoryName.FormattingEnabled = true;
            cb_categoryName.Location = new Point(1076, 128);
            cb_categoryName.Margin = new Padding(3, 2, 3, 2);
            cb_categoryName.Name = "cb_categoryName";
            cb_categoryName.Size = new Size(212, 23);
            cb_categoryName.TabIndex = 7;
            cb_categoryName.UseWaitCursor = true;
            // 
            // tb_stockQuantity
            // 
            tb_stockQuantity.Location = new Point(1076, 178);
            tb_stockQuantity.Margin = new Padding(3, 2, 3, 2);
            tb_stockQuantity.Name = "tb_stockQuantity";
            tb_stockQuantity.PlaceholderText = "Miktar";
            tb_stockQuantity.Size = new Size(212, 23);
            tb_stockQuantity.TabIndex = 8;
            tb_stockQuantity.UseWaitCursor = true;
            // 
            // tb_unitPrice
            // 
            tb_unitPrice.Location = new Point(1076, 229);
            tb_unitPrice.Margin = new Padding(3, 2, 3, 2);
            tb_unitPrice.Name = "tb_unitPrice";
            tb_unitPrice.PlaceholderText = "Birim Fiyatı";
            tb_unitPrice.Size = new Size(212, 23);
            tb_unitPrice.TabIndex = 9;
            tb_unitPrice.UseWaitCursor = true;
            // 
            // dtp_dateAdded
            // 
            dtp_dateAdded.Location = new Point(1075, 279);
            dtp_dateAdded.Margin = new Padding(3, 2, 3, 2);
            dtp_dateAdded.Name = "dtp_dateAdded";
            dtp_dateAdded.Size = new Size(212, 23);
            dtp_dateAdded.TabIndex = 10;
            dtp_dateAdded.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Edit;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1108, 369);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(147, 44);
            button1.TabIndex = 12;
            button1.Text = "Ürünü Güncelle";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // btn_deleteProduct
            // 
            btn_deleteProduct.Image = Properties.Resources.Trash;
            btn_deleteProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btn_deleteProduct.Location = new Point(1108, 421);
            btn_deleteProduct.Margin = new Padding(3, 2, 3, 2);
            btn_deleteProduct.Name = "btn_deleteProduct";
            btn_deleteProduct.Size = new Size(147, 44);
            btn_deleteProduct.TabIndex = 13;
            btn_deleteProduct.Text = "Ürünü Sil";
            btn_deleteProduct.TextAlign = ContentAlignment.MiddleRight;
            btn_deleteProduct.UseVisualStyleBackColor = true;
            btn_deleteProduct.UseWaitCursor = true;
            btn_deleteProduct.Click += btn_deleteProduct_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.Microsoft_Excel;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(970, 12);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(91, 39);
            button2.TabIndex = 6;
            button2.Text = "Export";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1152, 55);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 16;
            label3.Text = "Ürün İsmi";
            label3.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1153, 105);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 17;
            label4.Text = "Kategori";
            label4.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1143, 156);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 18;
            label5.Text = "Ürün Miktarı";
            label5.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1130, 206);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 19;
            label6.Text = "Ürün Birim Fiyatı";
            label6.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1164, 256);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 21;
            label8.Text = "Tarih";
            label8.UseWaitCursor = true;
            // 
            // btn_reflesh
            // 
            btn_reflesh.BackgroundImage = Properties.Resources.Restart;
            btn_reflesh.BackgroundImageLayout = ImageLayout.Stretch;
            btn_reflesh.Location = new Point(906, 31);
            btn_reflesh.Margin = new Padding(3, 2, 3, 2);
            btn_reflesh.Name = "btn_reflesh";
            btn_reflesh.Size = new Size(36, 22);
            btn_reflesh.TabIndex = 5;
            btn_reflesh.UseVisualStyleBackColor = true;
            btn_reflesh.UseWaitCursor = true;
            btn_reflesh.Click += btn_reflesh_Click;
            // 
            // dtp_end
            // 
            dtp_end.Location = new Point(682, 31);
            dtp_end.Margin = new Padding(3, 2, 3, 2);
            dtp_end.Name = "dtp_end";
            dtp_end.Size = new Size(219, 23);
            dtp_end.TabIndex = 4;
            dtp_end.UseWaitCursor = true;
            dtp_end.ValueChanged += dtp_end_ValueChanged;
            // 
            // dtp_start
            // 
            dtp_start.Location = new Point(444, 31);
            dtp_start.Margin = new Padding(3, 2, 3, 2);
            dtp_start.Name = "dtp_start";
            dtp_start.Size = new Size(219, 23);
            dtp_start.TabIndex = 3;
            dtp_start.UseWaitCursor = true;
            dtp_start.ValueChanged += dtp_start_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1067, 574);
            label9.Name = "label9";
            label9.Size = new Size(125, 25);
            label9.TabIndex = 30;
            label9.Text = "Toplam Fiyat:";
            label9.UseWaitCursor = true;
            // 
            // lbl_totalPrice
            // 
            lbl_totalPrice.AutoSize = true;
            lbl_totalPrice.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_totalPrice.Location = new Point(1192, 576);
            lbl_totalPrice.Name = "lbl_totalPrice";
            lbl_totalPrice.Size = new Size(32, 25);
            lbl_totalPrice.TabIndex = 31;
            lbl_totalPrice.Text = "00";
            lbl_totalPrice.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Search;
            pictureBox2.Location = new Point(3, 30);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(508, 14);
            label10.Name = "label10";
            label10.Size = new Size(88, 15);
            label10.TabIndex = 33;
            label10.Text = "Başlangıç Tarihi";
            label10.UseWaitCursor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(756, 14);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 34;
            label11.Text = "Bitiş Tarihi";
            label11.UseWaitCursor = true;
            // 
            // ProductsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 632);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(pictureBox2);
            Controls.Add(lbl_totalPrice);
            Controls.Add(label9);
            Controls.Add(btn_reflesh);
            Controls.Add(dtp_end);
            Controls.Add(dtp_start);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
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
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ÜRÜNLER";
            UseWaitCursor = true;
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            KeyDown += ProductsPage_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgw_productsList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Button btn_reflesh;
        private DateTimePicker dtp_end;
        private DateTimePicker dtp_start;
        private Label label9;
        private Label lbl_totalPrice;
        private PictureBox pictureBox2;
        private Label label10;
        private Label label11;
    }
}