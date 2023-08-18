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
    public partial class CustomersPage : Form
    {
        private ICustomerService _customerService;
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
                _customerService.Delete(new Customer
                {
                    CustomerId = Convert.ToInt32(dgv_CustomersList.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("Müşteri Silindi");
                LoadCustomers();
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
        }
    }
}
