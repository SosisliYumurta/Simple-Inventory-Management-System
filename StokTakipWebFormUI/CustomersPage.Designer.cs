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
            ((System.ComponentModel.ISupportInitialize)dgv_CustomersList).BeginInit();
            SuspendLayout();
            // 
            // dgv_CustomersList
            // 
            dgv_CustomersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CustomersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_CustomersList.Location = new Point(12, 12);
            dgv_CustomersList.Name = "dgv_CustomersList";
            dgv_CustomersList.RowHeadersWidth = 51;
            dgv_CustomersList.RowTemplate.Height = 29;
            dgv_CustomersList.Size = new Size(573, 493);
            dgv_CustomersList.TabIndex = 1;
            dgv_CustomersList.CellClick += dgv_CustomersList_CellClick;
            // 
            // btn_deleteCustomer
            // 
            btn_deleteCustomer.Location = new Point(690, 370);
            btn_deleteCustomer.Name = "btn_deleteCustomer";
            btn_deleteCustomer.Size = new Size(108, 49);
            btn_deleteCustomer.TabIndex = 16;
            btn_deleteCustomer.Text = "Müşteri Sil";
            btn_deleteCustomer.UseVisualStyleBackColor = true;
            btn_deleteCustomer.Click += btn_deleteCustomer_Click;
            // 
            // btn_customerUpdate
            // 
            btn_customerUpdate.Location = new Point(690, 304);
            btn_customerUpdate.Name = "btn_customerUpdate";
            btn_customerUpdate.Size = new Size(108, 49);
            btn_customerUpdate.TabIndex = 15;
            btn_customerUpdate.Text = "Müşteri Güncelle";
            btn_customerUpdate.UseVisualStyleBackColor = true;
            btn_customerUpdate.Click += btn_customerUpdate_Click;
            // 
            // btn_cusstomerAdd
            // 
            btn_cusstomerAdd.Location = new Point(690, 239);
            btn_cusstomerAdd.Name = "btn_cusstomerAdd";
            btn_cusstomerAdd.Size = new Size(108, 49);
            btn_cusstomerAdd.TabIndex = 14;
            btn_cusstomerAdd.Text = "Müşteri Ekle";
            btn_cusstomerAdd.UseVisualStyleBackColor = true;
            btn_cusstomerAdd.Click += btn_cusstomerAdd_Click;
            // 
            // tb_customerName
            // 
            tb_customerName.Location = new Point(639, 131);
            tb_customerName.Name = "tb_customerName";
            tb_customerName.Size = new Size(201, 27);
            tb_customerName.TabIndex = 17;
            // 
            // tb_customerContactInfo
            // 
            tb_customerContactInfo.Location = new Point(639, 195);
            tb_customerContactInfo.Name = "tb_customerContactInfo";
            tb_customerContactInfo.Size = new Size(201, 27);
            tb_customerContactInfo.TabIndex = 18;
            // 
            // CustomersPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 516);
            Controls.Add(tb_customerContactInfo);
            Controls.Add(tb_customerName);
            Controls.Add(btn_deleteCustomer);
            Controls.Add(btn_customerUpdate);
            Controls.Add(btn_cusstomerAdd);
            Controls.Add(dgv_CustomersList);
            Name = "CustomersPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomersPage";
            Load += CustomersPage_Load;
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
    }
}