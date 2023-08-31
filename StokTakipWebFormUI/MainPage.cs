using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using DataAccess.Concrete.EntityFramework;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipWebFormUI
{
    public partial class MainPage : Form
    {
        private bool isAscending = true;

        IProductService _productService;
        public MainPage()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            ProductsPage form = new ProductsPage();
            form.ShowDialog();


        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            CategoriesPage categoriesPage = new CategoriesPage();
            categoriesPage.ShowDialog();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            CustomersPage customersPage = new CustomersPage();
            customersPage.ShowDialog();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            LoadProducts();
            dgv_products.Columns[0].Visible = false;
            //timer1.Start();
            pictureBox1.SendToBack();
            //string appFolderPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            //MessageBox.Show(appFolderPath);

        }
        public void LoadProducts()
        {
            dgv_products.DataSource = _productService.productInventories().Where(p => p.StockQuantity != 0).ToList();
            ChangeColumsName();
            //var productList = _productService.GetAll();
            //foreach (var product in productList)
            //{
            //    product.TotalPrice = product.UnitPrice * product.StockQuantity;
            //    _productService.Update(product);
            //}

        }

        private void ChangeColumsName()
        {
            dgv_products.Columns["ProductId"].HeaderText = "Ürün Id";
            dgv_products.Columns["ProductName"].HeaderText = "Ürün İsmi";
            dgv_products.Columns["StockQuantity"].HeaderText = "Stok Miktarı";
        }

        private void btn_productSale_Click(object sender, EventArgs e)
        {
            ProductSalePage productSalePage = new ProductSalePage();
            productSalePage.ShowDialog();
        }

        private void ms_products_Click(object sender, EventArgs e)
        {
            ProductsPage form = new ProductsPage();
            form.ShowDialog();
        }

        private void ms_customers_Click(object sender, EventArgs e)
        {
            CustomersPage customersPage = new CustomersPage();
            customersPage.ShowDialog();
        }

        private void ms_categories_Click(object sender, EventArgs e)
        {
            CategoriesPage categoriesPage = new CategoriesPage();
            categoriesPage.ShowDialog();
        }

        private void ms_productsSales_Click(object sender, EventArgs e)
        {
            ProductSalePage productSalePage = new ProductSalePage();
            productSalePage.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void tb_searchByProductName_TextChanged(object sender, EventArgs e)
        {

            dgv_products.DataSource = _productService.productInventories().Where(p => p.ProductName.ToLower().Contains(tb_searchByProductName.Text.ToLower())).ToList();
            //LoadProducts();
        }

        private void ms_products1_Click(object sender, EventArgs e)
        {
            ProductsPage form = new ProductsPage();
            form.ShowDialog();
        }

        private void ms_customers1_Click(object sender, EventArgs e)
        {
            CustomersPage customersPage = new CustomersPage();
            customersPage.ShowDialog();
        }

        private void ms_categories1_Click(object sender, EventArgs e)
        {
            CategoriesPage categoriesPage = new CategoriesPage();
            categoriesPage.ShowDialog();
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    LoadProducts();
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_products_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            isAscending = !isAscending;
            if (e.ColumnIndex == 1)
            {
                dgv_products.DataSource = (isAscending) ? _productService.productInventories().OrderBy(item => item.ProductName).ToList() :
                    _productService.productInventories().OrderByDescending(item => item.ProductName).ToList();
            }
            else if (e.ColumnIndex == 2)
            {
                dgv_products.DataSource = (isAscending) ? _productService.productInventories().OrderBy(item => item.StockQuantity).ToList() :
                    _productService.productInventories().OrderByDescending(item => item.StockQuantity).ToList();
            }

        }

        private void dgv_products_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductSalePage productSalePage = new ProductSalePage();
            productSalePage.ShowDialog();
        }

        private void dgv_products_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = dgv_products.Rows[e.RowIndex];
            int columnIndex = 2; // 2. sütunun indeksi
            int stockAmount = Convert.ToInt32(row.Cells[columnIndex].Value);

            //if (value < 15)
            //{
            //    row.Cells[columnIndex].Style.ForeColor = Color.Red; // Hücrenin metin rengini kırmızı yap
            //    row.Cells[columnIndex].Style.Font = new Font(dgv_products.Font, FontStyle.Bold);
            //}
            if (e.Value != null)
            {
                if (stockAmount <= 5)
                {
                    // Hücre içeriği kırmızı yapılıyor
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                }

            }

        }
    }
}
