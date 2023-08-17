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
            dgv_categoriesList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_categoriesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categoriesList.Location = new Point(12, 12);
            dgv_categoriesList.Name = "dgv_categoriesList";
            dgv_categoriesList.RowHeadersWidth = 51;
            dgv_categoriesList.RowTemplate.Height = 29;
            dgv_categoriesList.Size = new Size(428, 426);
            dgv_categoriesList.TabIndex = 0;
            dgv_categoriesList.CellClick += dgv_categoriesList_CellClick;
            // 
            // tb_CategoryName
            // 
            tb_CategoryName.Location = new Point(518, 107);
            tb_CategoryName.Name = "tb_CategoryName";
            tb_CategoryName.Size = new Size(201, 27);
            tb_CategoryName.TabIndex = 23;
            // 
            // btn_deleteCategory
            // 
            btn_deleteCategory.Location = new Point(569, 282);
            btn_deleteCategory.Name = "btn_deleteCategory";
            btn_deleteCategory.Size = new Size(108, 49);
            btn_deleteCategory.TabIndex = 21;
            btn_deleteCategory.Text = "Kategori Sil";
            btn_deleteCategory.UseVisualStyleBackColor = true;
            btn_deleteCategory.Click += btn_deleteCategory_Click;
            // 
            // btn_updateCustomer
            // 
            btn_updateCustomer.Location = new Point(569, 216);
            btn_updateCustomer.Name = "btn_updateCustomer";
            btn_updateCustomer.Size = new Size(108, 49);
            btn_updateCustomer.TabIndex = 20;
            btn_updateCustomer.Text = "Kategori Güncelle";
            btn_updateCustomer.UseVisualStyleBackColor = true;
            btn_updateCustomer.Click += btn_updateCustomer_Click;
            // 
            // btn_categoryAdd
            // 
            btn_categoryAdd.Location = new Point(569, 151);
            btn_categoryAdd.Name = "btn_categoryAdd";
            btn_categoryAdd.Size = new Size(108, 49);
            btn_categoryAdd.TabIndex = 19;
            btn_categoryAdd.Text = "Kategori Ekle";
            btn_categoryAdd.UseVisualStyleBackColor = true;
            btn_categoryAdd.Click += btn_categoryAdd_Click;
            // 
            // CategoriesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(tb_CategoryName);
            Controls.Add(btn_deleteCategory);
            Controls.Add(btn_updateCustomer);
            Controls.Add(btn_categoryAdd);
            Controls.Add(dgv_categoriesList);
            Name = "CategoriesPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoriesPage";
            Load += CategoriesPage_Load;
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