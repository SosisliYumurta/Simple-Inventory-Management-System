using Business.Abstract;
using Business.DependencyResolvers.Ninject;
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
            //dgv_products.Columns[0].Width = -1;
            dgv_products.Columns[0].Visible = false;
            timer1.Start();

        }
        public  void LoadProducts()
        {
            dgv_products.DataSource = _productService.productInventories();
            ChangeColumsName();
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
            if (tb_searchByProductName.Text == null)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
            dgv_products.DataSource = _productService.productInventories().Where(p => p.ProductName.ToLower().Contains(tb_searchByProductName.Text)).ToList();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
