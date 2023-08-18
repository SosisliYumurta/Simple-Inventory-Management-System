using Entities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISaleService
    {
        void Add(Sale sale);
        void Update(Sale sale);
        void Delete(Sale sale);
        List<Sale> GetAll();
        Sale Get(int id);
        List<SalesDetailsDto> GetSalesDetails();
        List<SalesDetailsDto> GetSalesDetailsByCustomerName(string customerName);
        List<SalesDetailsDto> GetSalesDetailsByProductName(string productName);
    }
}
