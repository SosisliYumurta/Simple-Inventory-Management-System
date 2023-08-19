using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Excel;
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
            LoadCategory();
            LoadProducts();

            LoadCategoryForAdding();
            dgw_productsList.Columns[0].Visible = false;
            ChangeColumsName();
        }

        void TotalPriceForAllProducts()
        {

        }
        private void ChangeColumsName()
        {
            dgw_productsList.Columns["ProductId"].HeaderText = "Ürün Id";
            dgw_productsList.Columns["ProductName"].HeaderText = "Ürün Ýsmi";
            dgw_productsList.Columns["CategoryName"].HeaderText = "Ürün Kategori Ýsmi";
            dgw_productsList.Columns["StockQuantity"].HeaderText = "Ürün Stok Miktarý";
            dgw_productsList.Columns["DateAdded"].HeaderText = "Ürün Eklenme Tarihi";
            dgw_productsList.Columns["UnitPrice"].HeaderText = "Ürün Birim Fiyatý";
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
            cb_searchByCategoryName.DataSource = _categoryService.GetAll().Select(c => c.CategoryName).ToList();
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
            tb_productName.Text = row.Cells["ProductName"].Value.ToString();
            cb_categoryName.Text = row.Cells["CategoryName"].Value.ToString();
            tb_stockQuantity.Text = row.Cells["StockQuantity"].Value.ToString();
            tb_unitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
            dtp_dateAdded.Text = row.Cells["DateAdded"].Value.ToString();
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

        private void ProductsPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgw_productsList.Columns.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = excel.Workbooks.Add(Type.Missing);
                Worksheet sheet = (Worksheet)workbook.ActiveSheet;

                for (int i = 1; i <= dgw_productsList.Columns.Count; i++)
                {
                    sheet.Cells[1, i] = dgw_productsList.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgw_productsList.Rows.Count; i++)
                {
                    for (int j = 0; j < dgw_productsList.Columns.Count; j++)
                    {
                        sheet.Cells[i + 2, j + 1] = dgw_productsList.Rows[i].Cells[j].Value.ToString();
                    }
                }

                sheet.Columns.AutoFit();
                excel.Visible = true;

                ReleaseExcelObject(sheet);
                ReleaseExcelObject(workbook);
                ReleaseExcelObject(excel);

            }
            void ReleaseExcelObject(object obj)
            {
                try
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                    obj = null;
                }
                catch (Exception ex)
                {
                    obj = null;
                }
                finally
                {
                    GC.Collect();
                }
            }
        }

        private void btn_reflesh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dtp_end_ValueChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            filter();
        }
        void filter()
        {
            DateTime start = dtp_start.Value.AddDays(-1);
            DateTime end = dtp_end.Value;

            dgw_productsList.DataSource = _productService.GetProductDetail().Where(p => DateTime.Parse(p.DateAdded) >= start && DateTime.Parse(p.DateAdded) < end).ToList();
        }
    }
}