using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities;
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
    public partial class CategoriesPage : Form
    {
        ICategoryService _categoryService;
        private bool isAscending = true;
        public CategoriesPage()
        {
            InitializeComponent();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void CategoriesPage_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
        void LoadCategories()
        {
            dgv_categoriesList.DataSource = _categoryService.GetAll().ToList();
            ChangeColumnsNames();
            HideColumnsNames();
        }
        void ChangeColumnsNames()
        {

            dgv_categoriesList.Columns["CategoryName"].HeaderText = "Kategori";

        }
        void HideColumnsNames()
        {
            dgv_categoriesList.Columns["CategoryId"].Visible = false;
        }
        private void btn_categoryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryService.Add(new Category
                {
                    CategoryName = tb_CategoryName.Text
                });
                MessageBox.Show("Kategori Eklendi");
                LoadCategories();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void btn_updateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryService.Update(new Category
                {
                    CategoryId = Convert.ToInt32(dgv_categoriesList.CurrentRow.Cells[0].Value),
                    CategoryName = tb_CategoryName.Text
                });
                MessageBox.Show("Kategori güncellendi");
                LoadCategories();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void btn_deleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seçili kategoriyi silmek istediğinizden emin misiniz?", "Kategori Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int categoryId = Convert.ToInt32(dgv_categoriesList.CurrentRow.Cells[0].Value);
                    _categoryService.Delete(new Category
                    {
                        CategoryId = categoryId
                    });
                    MessageBox.Show("Kategori Silindi");
                    LoadCategories();
                }
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


        private void dgv_categoriesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_CategoryName.Text = dgv_categoriesList.CurrentRow.Cells[1].Value.ToString();
        }

        private void CategoriesPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btn_deleteCategory_Click(sender, e);
            }
        }

        private void dgv_categoriesList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            isAscending = !isAscending;

            List<Category> sortedList;

            switch (e.ColumnIndex)
            {
                case 1: // ProductName sütunu
                    sortedList = (isAscending)
                        ? _categoryService.GetAll().OrderBy(item => item.CategoryName).ToList()
                        : _categoryService.GetAll().OrderByDescending(item => item.CategoryName).ToList();
                    break;

                default:
                    return;
            }

            dgv_categoriesList.DataSource = sortedList;
        }
    }
}
