using Business.Abstract;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SaleManager : ISaleService
    {
        ISaleDal _saleDal;
        public SaleManager(ISaleDal saleDal)
        {
            _saleDal = saleDal;
        }
        public void Add(Sale sale)
        {
            ValidationTool.Validate(new ProductSaleValidator(), sale);
            _saleDal.Add(sale);
        }
        public void Update(Sale sale)
        {
            ValidationTool.Validate(new ProductSaleValidator(), sale);
            _saleDal.Update(sale);
        }

        public void Delete(Sale sale)
        {
            _saleDal.Delete(sale);
        }

        public Sale Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<SalesDetailsDto> GetSalesDetails()
        {
            return _saleDal.GetSalesDetails().ToList();
        }

        public List<SalesDetailsDto> GetSalesDetailsByCustomerName(string customerName)
        {
            return _saleDal.GetSalesDetails(s => s.CustomerName.ToLower().Contains(customerName));
        }

        public List<SalesDetailsDto> GetSalesDetailsByProductName(string productName)
        {
            return _saleDal.GetSalesDetails(s => s.ProductName.ToLower().Contains(productName));
        }

        
    }
}
