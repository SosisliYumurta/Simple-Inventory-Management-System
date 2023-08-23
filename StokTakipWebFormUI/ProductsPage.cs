using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using Font = System.Drawing.Font;

namespace StokTakipWebFormUI
{
    public partial class ProductsPage : Form
    {
        private bool isAscending = true;
        private bool isDateActive = false;
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

            ChangeColumsName();
            TotalPriceForAllProducts();
        }

        void TotalPriceForAllProducts()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dgw_productsList.Rows)
            {
                if (row.Cells["TotalPrice"].Value != null &&
                    decimal.TryParse(row.Cells["TotalPrice"].Value.ToString(), out decimal value))
                {
                    sum += value;
                }
            }
            lbl_totalPrice.Text = sum.ToString();
        }
        private void ChangeColumsName()
        {
            dgw_productsList.Columns["ProductId"].HeaderText = "Ürün Id";
            dgw_productsList.Columns["ProductName"].HeaderText = "Ürün Ýsmi";
            dgw_productsList.Columns["CategoryName"].HeaderText = "Ürün Kategori Ýsmi";
            dgw_productsList.Columns["FirstStock"].HeaderText = "Toplam Stok Miktarý";
            dgw_productsList.Columns["StockQuantity"].HeaderText = "Kalan Stok Miktarý";
            dgw_productsList.Columns["DateAdded"].HeaderText = "Ürün Eklenme Tarihi";
            dgw_productsList.Columns["UnitPrice"].HeaderText = "Ürün Birim Fiyatý";
            dgw_productsList.Columns["TotalPrice"].HeaderText = "Toplam Fiyat";
        }
        void LoadCategoryForAdding()
        {
            cb_categoryName.DataSource = _categoryService.GetAll();
            cb_categoryName.ValueMember = "CategoryId";
            cb_categoryName.DisplayMember = "CategoryName";
        }
        void  LoadProducts()
        {
            
            dgw_productsList.DataSource = _productService.GetProductDetail();
            dgw_productsList.Columns[0].Visible = false;
            TotalPriceForAllProducts();

        }
        void LoadCategory()
        {
            cb_searchByCategoryName.DataSource = _categoryService.GetAll().Select(c => c.CategoryName).ToList();
            TotalPriceForAllProducts();
        }

        private void tb_searchByProductName_TextChanged(object sender, EventArgs e)
        {

            if (dtp_start.Value.ToString() == dtp_end.Value.ToString())
            {
                dgw_productsList.DataSource = _productService.GetProdcutsDetailsByProductName(tb_searchByProductName.Text.ToLower());
                TotalPriceForAllProducts();
            }
            //dgw_productsList.DataSource = _productService.GetProdcutsDetailsByProductName(tb_searchByProductName.Text.ToLower());
            //TotalPriceForAllProducts();
            else
            {
                filter();
            }

        }

        private void cb_searchByCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgw_productsList.DataSource = _productService.GetProductsDetailsByCategoryName(cb_searchByCategoryName.Text);
                TotalPriceForAllProducts();
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
                    FirstStock = Convert.ToInt32(tb_firstStock.Text),
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
                    FirstStock = Convert.ToInt32(tb_firstStock.Text),
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
            tb_firstStock.Text = row.Cells["FirstStock"].Value.ToString();
            tb_stockQuantity.Text = row.Cells["StockQuantity"].Value.ToString();
            tb_unitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
            dtp_dateAdded.Text = row.Cells["DateAdded"].Value.ToString();
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seçili ürünü silmek istediðinizden emin misiniz?", "Ürün Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int productId = Convert.ToInt32(dgw_productsList.CurrentRow.Cells[0].Value);
                    _productService.Delete(new Product
                    {
                        ProductId = productId,
                    });
                    MessageBox.Show("Ürün silindi");
                    LoadProducts();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Seçilecek öðe bulunamadý veya seçim yapmadýnýz");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }



        private void ProductsPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btn_deleteProduct_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
        void ExportToExcel()
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
            }
        }

        private void btn_reflesh_Click(object sender, EventArgs e)
        {
            
            dtp_end.Text = DateTime.Now.ToString();
            dtp_start.Text = DateTime.Now.ToString();
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
            //DateTime start = dtp_start.Value.AddDays(-1);
            //DateTime end = dtp_end.Value;

            //dgw_productsList.DataSource = _productService.GetProductDetail().Where(p => DateTime.Parse(p.DateAdded) >= start && DateTime.Parse(p.DateAdded) < end).ToList();
            //TotalPriceForAllProducts();
            //***************************

            DateTime start = dtp_start.Value.AddDays(-1);
            DateTime end = dtp_end.Value;

            string productNameFilter = tb_searchByProductName.Text.ToLower();

            var products = _productService.GetProductDetail();


            if (!string.IsNullOrWhiteSpace(productNameFilter))
            {
                products = products.Where(p => p.ProductName.ToLower().Contains(productNameFilter)).ToList();
            }

            products = products.Where(p => DateTime.Parse(p.DateAdded) >= start && DateTime.Parse(p.DateAdded) < end).ToList();


            dgw_productsList.DataSource = products;
            TotalPriceForAllProducts();





        }

        private void dgw_productsList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            isAscending = !isAscending;

            List<ProductDetailDto> sortedList;

            switch (e.ColumnIndex)
            {
                case 1:
                    sortedList = (isAscending)
                        ? _productService.GetProductDetail().OrderBy(item => item.ProductName).ToList()
                        : _productService.GetProductDetail().OrderByDescending(item => item.ProductName).ToList();
                    break;

                case 2:
                    sortedList = (isAscending)
                        ? _productService.GetProductDetail().OrderBy(item => item.CategoryName).ToList()
                        : _productService.GetProductDetail().OrderByDescending(item => item.CategoryName).ToList();
                    break;
                case 3:
                    sortedList = (isAscending)
                        ? _productService.GetProductDetail().OrderBy(item => item.FirstStock).ToList()
                        : _productService.GetProductDetail().OrderByDescending(item => item.FirstStock).ToList();
                    break;

                case 4:
                    sortedList = (isAscending)
                        ? _productService.GetProductDetail().OrderBy(item => item.StockQuantity).ToList()
                        : _productService.GetProductDetail().OrderByDescending(item => item.StockQuantity).ToList();
                    break;

                case 5:
                    sortedList = (isAscending)
                        ? _productService.GetProductDetail().OrderBy(item => item.UnitPrice).ToList()
                        : _productService.GetProductDetail().OrderByDescending(item => item.UnitPrice).ToList();
                    break;

                case 6:
                    sortedList = (isAscending)
                        ? _productService.GetProductDetail().OrderBy(item => item.TotalPrice).ToList()
                        : _productService.GetProductDetail().OrderByDescending(item => item.TotalPrice).ToList();
                    break;
                case 7:
                    sortedList = (isAscending)
                        ? _productService.GetProductDetail().OrderBy(item => DateTime.Parse(item.DateAdded)).ToList()
                        : _productService.GetProductDetail().OrderByDescending(item => DateTime.Parse(item.DateAdded)).ToList();
                    break;

                default:
                    return;
            }

            dgw_productsList.DataSource = sortedList;
        }

        private void dgw_productsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int columnIndex1 = 3; // 4. sütunun indeksi
            int columnIndex2 = 6; // 7. sütunun indeksi

            if (e.RowIndex >= 0 && (e.ColumnIndex == columnIndex1 || e.ColumnIndex == columnIndex2))
            {
                DataGridViewRow row = dgw_productsList.Rows[e.RowIndex];
                int value = Convert.ToInt32(row.Cells[e.ColumnIndex].Value);


                //row.Cells[e.ColumnIndex].Style.ForeColor = Color.Red; // Hücrenin metin rengini kýrmýzý yap
                row.Cells[e.ColumnIndex].Style.Font = new Font(dgw_productsList.Font, FontStyle.Bold);


            }
        }
    }
}