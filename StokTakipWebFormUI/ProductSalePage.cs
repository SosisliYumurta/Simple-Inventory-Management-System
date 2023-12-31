﻿using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities;
using Entities.Dtos;
using Microsoft.Office.Interop.Excel;
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

        private bool isAscending = true;
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
                LoadProducts();
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
        public class ProductComboBoxItem
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public int StockQuantity { get; set; }

            public override string ToString()
            {
                return $"{ProductName} + ({StockQuantity} Adet)";
            }
        }
        void LoadProducts()
        {
            cb_products.DataSource = _productService.GetAll().Where(p => p.StockQuantity != 0).OrderBy(p => p.ProductName).ToList();
            cb_products.ValueMember = "ProductId";
            cb_products.DisplayMember = "ProductName";
        }
        void LoadCustomers()
        {
            cb_customers.DataSource = _customerService.GetAll().OrderBy(p => p.CustomerName).ToList();
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
                LoadProducts();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Seçilecek öğe bulunamadı veya seçim yapmadınız");
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
                //int total = Convert.ToInt32(dgv_saleDetails.CurrentRow.Cells[4].Value) - Convert.ToInt32(tb_quantity.Text);
                var product = _productService.GetProduct(Convert.ToInt32(cb_products.SelectedValue));
                product.StockQuantity += Convert.ToInt32(dgv_saleDetails.CurrentRow.Cells["Quantity"].Value);
                if (MessageBox.Show("Seçili teslimatı silmek istediğinizden emin misiniz?", "Teslimat Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int saleId = Convert.ToInt32(dgv_saleDetails.CurrentRow.Cells[0].Value);
                    _saleService.Delete(new Sale
                    {
                        SaleID = saleId,
                    });
                    MessageBox.Show("Teslimat Silindi");
                    LoadDataGridView();
                    LoadProducts();
                }

                _productService.Update(product);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Seçilecek öğe bulunamadı veya seçim yapmadınız");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        private void dgv_saleDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_products.Text = dgv_saleDetails.CurrentRow.Cells["ProductName"].Value.ToString();
            cb_customers.Text = dgv_saleDetails.CurrentRow.Cells["CustomerName"].Value.ToString();
            tb_quantity.Text = dgv_saleDetails.CurrentRow.Cells["Quantity"].Value.ToString();
            dtp_dateProductSale.Text = dgv_saleDetails.CurrentRow.Cells["Date"].Value.ToString();
        }

        private void ProductSalePage_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void ProductSalePage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btn_deleteProductSale_Click(sender, e);
            }
        }

        private void btn_sell_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ProductSalePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.LoadProducts();
        }

        private void ProductSalePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.LoadProducts();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            if (dgv_saleDetails.Columns.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = excel.Workbooks.Add(Type.Missing);
                Worksheet sheet = (Worksheet)workbook.ActiveSheet;

                for (int i = 1; i <= dgv_saleDetails.Columns.Count; i++)
                {
                    sheet.Cells[1, i] = dgv_saleDetails.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv_saleDetails.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_saleDetails.Columns.Count; j++)
                    {
                        sheet.Cells[i + 2, j + 1] = dgv_saleDetails.Rows[i].Cells[j].Value.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadProducts();
        }
        void filter()
        {
            DateTime start = dtp_start.Value.AddDays(-1);
            DateTime end = dtp_end.Value;

            dgv_saleDetails.DataSource = _saleService.GetSalesDetails().Where(s => DateTime.Parse(s.Date) >= start && DateTime.Parse(s.Date) < end).ToList();
        }

        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void dtp_end_ValueChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void dgv_saleDetails_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            isAscending = !isAscending;

            List<SalesDetailsDto> sortedList;

            switch (e.ColumnIndex)
            {
                case 1: // ProductName sütunu
                    sortedList = (isAscending)
                        ? _saleService.GetSalesDetails().OrderBy(item => item.ProductName).ToList()
                        : _saleService.GetSalesDetails().OrderByDescending(item => item.ProductName).ToList();
                    break;

                case 2: // CustomerName sütunu
                    sortedList = (isAscending)
                        ? _saleService.GetSalesDetails().OrderBy(item => item.CustomerName).ToList()
                        : _saleService.GetSalesDetails().OrderByDescending(item => item.CustomerName).ToList();
                    break;

                case 3: // CompanyName sütunu
                    sortedList = (isAscending)
                        ? _saleService.GetSalesDetails().OrderBy(item => item.CompanyName).ToList()
                        : _saleService.GetSalesDetails().OrderByDescending(item => item.CompanyName).ToList();
                    break;

                case 4: // Quantity sütunu
                    sortedList = (isAscending)
                        ? _saleService.GetSalesDetails().OrderBy(item => item.Quantity).ToList()
                        : _saleService.GetSalesDetails().OrderByDescending(item => item.Quantity).ToList();
                    break;

                case 5: // Date sütunu
                    sortedList = (isAscending)
                        ? _saleService.GetSalesDetails().OrderBy(item => DateTime.Parse(item.Date)).ToList()
                        : _saleService.GetSalesDetails().OrderByDescending(item => DateTime.Parse(item.Date)).ToList();
                    break;

                default:
                    return;
            }

            dgv_saleDetails.DataSource = sortedList;
        }

        private void cb_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            StockPlaceHolderText();
        }

        private void StockPlaceHolderText()
        {
            if (cb_products.SelectedItem != null)
            {
                var selectedProduct = (Product)cb_products.SelectedItem;
                tb_quantity.Clear();
                lbl_note.Text = selectedProduct.Note;
                if (selectedProduct.StockQuantity <= 0)
                {
                    tb_quantity.PlaceholderText = "Stok tükenmiştir.";
                }
                else
                {
                    tb_quantity.PlaceholderText = "Mevcut Stok: " + selectedProduct.StockQuantity.ToString();
                }

                //tb_quantity.PlaceholderText = "Mevcut Stok: "+selectedProduct.StockQuantity.ToString();
            }
            else
            {
                tb_quantity.Clear();
            }
        }

        private void btn_fillProducts_Click(object sender, EventArgs e)
        {
            cb_products.DataSource = _productService.GetAll().OrderBy(p => p.ProductName).ToList();
            cb_products.ValueMember = "ProductId";
            cb_products.DisplayMember = "ProductName";
        }
    }
}
