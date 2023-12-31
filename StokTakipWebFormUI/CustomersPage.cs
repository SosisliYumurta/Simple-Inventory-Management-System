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
    public partial class CustomersPage : Form
    {
        private ICustomerService _customerService;

        private bool isAscending = true;

        public CustomersPage()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();

        }

        private void CustomersPage_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        void LoadCustomers()
        {
            dgv_CustomersList.DataSource = _customerService.GetAll();
            ChangeColumsName();
            HideColums();
        }
        private void ChangeColumsName()
        {
            //dgv_CustomersList.Columns["CustomerId"].HeaderText = "Müşteri Id";
            dgv_CustomersList.Columns["CustomerName"].HeaderText = "Müşteri Adı";
            dgv_CustomersList.Columns["CompanyName"].HeaderText = "Firma Adı";
        }
        void HideColums()
        {
            dgv_CustomersList.Columns["CustomerId"].Visible = false;
            dgv_CustomersList.Columns["ContactInfo"].Visible = false;
        }

        private void btn_cusstomerAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _customerService.Add(new Customer
                {
                    CustomerName = tb_customerName.Text,
                    CompanyName = tb_companyName.Text,
                    ContactInfo = tb_customerContactInfo.Text,
                });
                MessageBox.Show("Müşteri Eklendi");
                LoadCustomers();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void btn_customerUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _customerService.Update(new Customer
                {
                    CustomerId = Convert.ToInt32(dgv_CustomersList.CurrentRow.Cells[0].Value),
                    CompanyName = tb_companyName.Text,

                    ContactInfo = tb_customerContactInfo.Text,
                    CustomerName = tb_customerName.Text,
                });
                MessageBox.Show("Müşteri Güncellendi");
                LoadCustomers();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void dgv_CustomersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_customerName.Text = dgv_CustomersList.CurrentRow.Cells[1].Value.ToString();
            tb_customerContactInfo.Text = dgv_CustomersList.CurrentRow.Cells[3].Value.ToString();
            tb_companyName.Text = dgv_CustomersList.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_deleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seçili müşteriyi silmek istediğinizden emin misiniz?", "Müşteri Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int customerId = Convert.ToInt32(dgv_CustomersList.CurrentRow.Cells[0].Value);
                    _customerService.Delete(new Customer
                    {
                        CustomerId = customerId
                    });
                    MessageBox.Show("Müşteri Silindi");
                    LoadCustomers();
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


        private void CustomersPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btn_deleteCustomer_Click(sender, e);
            }
        }

        private void dgv_CustomersList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            isAscending = !isAscending;

            List<Customer> sortedList;

            switch (e.ColumnIndex)
            {
                case 1:
                    sortedList = (isAscending)
                        ? _customerService.GetAll().OrderBy(item => item.CustomerName).ToList()
                        : _customerService.GetAll().OrderByDescending(item => item.CustomerName).ToList();
                    break;
                case 2:
                    sortedList = (isAscending)
                        ? _customerService.GetAll().OrderBy(item => item.CompanyName).ToList()
                        : _customerService.GetAll().OrderByDescending(item => item.CompanyName).ToList();
                    break;

                default:
                    return;
            }

            dgv_CustomersList.DataSource = sortedList;
        }
    }
}
