using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISaleService
    {
        void Add(Sale product);
        void Update(Sale product);
        void Delete(Sale product);
        List<Sale> GetAll();
        Sale Get(int id);
        List<SalesDetailsDto> GetSalesDetails();
    }
}
