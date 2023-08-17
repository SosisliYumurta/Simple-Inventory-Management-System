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
        }
        void LoadProducts()
        {
            dgv_products.DataSource = _productService.GetProductDetail();
            ChangeColumsName();
        }

        private void ChangeColumsName()
        {
            dgv_products.Columns["ProductName"].HeaderText = "Ürün İsmi";
            dgv_products.Columns["CategoryName"].HeaderText = "Kategori İsmi";
            dgv_products.Columns["StockQuantity"].HeaderText = "Stok Miktarı";
            dgv_products.Columns["UnitPrice"].HeaderText = "Birim Fiyatı";
            dgv_products.Columns["DateAdded"].HeaderText = "Eklenme Tarihi";
        }

        private void btn_productSale_Click(object sender, EventArgs e)
        {
            ProductSalePage productSalePage = new ProductSalePage();
            productSalePage.ShowDialog();
        }
    }
}
