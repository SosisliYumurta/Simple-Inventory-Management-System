﻿using Business.Abstract;
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
    public partial class CategoriesPage : Form
    {
        ICategoryService _categoryService;
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
        }

        private void btn_categoryAdd_Click(object sender, EventArgs e)
        {
            _categoryService.Add(new Category
            {
                CategoryName = tb_CategoryName.Text
            });
            MessageBox.Show("Kategori Eklendi");
            LoadCategories();
        }

        private void btn_updateCustomer_Click(object sender, EventArgs e)
        {
            _categoryService.Update(new Category
            {
                CategoryId = Convert.ToInt32(dgv_categoriesList.CurrentRow.Cells[0].Value),
                CategoryName = tb_CategoryName.Text
            });
            MessageBox.Show("Kategori güncellendi");
            LoadCategories();
        }

        private void btn_deleteCategory_Click(object sender, EventArgs e)
        {
            _categoryService.Delete(new Category
            {
                CategoryId = Convert.ToInt32(dgv_categoriesList.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Kategori Silindi");
            LoadCategories();
        }

        private void dgv_categoriesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_CategoryName.Text = dgv_categoriesList.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
