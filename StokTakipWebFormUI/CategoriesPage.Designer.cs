namespace StokTakipWebFormUI
{
    partial class CategoriesPage
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
            dgv_categoriesList = new DataGridView();
            tb_CategoryName = new TextBox();
            btn_deleteCategory = new Button();
            btn_updateCustomer = new Button();
            btn_categoryAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_categoriesList).BeginInit();
            SuspendLayout();
            // 
            // dgv_categoriesList
            // 
            dgv_categoriesList.AllowUserToAddRows = false;
            dgv_categoriesList.AllowUserToDeleteRows = false;
            dgv_categoriesList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_categoriesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categoriesList.Location = new Point(10, 9);
            dgv_categoriesList.Margin = new Padding(3, 2, 3, 2);
            dgv_categoriesList.Name = "dgv_categoriesList";
            dgv_categoriesList.ReadOnly = true;
            dgv_categoriesList.RowHeadersWidth = 51;
            dgv_categoriesList.RowTemplate.Height = 29;
            dgv_categoriesList.Size = new Size(1095, 697);
            dgv_categoriesList.TabIndex = 0;
            dgv_categoriesList.CellClick += dgv_categoriesList_CellClick;
            dgv_categoriesList.ColumnHeaderMouseClick += dgv_categoriesList_ColumnHeaderMouseClick;
            // 
            // tb_CategoryName
            // 
            tb_CategoryName.Location = new Point(1110, 58);
            tb_CategoryName.Margin = new Padding(3, 2, 3, 2);
            tb_CategoryName.Name = "tb_CategoryName";
            tb_CategoryName.PlaceholderText = "Kategori Adı";
            tb_CategoryName.Size = new Size(176, 23);
            tb_CategoryName.TabIndex = 1;
            // 
            // btn_deleteCategory
            // 
            btn_deleteCategory.Image = Properties.Resources.Trash;
            btn_deleteCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btn_deleteCategory.Location = new Point(1120, 184);
            btn_deleteCategory.Margin = new Padding(3, 2, 3, 2);
            btn_deleteCategory.Name = "btn_deleteCategory";
            btn_deleteCategory.Size = new Size(158, 44);
            btn_deleteCategory.TabIndex = 4;
            btn_deleteCategory.Text = "Kategori Sil";
            btn_deleteCategory.TextAlign = ContentAlignment.MiddleRight;
            btn_deleteCategory.UseVisualStyleBackColor = true;
            btn_deleteCategory.Click += btn_deleteCategory_Click;
            // 
            // btn_updateCustomer
            // 
            btn_updateCustomer.Image = Properties.Resources.Edit;
            btn_updateCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_updateCustomer.Location = new Point(1120, 139);
            btn_updateCustomer.Margin = new Padding(3, 2, 3, 2);
            btn_updateCustomer.Name = "btn_updateCustomer";
            btn_updateCustomer.Size = new Size(158, 44);
            btn_updateCustomer.TabIndex = 3;
            btn_updateCustomer.Text = "Kategori Güncelle";
            btn_updateCustomer.TextAlign = ContentAlignment.MiddleRight;
            btn_updateCustomer.UseVisualStyleBackColor = true;
            btn_updateCustomer.Click += btn_updateCustomer_Click;
            // 
            // btn_categoryAdd
            // 
            btn_categoryAdd.Image = Properties.Resources.Plus;
            btn_categoryAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btn_categoryAdd.Location = new Point(1120, 94);
            btn_categoryAdd.Margin = new Padding(3, 2, 3, 2);
            btn_categoryAdd.Name = "btn_categoryAdd";
            btn_categoryAdd.Size = new Size(158, 44);
            btn_categoryAdd.TabIndex = 2;
            btn_categoryAdd.Text = "Kategori Ekle";
            btn_categoryAdd.TextAlign = ContentAlignment.MiddleRight;
            btn_categoryAdd.UseVisualStyleBackColor = true;
            btn_categoryAdd.Click += btn_categoryAdd_Click;
            // 
            // CategoriesPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 715);
            Controls.Add(tb_CategoryName);
            Controls.Add(btn_deleteCategory);
            Controls.Add(btn_updateCustomer);
            Controls.Add(btn_categoryAdd);
            Controls.Add(dgv_categoriesList);
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CategoriesPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KATEGORİLER";
            WindowState = FormWindowState.Maximized;
            Load += CategoriesPage_Load;
            KeyDown += CategoriesPage_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgv_categoriesList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_categoriesList;
        private TextBox tb_CategoryName;
        private Button btn_deleteCategory;
        private Button btn_updateCustomer;
        private Button btn_categoryAdd;
    }
}