using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities;
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
    public partial class ProductSalePage : Form
    {
        ISaleService _saleService;
        IProductService _productService;
        ICategoryService _categoryService;
        ICustomerService _customerService;
        public ProductSalePage()
        {
            InitializeComponent();
            _saleService = InstanceFactory.GetInstance<ISaleService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            //Product product = new Product();
            //product.StockQuantity -= Convert.ToInt32(cb_products.SelectedValue);
            var product = _productService.GetProduct(Convert.ToInt32(cb_products.SelectedValue));
            product.StockQuantity -= Convert.ToInt32(tb_quantity.Text);
            _productService.Update(product);
            _saleService.Add(new Sale
            {
                CustomerID = Convert.ToInt32(cb_customers.SelectedValue),
                ProductId = Convert.ToInt32(cb_products.SelectedValue),
                Date = tb_dateSelled.Text,
                Quantity = Convert.ToInt32(tb_quantity.Text)
            });
            
            MessageBox.Show("Ürün eklendi");
            LoadDataGridView();
        }

        private void ProductSalePage_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCustomers();
            LoadDataGridView();
        }
        void LoadDataGridView()
        {
            dgv_saleDetails.DataSource = _saleService.GetSalesDetails();
        }
        void LoadProducts()
        {
            cb_products.DataSource = _productService.GetAll().ToList();
            cb_products.ValueMember = "ProductId";
            cb_products.DisplayMember = "ProductName";
        }
        void LoadCustomers()
        {
            cb_customers.DataSource = _customerService.GetAll().ToList();
            cb_customers.ValueMember = "CustomerId";
            cb_customers.DisplayMember = "CustomerName";
        }
    }
}
