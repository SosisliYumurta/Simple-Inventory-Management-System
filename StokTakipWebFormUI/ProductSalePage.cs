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
            try
            {
                var product = _productService.GetProduct(Convert.ToInt32(cb_products.SelectedValue));
                product.StockQuantity -= Convert.ToInt32(tb_quantity.Text);
                _productService.Update(product);
                _saleService.Add(new Sale
                {
                    CustomerID = Convert.ToInt32(cb_customers.SelectedValue),
                    ProductId = Convert.ToInt32(cb_products.SelectedValue),
                    Date = dtp_dateProductSale.Text,
                    Quantity = Convert.ToInt32(tb_quantity.Text)
                });

                MessageBox.Show("Ürün teslim edildi");
                LoadDataGridView();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            //Product product = new Product();
            //product.StockQuantity -= Convert.ToInt32(cb_products.SelectedValue);

        }

        private void ProductSalePage_Load(object sender, EventArgs e)
        {

            LoadProducts();
            LoadCustomers();
            LoadDataGridView();
            ChangeColumsNames();
            HideClomunsName();

        }

        private void HideClomunsName()
        {
            dgv_saleDetails.Columns["SaleId"].Visible = false;
        }

        private void ChangeColumsNames()
        {
            dgv_saleDetails.Columns["ProductName"].HeaderText = "Ürün İsmi";
            dgv_saleDetails.Columns["CustomerName"].HeaderText = "Müşteri İsmi";
            dgv_saleDetails.Columns["CompanyName"].HeaderText = "Firma İsmi";
            dgv_saleDetails.Columns["Quantity"].HeaderText = "Teslim Edilen Miktar";
            dgv_saleDetails.Columns["Date"].HeaderText = "Teslim Edilme Tarihi";
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

        private void tb_searchByCustomerName_TextChanged(object sender, EventArgs e)
        {
            dgv_saleDetails.DataSource = _saleService.GetSalesDetailsByCustomerName(tb_searchByCustomerName.Text);

        }

        private void tb_searchByProductName_TextChanged(object sender, EventArgs e)
        {
            dgv_saleDetails.DataSource = _saleService.GetSalesDetailsByProductName(tb_searchByProductName.Text);
        }

        private void btn_updateProductSale_Click(object sender, EventArgs e)
        {

            try
            {
                int total = Convert.ToInt32(dgv_saleDetails.CurrentRow.Cells[4].Value) - Convert.ToInt32(tb_quantity.Text);
                var product = _productService.GetProduct(Convert.ToInt32(cb_products.SelectedValue));
                product.StockQuantity += total;
                _productService.Update(product);
                _saleService.Update(new Sale
                {
                    SaleID = Convert.ToInt32(dgv_saleDetails.CurrentRow.Cells[0].Value),
                    CustomerID = Convert.ToInt32(cb_customers.SelectedValue),
                    ProductId = Convert.ToInt32(cb_products.SelectedValue),
                    Quantity = Convert.ToInt32(tb_quantity.Text),
                    Date = dtp_dateProductSale.Text

                });
                MessageBox.Show("Teslimat bilgisi Güncellendi");
                LoadDataGridView();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_deleteProductSale_Click(object sender, EventArgs e)
        {
            try
            {
                _saleService.Delete(new Sale
                {
                    SaleID = Convert.ToInt32(dgv_saleDetails.CurrentRow.Cells[0].Value),
                });
                MessageBox.Show("Teslimat Silindi");
                LoadDataGridView();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void dgv_saleDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_products.Text = dgv_saleDetails.CurrentRow.Cells[1].Value.ToString();
            cb_customers.Text = dgv_saleDetails.CurrentRow.Cells[2].Value.ToString();
            tb_quantity.Text = dgv_saleDetails.CurrentRow.Cells[4].Value.ToString();
            dtp_dateProductSale.Text = dgv_saleDetails.CurrentRow.Cells[5].Value.ToString();
        }

        private void ProductSalePage_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void ProductSalePage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Formu kapat
            }
        }

        private void btn_sell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_sell_Click(sender, e);
            }
        }
    }
}
