namespace StokTakipWebFormUI
{
    partial class CustomersPage
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
            dgv_CustomersList = new DataGridView();
            btn_deleteCustomer = new Button();
            btn_customerUpdate = new Button();
            btn_cusstomerAdd = new Button();
            tb_customerName = new TextBox();
            tb_customerContactInfo = new TextBox();
            tb_companyName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_CustomersList).BeginInit();
            SuspendLayout();
            // 
            // dgv_CustomersList
            // 
            dgv_CustomersList.AllowUserToAddRows = false;
            dgv_CustomersList.AllowUserToDeleteRows = false;
            dgv_CustomersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CustomersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_CustomersList.Location = new Point(12, 12);
            dgv_CustomersList.Name = "dgv_CustomersList";
            dgv_CustomersList.ReadOnly = true;
            dgv_CustomersList.RowHeadersWidth = 51;
            dgv_CustomersList.RowTemplate.Height = 29;
            dgv_CustomersList.Size = new Size(1199, 929);
            dgv_CustomersList.TabIndex = 0;
            dgv_CustomersList.CellClick += dgv_CustomersList_CellClick;
            dgv_CustomersList.ColumnHeaderMouseClick += dgv_CustomersList_ColumnHeaderMouseClick;
            // 
            // btn_deleteCustomer
            // 
            btn_deleteCustomer.Image = Properties.Resources.Trash;
            btn_deleteCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_deleteCustomer.Location = new Point(1257, 359);
            btn_deleteCustomer.Name = "btn_deleteCustomer";
            btn_deleteCustomer.Size = new Size(177, 59);
            btn_deleteCustomer.TabIndex = 5;
            btn_deleteCustomer.Text = "Müşteri Sil";
            btn_deleteCustomer.TextAlign = ContentAlignment.MiddleRight;
            btn_deleteCustomer.UseVisualStyleBackColor = true;
            btn_deleteCustomer.Click += btn_deleteCustomer_Click;
            // 
            // btn_customerUpdate
            // 
            btn_customerUpdate.Image = Properties.Resources.Edit;
            btn_customerUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btn_customerUpdate.Location = new Point(1257, 292);
            btn_customerUpdate.Name = "btn_customerUpdate";
            btn_customerUpdate.Size = new Size(177, 59);
            btn_customerUpdate.TabIndex = 4;
            btn_customerUpdate.Text = "Müşteri Güncelle";
            btn_customerUpdate.TextAlign = ContentAlignment.MiddleRight;
            btn_customerUpdate.UseVisualStyleBackColor = true;
            btn_customerUpdate.Click += btn_customerUpdate_Click;
            // 
            // btn_cusstomerAdd
            // 
            btn_cusstomerAdd.Image = Properties.Resources.Plus;
            btn_cusstomerAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cusstomerAdd.Location = new Point(1257, 225);
            btn_cusstomerAdd.Name = "btn_cusstomerAdd";
            btn_cusstomerAdd.Size = new Size(177, 59);
            btn_cusstomerAdd.TabIndex = 3;
            btn_cusstomerAdd.Text = "Müşteri Ekle";
            btn_cusstomerAdd.TextAlign = ContentAlignment.MiddleRight;
            btn_cusstomerAdd.UseVisualStyleBackColor = true;
            btn_cusstomerAdd.Click += btn_cusstomerAdd_Click;
            // 
            // tb_customerName
            // 
            tb_customerName.Location = new Point(1217, 100);
            tb_customerName.Name = "tb_customerName";
            tb_customerName.PlaceholderText = "Müşteri Adı";
            tb_customerName.Size = new Size(253, 27);
            tb_customerName.TabIndex = 1;
            // 
            // tb_customerContactInfo
            // 
            tb_customerContactInfo.Location = new Point(1217, 484);
            tb_customerContactInfo.Name = "tb_customerContactInfo";
            tb_customerContactInfo.PlaceholderText = "İletişim";
            tb_customerContactInfo.Size = new Size(253, 27);
            tb_customerContactInfo.TabIndex = 18;
            tb_customerContactInfo.Visible = false;
            // 
            // tb_companyName
            // 
            tb_companyName.Location = new Point(1217, 183);
            tb_companyName.Name = "tb_companyName";
            tb_companyName.PlaceholderText = "Firma Adı";
            tb_companyName.Size = new Size(253, 27);
            tb_companyName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1270, 62);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 20;
            label1.Text = "Müşteri Adı Giriniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1282, 146);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 21;
            label2.Text = "Firma Adı Giriniz";
            // 
            // CustomersPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 953);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_companyName);
            Controls.Add(tb_customerContactInfo);
            Controls.Add(tb_customerName);
            Controls.Add(btn_deleteCustomer);
            Controls.Add(btn_customerUpdate);
            Controls.Add(btn_cusstomerAdd);
            Controls.Add(dgv_CustomersList);
            KeyPreview = true;
            Name = "CustomersPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MÜŞTERİLER";
            Load += CustomersPage_Load;
            KeyDown += CustomersPage_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgv_CustomersList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_CustomersList;
        private Button btn_deleteCustomer;
        private Button btn_customerUpdate;
        private Button btn_cusstomerAdd;
        private TextBox tb_customerName;
        private TextBox tb_customerContactInfo;
        private TextBox tb_companyName;
        private Label label1;
        private Label label2;
    }
}