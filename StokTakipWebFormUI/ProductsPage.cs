using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace StokTakipWebFormUI
{
    public partial class ProductsPage : Form
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        public ProductsPage()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            //LoadCategory();
            LoadCategoryForAdding();
            dgw_productsList.Columns[0].Visible = false;
        }
        void LoadCategoryForAdding()
        {
            cb_categoryName.DataSource = _categoryService.GetAll();
            cb_categoryName.ValueMember = "CategoryId";
            cb_categoryName.DisplayMember = "CategoryName";
        }
        void LoadProducts()
        {
            dgw_productsList.DataSource = _productService.GetProductDetail();
        }
        void LoadCategory()
        {
            cb_searchByCategoryName.DataSource = _productService.GetProductDetail().Select(c => c.CategoryName).ToList();
        }

        private void tb_searchByProductName_TextChanged(object sender, EventArgs e)
        {
            dgw_productsList.DataSource = _productService.GetProdcutsDetailsByProductName(tb_searchByProductName.Text);
        }

        private void cb_searchByCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgw_productsList.DataSource = _productService.GetProductsDetailsByCategoryName(cb_searchByCategoryName.Text);
            }
            catch
            {
            }
        }

        private void btn_productAdd_Click(object sender, EventArgs e)
        {
            try
            {             
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cb_categoryName.SelectedValue),
                    ProductName = tb_productName.Text,
                    StockQuantity = Convert.ToInt32(tb_stockQuantity.Text),
                    UnitPrice = Convert.ToDecimal(tb_unitPrice.Text),
                    DateAdded = dtp_dateAdded.Text,
                });
                MessageBox.Show("Ürün eklendi");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgw_productsList.CurrentRow.Cells[0].Value),
                    ProductName = tb_productName.Text,
                    CategoryId = Convert.ToInt32(cb_categoryName.SelectedValue),
                    StockQuantity = Convert.ToInt32(tb_stockQuantity.Text),
                    UnitPrice = Convert.ToDecimal(tb_unitPrice.Text),
                    DateAdded = dtp_dateAdded.Text,
                });
                MessageBox.Show("Ürün Güncellendi");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }          
        }

        private void dgw_productsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgw_productsList.CurrentRow;
            tb_productName.Text = row.Cells[1].Value.ToString();
            cb_categoryName.Text = row.Cells[2].Value.ToString();
            tb_stockQuantity.Text = row.Cells[3].Value.ToString();
            tb_unitPrice.Text = row.Cells[4].Value.ToString();
            dtp_dateAdded.Text = row.Cells[5].Value.ToString();
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Delete(new Product
                {
                    ProductId = Convert.ToInt32(dgw_productsList.CurrentRow.Cells[0].Value),
                });
                MessageBox.Show("Ürün silindi");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}